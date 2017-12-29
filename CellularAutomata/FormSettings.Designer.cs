namespace CellularAutomata
{
  partial class FormSettings
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose (bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose ();
      }
      base.Dispose (disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent ()
    {
      this.labelBirth = new System.Windows.Forms.Label();
      this.labelSurvival = new System.Windows.Forms.Label();
      this.labelStateCount = new System.Windows.Forms.Label();
      this.buttonOK = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.textBoxStateCount = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // labelBirth
      // 
      this.labelBirth.AutoSize = true;
      this.labelBirth.Location = new System.Drawing.Point(25, 54);
      this.labelBirth.Name = "labelBirth";
      this.labelBirth.Size = new System.Drawing.Size(37, 17);
      this.labelBirth.TabIndex = 0;
      this.labelBirth.Text = "Birth";
      // 
      // labelSurvival
      // 
      this.labelSurvival.AutoSize = true;
      this.labelSurvival.Location = new System.Drawing.Point(25, 93);
      this.labelSurvival.Name = "labelSurvival";
      this.labelSurvival.Size = new System.Drawing.Size(58, 17);
      this.labelSurvival.TabIndex = 1;
      this.labelSurvival.Text = "Survival";
      // 
      // labelStateCount
      // 
      this.labelStateCount.AutoSize = true;
      this.labelStateCount.Location = new System.Drawing.Point(25, 132);
      this.labelStateCount.Name = "labelStateCount";
      this.labelStateCount.Size = new System.Drawing.Size(82, 17);
      this.labelStateCount.TabIndex = 2;
      this.labelStateCount.Text = "State Count";
      // 
      // buttonOK
      // 
      this.buttonOK.Location = new System.Drawing.Point(180, 181);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new System.Drawing.Size(75, 23);
      this.buttonOK.TabIndex = 3;
      this.buttonOK.Text = "OK";
      this.buttonOK.UseVisualStyleBackColor = true;
      this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.Location = new System.Drawing.Point(309, 181);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 4;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // textBoxStateCount
      // 
      this.textBoxStateCount.Location = new System.Drawing.Point(130, 129);
      this.textBoxStateCount.MaxLength = 3;
      this.textBoxStateCount.Name = "textBoxStateCount";
      this.textBoxStateCount.Size = new System.Drawing.Size(48, 22);
      this.textBoxStateCount.TabIndex = 5;
      // 
      // FormSettings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(570, 230);
      this.Controls.Add(this.textBoxStateCount);
      this.Controls.Add(this.buttonCancel);
      this.Controls.Add(this.buttonOK);
      this.Controls.Add(this.labelStateCount);
      this.Controls.Add(this.labelSurvival);
      this.Controls.Add(this.labelBirth);
      this.Name = "FormSettings";
      this.Text = "Settings";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelBirth;
    private System.Windows.Forms.Label labelSurvival;
    private System.Windows.Forms.Label labelStateCount;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.TextBox textBoxStateCount;
  }
}