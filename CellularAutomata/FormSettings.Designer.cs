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
      this.buttonSetBasic = new System.Windows.Forms.Button();
      this.groupBoxBasic = new System.Windows.Forms.GroupBox();
      this.numericBasicStateCount = new System.Windows.Forms.NumericUpDown();
      this.checkBoxReload = new System.Windows.Forms.CheckBox();
      this.groupBoxSaved = new System.Windows.Forms.GroupBox();
      this.buttonSetSaved = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.groupBoxAdvanced = new System.Windows.Forms.GroupBox();
      this.buttonSetAdvanced = new System.Windows.Forms.Button();
      this.textBoxRule = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.groupBoxBasic.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericBasicStateCount)).BeginInit();
      this.groupBoxSaved.SuspendLayout();
      this.groupBoxAdvanced.SuspendLayout();
      this.SuspendLayout();
      // 
      // labelBirth
      // 
      this.labelBirth.AutoSize = true;
      this.labelBirth.Location = new System.Drawing.Point(6, 53);
      this.labelBirth.Name = "labelBirth";
      this.labelBirth.Size = new System.Drawing.Size(37, 17);
      this.labelBirth.TabIndex = 0;
      this.labelBirth.Text = "Birth";
      // 
      // labelSurvival
      // 
      this.labelSurvival.AutoSize = true;
      this.labelSurvival.Location = new System.Drawing.Point(6, 92);
      this.labelSurvival.Name = "labelSurvival";
      this.labelSurvival.Size = new System.Drawing.Size(58, 17);
      this.labelSurvival.TabIndex = 1;
      this.labelSurvival.Text = "Survival";
      // 
      // labelStateCount
      // 
      this.labelStateCount.AutoSize = true;
      this.labelStateCount.Location = new System.Drawing.Point(6, 131);
      this.labelStateCount.Name = "labelStateCount";
      this.labelStateCount.Size = new System.Drawing.Size(82, 17);
      this.labelStateCount.TabIndex = 2;
      this.labelStateCount.Text = "State Count";
      // 
      // buttonSetBasic
      // 
      this.buttonSetBasic.Location = new System.Drawing.Point(257, 131);
      this.buttonSetBasic.Name = "buttonSetBasic";
      this.buttonSetBasic.Size = new System.Drawing.Size(75, 23);
      this.buttonSetBasic.TabIndex = 3;
      this.buttonSetBasic.Text = "Set";
      this.buttonSetBasic.UseVisualStyleBackColor = true;
      this.buttonSetBasic.Click += new System.EventHandler(this.buttonSetBasic_Click);
      // 
      // groupBoxBasic
      // 
      this.groupBoxBasic.Controls.Add(this.button1);
      this.groupBoxBasic.Controls.Add(this.numericBasicStateCount);
      this.groupBoxBasic.Controls.Add(this.labelStateCount);
      this.groupBoxBasic.Controls.Add(this.buttonSetBasic);
      this.groupBoxBasic.Controls.Add(this.labelSurvival);
      this.groupBoxBasic.Controls.Add(this.labelBirth);
      this.groupBoxBasic.Location = new System.Drawing.Point(11, 2);
      this.groupBoxBasic.Name = "groupBoxBasic";
      this.groupBoxBasic.Size = new System.Drawing.Size(451, 171);
      this.groupBoxBasic.TabIndex = 6;
      this.groupBoxBasic.TabStop = false;
      this.groupBoxBasic.Text = "Basic Decay Rule";
      // 
      // numericBasicStateCount
      // 
      this.numericBasicStateCount.Location = new System.Drawing.Point(100, 130);
      this.numericBasicStateCount.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
      this.numericBasicStateCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numericBasicStateCount.Name = "numericBasicStateCount";
      this.numericBasicStateCount.Size = new System.Drawing.Size(62, 22);
      this.numericBasicStateCount.TabIndex = 7;
      this.numericBasicStateCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // checkBoxReload
      // 
      this.checkBoxReload.AutoSize = true;
      this.checkBoxReload.Location = new System.Drawing.Point(20, 371);
      this.checkBoxReload.Name = "checkBoxReload";
      this.checkBoxReload.Size = new System.Drawing.Size(235, 21);
      this.checkBoxReload.TabIndex = 6;
      this.checkBoxReload.Text = "Reload pattern when setting rule";
      this.checkBoxReload.UseVisualStyleBackColor = true;
      // 
      // groupBoxSaved
      // 
      this.groupBoxSaved.Controls.Add(this.buttonSetSaved);
      this.groupBoxSaved.Controls.Add(this.listBox1);
      this.groupBoxSaved.Location = new System.Drawing.Point(468, 2);
      this.groupBoxSaved.Name = "groupBoxSaved";
      this.groupBoxSaved.Size = new System.Drawing.Size(224, 363);
      this.groupBoxSaved.TabIndex = 7;
      this.groupBoxSaved.TabStop = false;
      this.groupBoxSaved.Text = "Saved Rules";
      // 
      // buttonSetSaved
      // 
      this.buttonSetSaved.Location = new System.Drawing.Point(78, 327);
      this.buttonSetSaved.Name = "buttonSetSaved";
      this.buttonSetSaved.Size = new System.Drawing.Size(75, 23);
      this.buttonSetSaved.TabIndex = 8;
      this.buttonSetSaved.Text = "Set";
      this.buttonSetSaved.UseVisualStyleBackColor = true;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 16;
      this.listBox1.Location = new System.Drawing.Point(8, 21);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(210, 292);
      this.listBox1.TabIndex = 0;
      // 
      // groupBoxAdvanced
      // 
      this.groupBoxAdvanced.Controls.Add(this.label10);
      this.groupBoxAdvanced.Controls.Add(this.label9);
      this.groupBoxAdvanced.Controls.Add(this.label8);
      this.groupBoxAdvanced.Controls.Add(this.label7);
      this.groupBoxAdvanced.Controls.Add(this.label6);
      this.groupBoxAdvanced.Controls.Add(this.label5);
      this.groupBoxAdvanced.Controls.Add(this.label4);
      this.groupBoxAdvanced.Controls.Add(this.label3);
      this.groupBoxAdvanced.Controls.Add(this.label2);
      this.groupBoxAdvanced.Controls.Add(this.label1);
      this.groupBoxAdvanced.Controls.Add(this.button2);
      this.groupBoxAdvanced.Controls.Add(this.buttonSetAdvanced);
      this.groupBoxAdvanced.Controls.Add(this.textBoxRule);
      this.groupBoxAdvanced.Location = new System.Drawing.Point(11, 179);
      this.groupBoxAdvanced.Name = "groupBoxAdvanced";
      this.groupBoxAdvanced.Size = new System.Drawing.Size(451, 186);
      this.groupBoxAdvanced.TabIndex = 8;
      this.groupBoxAdvanced.TabStop = false;
      this.groupBoxAdvanced.Text = "Advanced Decay Rule";
      // 
      // buttonSetAdvanced
      // 
      this.buttonSetAdvanced.Location = new System.Drawing.Point(257, 82);
      this.buttonSetAdvanced.Name = "buttonSetAdvanced";
      this.buttonSetAdvanced.Size = new System.Drawing.Size(75, 23);
      this.buttonSetAdvanced.TabIndex = 8;
      this.buttonSetAdvanced.Text = "Set";
      this.buttonSetAdvanced.UseVisualStyleBackColor = true;
      this.buttonSetAdvanced.Click += new System.EventHandler(this.buttonSetAdvanced_Click);
      // 
      // textBoxRule
      // 
      this.textBoxRule.Location = new System.Drawing.Point(9, 36);
      this.textBoxRule.Name = "textBoxRule";
      this.textBoxRule.Size = new System.Drawing.Size(436, 22);
      this.textBoxRule.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(358, 131);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 9;
      this.button1.Text = "Save";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(358, 82);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 10;
      this.button2.Text = "Save";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 85);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(24, 17);
      this.label1.TabIndex = 11;
      this.label1.Text = "0a";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 102);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 17);
      this.label2.TabIndex = 12;
      this.label2.Text = "1ab";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 119);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(39, 17);
      this.label3.TabIndex = 13;
      this.label3.Text = "2abc";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(9, 136);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(47, 17);
      this.label4.TabIndex = 14;
      this.label4.Text = "3abcd";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(9, 153);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(55, 17);
      this.label5.TabIndex = 15;
      this.label5.Text = "4abcde";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(47, 85);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(47, 17);
      this.label6.TabIndex = 16;
      this.label6.Text = "5bcde";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(55, 102);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(39, 17);
      this.label7.TabIndex = 17;
      this.label7.Text = "6cde";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(62, 119);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(32, 17);
      this.label8.TabIndex = 18;
      this.label8.Text = "7de";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(70, 136);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(24, 17);
      this.label9.TabIndex = 19;
      this.label9.Text = "8e";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(147, 153);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(138, 17);
      this.label10.TabIndex = 20;
      this.label10.Text = "birth / death, #states";
      // 
      // FormSettings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(704, 404);
      this.Controls.Add(this.groupBoxAdvanced);
      this.Controls.Add(this.checkBoxReload);
      this.Controls.Add(this.groupBoxSaved);
      this.Controls.Add(this.groupBoxBasic);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "FormSettings";
      this.Text = "Settings";
      this.groupBoxBasic.ResumeLayout(false);
      this.groupBoxBasic.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericBasicStateCount)).EndInit();
      this.groupBoxSaved.ResumeLayout(false);
      this.groupBoxAdvanced.ResumeLayout(false);
      this.groupBoxAdvanced.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelBirth;
    private System.Windows.Forms.Label labelSurvival;
    private System.Windows.Forms.Label labelStateCount;
    private System.Windows.Forms.Button buttonSetBasic;
    private System.Windows.Forms.GroupBox groupBoxBasic;
    private System.Windows.Forms.NumericUpDown numericBasicStateCount;
    private System.Windows.Forms.CheckBox checkBoxReload;
    private System.Windows.Forms.GroupBox groupBoxSaved;
    private System.Windows.Forms.Button buttonSetSaved;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.GroupBox groupBoxAdvanced;
    private System.Windows.Forms.TextBox textBoxRule;
    private System.Windows.Forms.Button buttonSetAdvanced;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label10;
  }
}