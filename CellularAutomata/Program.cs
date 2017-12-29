//========================================================================================
// Reference
// https://msdn.microsoft.com/en-us/library/5ey6h79d(v=vs.110).aspx
// http://net-informations.com/q/faq/imgtobyte.html
//========================================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CellularAutomata
{

//========================================================================================
// Class RandomGenerator
﻿//========================================================================================


  class RandomGenerator
  {
    public static Random Generator = new Random ();

    public static byte RandomByte (int max)
    {
      return Convert.ToByte (Generator.Next (max));
    }
  }
  

//========================================================================================
// Class Palette
﻿//========================================================================================


  class Palette
  {
    private List <Tuple <byte, byte, byte>> Colours = new List <Tuple <byte, byte, byte>> ();
    static readonly Tuple <byte, byte, byte> Black = new Tuple <byte, byte, byte> (0, 0, 0);
    

    public Tuple <byte, byte, byte> this [int i]
    {
      get
      {
        if (i < Colours.Count)
          return Colours [i];
        return Black;
      }
      set
      {
        if (i < Colours.Count)
          Colours [i] = value;
        else if (i == Colours.Count)
          AddColour (value);
      }
    }


    public void Clear () {
      Colours.Clear ();
    }


    public void AddColour (Tuple <byte, byte, byte> colour)
    {
      Colours.Add (colour);
    }

    
    public void AddColour (byte red, byte green, byte blue)
    {
      Colours.Add (new Tuple <byte, byte, byte> (red, green, blue));
    }
  }


//========================================================================================
// Class Automaton
﻿//========================================================================================


  class Automaton
  {
    private byte [,] Cells;
    private byte [,] CellsCopy;
//    private int Padding = 1;
    private int width;
    private int height;
    private int StateCount;
    private Func <Automaton, int, int, byte> Rule;
    public Palette ColourPalette;
    public byte [] ImageData {get; private set;}
    int Generation;
    ByteLookup [] LookupTable;
    Byte [] DecayLookup;
    
    public int Width 
    {
      get {return width - 2;}
      private set {width = value + 2;}
    }
    public int Height
    {
      get {return height - 2;}
      private set {height = value + 2;}
    }
    public byte this [int row, int col]
    {
      get
      {
        return Cells [row, col];
      }
      set
      {
        Cells [row, col] = value;
      }
    }


//========================================================================================
// Methods

    
    // Constructor based on rule function.
    public Automaton (int width, int height, int stateCount,
                      Func <Automaton, int, int, byte> rule)
    {
      this.Width = width;
      this.Height = height;
      StateCount = stateCount;
      Rule = rule;
      Cells = new byte [this.height, this.width];
      CellsCopy = new byte [this.height, this.width];
      ImageData = new byte [this.Width * this.Height * 3];
      Generation = 0;
    }


    // Constructor based on rule Lookup Table.
    public Automaton (int width, int height, int stateCount,
                      ByteLookup [] lookup, byte [] decayLookup)
    {
      this.Width = width;
      this.Height = height;
      StateCount = stateCount;
      LookupTable = lookup;
      DecayLookup = decayLookup;
      Cells = new byte [this.height, this.width];
      CellsCopy = new byte [this.height, this.width];
      ImageData = new byte [this.Width * this.Height * 3];
      Generation = 0;
    }


    // Fill cells with random values.
    public void Randomize ()
    {
      for (int i = 0; i < height; i++)
        for (int j = 0; j < width; j++)
          Cells [i, j] = RandomGenerator.RandomByte (StateCount);
    }


    // Copy borders of grid to padding on opposite sides of grid.
    public void CopyBorders ()
    {
      int iMax = Height + 1;
      for (int j = 0; j < 1; j++)
        for (int i = 1; i < iMax; i++)
        {
          CellsCopy [i, 0] = CellsCopy [i, Width + j];
          CellsCopy [i, width - 1 - j] = CellsCopy [i, 1 - j];
        }
      for (int i = 0; i < 1; i++)
        for (int j = 0; j < width; j++)
        {
          CellsCopy [0, j] = CellsCopy [Height + i, j];
          CellsCopy [height - 1 - i, j] = CellsCopy [1 - i, j];
        }
    }


    // Generate the next generation of the CA.
    public void NextGeneration ()
    {
      Generation++;
      int iMax = Height + 1;
      int jMax = Width + 1;
      for (int i = 1; i < iMax; i++)
        for (int j = 1; j < jMax; j++)
          CellsCopy [i, j] = Rule (this, i, j);
      CopyBorders ();
      var temp = Cells;
      Cells = CellsCopy;
      CellsCopy = temp;
    }


    // Feed 8 new pixels into the lookup table index.
    void FeedPixels (ref int value, byte [,] Cells, int i, int j)
    {
      value >>= 8;
      value |= Cells [i    , j] == Rules.Alive ? 0b1_00000000 : 0;
      value |= Cells [i + 1, j] == Rules.Alive ? 0b10_00000000 : 0;
      value |= Cells [i + 2, j] == Rules.Alive ? 0b100_00000000 : 0;
      value |= Cells [i + 3, j] == Rules.Alive ? 0b1000_00000000 : 0;
      j++;
      value |= Cells [i    , j] == Rules.Alive ? 0b10000_00000000 : 0;
      value |= Cells [i + 1, j] == Rules.Alive ? 0b100000_00000000 : 0;
      value |= Cells [i + 2, j] == Rules.Alive ? 0b1000000_00000000 : 0;
      value |= Cells [i + 3, j] == Rules.Alive ? 0b10000000_00000000 : 0;
    }


    // Generate the next generation four pixels at a time using lookup tables.
    public void FastGeneration ()
    {
      Generation++;
      int iMax = Height + 1;
      int jMax = Width + 1;
      int pixels;
      for (int i = 1; i < iMax; i += 2)
      {
        pixels = 0;
        FeedPixels (ref pixels, Cells, i - 1, 0);
        for (int j = 1; j < jMax; j += 2)
        {
          FeedPixels (ref pixels, Cells, i - 1, j + 1);
          if (Cells [i, j] < 2)
            CellsCopy [i, j] = LookupTable [pixels].Byte0;
          else
            CellsCopy [i, j] = DecayLookup [Cells [i, j]];
          if (Cells [i, j + 1] < 2)
            CellsCopy [i, j + 1] = LookupTable [pixels].Byte1;
          else
            CellsCopy [i, j + 1] = DecayLookup [Cells [i, j + 1]];
          if (Cells [i + 1, j] < 2)
            CellsCopy [i + 1, j] = LookupTable [pixels].Byte2;
          else
            CellsCopy [i + 1, j] = DecayLookup [Cells [i + 1, j]];
          if (Cells [i, j + 1] < 2)
            CellsCopy [i + 1, j + 1] = LookupTable [pixels].Byte3;
          else
            CellsCopy [i + 1, j + 1] = DecayLookup [Cells [i + 1, j + 1]];
        }
      }

      CopyBorders ();
      var temp = Cells;
      Cells = CellsCopy;
      CellsCopy = temp;
    }


    public void Render ()
    {
      for (int i = 0; i < Height; i++)
        for (int j = 0; j < Width; j++)
        {
          var colour = ColourPalette [Cells [i + 1, j + 1]];
          ImageData [(Width * i + j) * 3    ] = colour.Item1;
          ImageData [(Width * i + j) * 3 + 1] = colour.Item2;
          ImageData [(Width * i + j) * 3 + 2] = colour.Item3;
        }
    }


  }


//========================================================================================
// Class Rules
﻿//========================================================================================

  struct ByteLookup
  {
    public byte Byte0;
    public byte Byte1;
    public byte Byte2;
    public byte Byte3;
  }


  class Rules
  {
    public const int LookupCount = 1 << 16;
    public const byte Alive = 1;
    public const byte Dead = 0;


    private static byte GetBit (int value, int index)
    {
      return (value & (1 << index)) > 0 ? Alive : Dead;
    }


    public static void CreateLookup (ref ByteLookup [] lookup, ref byte [] decayLookup,
                                     Func <Automaton, int, int, byte> Rule,
                                     int statecount)
    {
      lookup = new ByteLookup [LookupCount];
      Automaton A = new Automaton (4, 4, 256, Rule);
      for (int n = 0; n < LookupCount; n++)
      {
        for (int col = 0; col < 4; col++)
          for (int row = 0; row < 4; row++)
            A [row, col] = GetBit (n, 4 * col + row);
        A.NextGeneration ();
        lookup [n].Byte0 = A [1, 1];
        lookup [n].Byte1 = A [1, 2];
        lookup [n].Byte2 = A [2, 1];
        lookup [n].Byte3 = A [2, 2];
      }

      decayLookup = new byte [statecount];
      for (int n = 2; n < statecount; n++)
        decayLookup [n] = n + 1 < statecount ? Convert.ToByte (n + 1) : Dead;
    }



    public static int CountNeighbours (Automaton A, int row, int col, byte value)
    {
      int total = 0;
      for (int i = -1; i < 2; i++)
        for (int j = -1; j < 2; j++)
          if (A [row + i, col + j] == value)
            total++;
      return total;
    }


    public static byte StarWars (Automaton A, int row, int col)
    {
      switch (A [row, col])
      {
      case 0:
        if (CountNeighbours (A, row, col, 1) == 2)
          return 1;
        return 0;
      case 1:
        int count = CountNeighbours (A, row, col, 1);
        if (count < 4 || count > 6)
          return 2;
        return 1;
      case 2:
        return 3;
      case 3:
        return 0;
      }
      return 1;
    }
  }


//========================================================================================
// Class Program
﻿//========================================================================================


  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main ()
    {
      Application.EnableVisualStyles ();
      Application.SetCompatibleTextRenderingDefault (false);
      Application.Run (new Form1 ());
    }
  }
}
