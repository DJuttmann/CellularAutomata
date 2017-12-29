using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellularAutomata
{
  public partial class FormSettings: Form
  {
    CheckBox [] BirthChecks = new CheckBox [9];
    CheckBox [] SurvivalChecks = new CheckBox [9];
    Label [] NumberLabels = new Label [9];


    public FormSettings ()
    {
      InitializeComponent ();

      bool [] birth = null;
      bool [] survival = null;
      int stateCount = 0;
      Rules.GetDecayRules (ref birth, ref survival, ref stateCount);
      for (int i = 0; i < 9; i++)
      {
        NumberLabels [i] = new Label ()
        {
          Text = i.ToString (),
          Top = 15,
          Left = 100 + 30 * i,
          Width = 20
        };
        Controls.Add (NumberLabels [i]);

        BirthChecks [i] = new CheckBox ()
        {
          Checked = birth [i],
          Top = 38,
          Left = 100 + 30 * i,
          Width = 20
        };
        Controls.Add (BirthChecks [i]);

        SurvivalChecks [i] = new CheckBox ()
        {
          Checked = survival [i],
          Top = 70,
          Left = 100 + 30 * i,
          Width = 20
        };
        Controls.Add (SurvivalChecks [i]);
      }

      textBoxStateCount.Text = stateCount.ToString ();
    }


    private void buttonOK_Click (object sender, EventArgs e)
    {
      List <int> birth = new List <int> ();
      List <int> survival = new List <int> ();
      int stateCount = Convert.ToInt32 (textBoxStateCount.Text);
      if (stateCount > 256)
        stateCount = 256;
      if (stateCount < 0)
        stateCount = 0;

      for (int i = 0; i < 9; i++)
      {
        if (BirthChecks [i].Checked)
          birth.Add (i);
        if (SurvivalChecks [i].Checked)
          survival.Add (i);
      }

      Rules.SetDecayRule (birth, survival, stateCount);
      DialogResult = DialogResult.OK;
      Dispose ();
    }


    private void buttonCancel_Click (object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      Dispose ();
    }
  }
}
