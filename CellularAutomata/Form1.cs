using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CellularAutomata
{
  public partial class Form1: Form
  {
    private const int FrameDelay = 16;

    private Automaton A;
    ByteLookup [] lookup;
    byte [] decayLookup;

    private Bitmap AutomatonImage;
    private Rectangle AutomatonRectangle;
    private Graphics Gfx;

    private PictureBox Picture;
    Timer UpdateTimer;

    private int CAWidth = 600;
    private int CAHeight = 400;


    // Constructor
    public Form1 ()
    {
      InitializeComponent ();
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Width = this.Width - this.ClientSize.Width + 2 * CAWidth;
      this.Height = this.Height - this.ClientSize.Height + 2 * CAHeight;
      this.Top = 0;
      this.Left = 0;

      SetupAutomaton ();

      AutomatonImage = new Bitmap (CAWidth, CAHeight, PixelFormat.Format24bppRgb);
      AutomatonRectangle = new Rectangle (0, 0, CAWidth, CAHeight);
      Gfx = this.CreateGraphics ();
      PaintEventArgs PaintEvent = new PaintEventArgs (Gfx, AutomatonRectangle);

      Picture = new PictureBox ();
      Picture.Dock = DockStyle.Fill;
      Picture.BackColor = Color.White;
      Picture.Paint += new System.Windows.Forms.PaintEventHandler(DisplayAutomaton);
      Controls.Add (Picture);

      UpdateTimer = new Timer ();
      UpdateTimer.Interval = FrameDelay;
      UpdateTimer.Tick += UpdateAutomaton;
      UpdateTimer.Start ();
    }


    private void SetupAutomaton ()
    {
      List <int> birth = new List <int> (new [] {2});
      List <int> death = new List <int> (new [] {3, 4, 5});
      int stateCount = 4;

      Rules.SetDecayRule (birth, death, stateCount);
      Rules.CreateLookup (ref lookup, ref decayLookup, Rules.Decay);
      Palette palette = Rules.CreatePalette ();

      A = new Automaton (CAWidth, CAHeight, lookup, decayLookup);
      A.ColourPalette = palette;
      A.Randomize ();
    }


    // Update and render CA to screen.
    private void UpdateAutomaton (object sender, EventArgs e)
    {
//      A.NextGeneration ();
      A.FastGeneration ();
      Picture.Invalidate ();
    }


    // Paint method for CA.
    public void DisplayAutomaton (object sender, System.Windows.Forms.PaintEventArgs e)
    {
      A.Render ();
      BitmapData Data = AutomatonImage.LockBits (AutomatonRectangle,
                                                 ImageLockMode.WriteOnly,
                                                 PixelFormat.Format24bppRgb);
      IntPtr ptr = Data.Scan0;
      System.Runtime.InteropServices.Marshal.Copy (A.ImageData, 0, ptr,
                                                   A.Width * A.Height * 3);
      AutomatonImage.UnlockBits (Data);
      e.Graphics.InterpolationMode =
        System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
      e.Graphics.DrawImage (AutomatonImage, 0, 0, CAWidth * 2, CAHeight * 2);
//      AutomatonImage.Save ("testfile.bmp", ImageFormat.Bmp);
//      Console.WriteLine ("Test");
    }


    // Display the settings window.
    private void ShowSettings ()
    {
      FormSettings settings = new FormSettings ();
      if (settings.ShowDialog () == DialogResult.OK)
      {
        Rules.CreateLookup (ref lookup, ref decayLookup, Rules.Decay);
        Palette palette = Rules.CreatePalette ();
        A.SetRule (lookup, decayLookup);
        A.ColourPalette = palette;
      }
    }


    // Key press handler.
    private void Form1_KeyDown (object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
      case Keys.Escape:
        ShowSettings ();
        break;
      case Keys.Enter:
        if (UpdateTimer.Enabled)
          UpdateTimer.Stop ();
        else
          UpdateTimer.Start ();
        break;
      case Keys.Space:
        if (UpdateTimer.Enabled)
          UpdateTimer.Stop ();
        else
          UpdateAutomaton (null, null);
        break;
      case Keys.F5:
        A.Randomize ();
        Picture.Invalidate ();
        break;
      default:
        break;
      }
    }
  }
}
