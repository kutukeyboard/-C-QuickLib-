namespace QuickLib
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
      this.components = new System.ComponentModel.Container();
      QuickLib.Lib.QTextValidation qTextValidation1 = new QuickLib.Lib.QTextValidation();
      QuickLib.Lib.QTextValidation qTextValidation2 = new QuickLib.Lib.QTextValidation();
      this.button1 = new System.Windows.Forms.Button();
      this.qTextBox2 = new QuickLib.Controls.QTextBox(this.components);
      this.qTextBox1 = new QuickLib.Controls.QTextBox(this.components);
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.button1.AutoSize = true;
      this.button1.Location = new System.Drawing.Point(347, 165);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // qTextBox2
      // 
      this.qTextBox2.BackColor = System.Drawing.Color.White;
      this.qTextBox2.Location = new System.Drawing.Point(347, 135);
      this.qTextBox2.Name = "qTextBox2";
      this.qTextBox2.Size = new System.Drawing.Size(100, 20);
      this.qTextBox2.TabIndex = 1;
      qTextValidation1.CanBeNullOrEmpty = true;
      qTextValidation1.IsEmailAddress = false;
      qTextValidation1.IsNumeric = false;
      qTextValidation1.IsPhoneNumber = true;
      qTextValidation1.MaxCharCount = 20;
      qTextValidation1.MaxValue = 100F;
      qTextValidation1.MinCharCount = 5;
      qTextValidation1.MinValue = 10F;
      this.qTextBox2.Validation = qTextValidation1;
      // 
      // qTextBox1
      // 
      this.qTextBox1.Location = new System.Drawing.Point(347, 109);
      this.qTextBox1.Name = "qTextBox1";
      this.qTextBox1.Size = new System.Drawing.Size(100, 20);
      this.qTextBox1.TabIndex = 0;
      qTextValidation2.CanBeNullOrEmpty = false;
      qTextValidation2.IsEmailAddress = true;
      qTextValidation2.IsNumeric = false;
      qTextValidation2.IsPhoneNumber = false;
      qTextValidation2.MaxCharCount = 10;
      qTextValidation2.MaxValue = 0F;
      qTextValidation2.MinCharCount = 10;
      qTextValidation2.MinValue = 0F;
      this.qTextBox1.Validation = qTextValidation2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(619, 458);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.qTextBox2);
      this.Controls.Add(this.qTextBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Controls.QTextBox qTextBox1;
    private Controls.QTextBox qTextBox2;
    private System.Windows.Forms.Button button1;
  }
}