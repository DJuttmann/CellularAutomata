using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;


namespace CellularAutomata
{

  class RuleParsing
  {
    static Regex RulePattern = new Regex ("^([0-8][a-e]*)*/([0-8][a-e]*)*,[0-9]+$");


    // Perform basic validation of rule string.
    public static bool ValidateRule (string rule)
    {
      return RulePattern.IsMatch (rule);
    }


    // Delete all whitespace characters from string (space, tab, newline).
    public static string RemoveSpaces (ref string str)
    {
      StringBuilder noSpace = new StringBuilder (String.Empty);
      for (int i = 0; i < str.Length; i++)
        if (str [i] != ' '  && str [i] != '\t' && 
            str [i] != '\r' && str [i] != '\n')
          noSpace.Append (str [i]);
      return noSpace.ToString ();
    }


    // Check if a character is a digit.
    private static bool IsDigit (char c)
    {
      return (c >= '0' && c <= '9');
    }


    // Check if a character is a lowercase letter a-e.
    private static bool IsLetter (char c)
    {
      return (c >= 'a' && c <= 'e');
    }


    // Get a digit from a birth/survival string at position index + modifier values.
    // Returns -1 on failure, index is updated to position of next character.
    public static int GetDigit (string str, ref int index, ref List <int> modifiers)
    {
      if (index >= str.Length || !IsDigit (str [index]) )
        return -1;
      int digit = str [index] - '0';

      var newModifiers = new List <int> ();
      int modifier = 0;
      index++;
      while (index < str.Length && IsLetter (str [index]))
      {
        modifier = str [index] - 'a';
        if (modifier <= digit && digit - modifier <= 4)
          newModifiers.Add (modifier);
        else
          return -1;
        index++;
      }
      if (newModifiers.Count == 0)
        for (int i = Math.Max (0, digit - 4); i <= Math.Min (4, digit); i++)
          newModifiers.Add (i);

      modifiers = newModifiers;
      return digit;
    }


    // Split a rule string into birth/survival string and a state count int.
    public static bool SplitRule (string rule, ref string birth, ref string survival,
                                  ref int stateCount)
    {
      string [] split = rule.Split (new [] {','});
      if (split.Length != 2)
        return false;
      stateCount = Convert.ToInt32 (split [1]);
      split = split [0].Split (new [] {'/'});
      if (split.Length != 2)
        return false;
      birth = split [0];
      survival = split [1];
      return true;
    }
  }
}
