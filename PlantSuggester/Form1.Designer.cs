namespace PlantSuggester
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.cbSouthWindow = new System.Windows.Forms.CheckBox();
      this.trkDegrees = new System.Windows.Forms.TrackBar();
      this.txtDegrees = new System.Windows.Forms.Label();
      this.lblPlantSuggest = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lnkplant411 = new System.Windows.Forms.LinkLabel();
      ((System.ComponentModel.ISupportInitialize)(this.trkDegrees)).BeginInit();
      this.SuspendLayout();
      // 
      // cbSouthWindow
      // 
      this.cbSouthWindow.AutoSize = true;
      this.cbSouthWindow.Location = new System.Drawing.Point(58, 48);
      this.cbSouthWindow.Name = "cbSouthWindow";
      this.cbSouthWindow.Size = new System.Drawing.Size(253, 29);
      this.cbSouthWindow.TabIndex = 0;
      this.cbSouthWindow.Text = "South facing window?";
      this.cbSouthWindow.UseVisualStyleBackColor = true;
      this.cbSouthWindow.CheckedChanged += new System.EventHandler(this.houseConditionsChange);
      // 
      // trkDegrees
      // 
      this.trkDegrees.Location = new System.Drawing.Point(58, 187);
      this.trkDegrees.Maximum = 90;
      this.trkDegrees.Minimum = 50;
      this.trkDegrees.Name = "trkDegrees";
      this.trkDegrees.Size = new System.Drawing.Size(385, 90);
      this.trkDegrees.TabIndex = 1;
      this.trkDegrees.Value = 50;
      this.trkDegrees.Scroll += new System.EventHandler(this.trkDegrees_Scroll);
      // 
      // txtDegrees
      // 
      this.txtDegrees.Location = new System.Drawing.Point(427, 187);
      this.txtDegrees.Name = "txtDegrees";
      this.txtDegrees.Size = new System.Drawing.Size(73, 46);
      this.txtDegrees.TabIndex = 3;
      this.txtDegrees.Text = "50 °F";
      this.txtDegrees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblPlantSuggest
      // 
      this.lblPlantSuggest.AutoSize = true;
      this.lblPlantSuggest.Location = new System.Drawing.Point(53, 280);
      this.lblPlantSuggest.Name = "lblPlantSuggest";
      this.lblPlantSuggest.Size = new System.Drawing.Size(175, 25);
      this.lblPlantSuggest.TabIndex = 4;
      this.lblPlantSuggest.Text = "Plant Suggestion";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(53, 117);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(258, 25);
      this.label3.TabIndex = 5;
      this.label3.Text = "How warm is your house?";
      // 
      // lnkplant411
      // 
      this.lnkplant411.AutoSize = true;
      this.lnkplant411.Location = new System.Drawing.Point(300, 331);
      this.lnkplant411.Name = "lnkplant411";
      this.lnkplant411.Size = new System.Drawing.Size(200, 25);
      this.lnkplant411.TabIndex = 6;
      this.lnkplant411.TabStop = true;
      this.lnkplant411.Text = "houseplant411.com";
      this.lnkplant411.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkplant411_LinkClicked);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(519, 365);
      this.Controls.Add(this.lnkplant411);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lblPlantSuggest);
      this.Controls.Add(this.txtDegrees);
      this.Controls.Add(this.trkDegrees);
      this.Controls.Add(this.cbSouthWindow);
      this.Name = "Form1";
      this.Text = "House Plant Suggestions";
      ((System.ComponentModel.ISupportInitialize)(this.trkDegrees)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox cbSouthWindow;
    private System.Windows.Forms.TrackBar trkDegrees;
    private System.Windows.Forms.Label txtDegrees;
    private System.Windows.Forms.Label lblPlantSuggest;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.LinkLabel lnkplant411;
  }
}

