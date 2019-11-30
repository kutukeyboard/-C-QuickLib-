using System;
using System.ComponentModel;
using System.Windows.Forms;
using QuickLib.Lib;

namespace QuickLib.Controls
{
  public partial class QTextBox : TextBox
  {
    private ToolTip _tooltip = new ToolTip();
    public QTextValidation Validation { get;set;} = new QTextValidation();
    
    public string Hints { 
      set {_tooltip.SetToolTip(this, value);}
    }
    public QTextBox()
    {
      InitializeComponent();
    }

    private void Validate()
    {
      string _hints ="";
      BackColor = QStyle.BackgroundColor;
      if (Validation.CanBeNullOrEmpty == false && Text == "")
      {
        BackColor = QStyle.DangerColor;
        _hints = "Text can not be empty";
      }

      if (Validation.MinCharCount > 0 && Text.Length < Validation.MinCharCount)
      {
        BackColor = QStyle.DangerColor;
        _hints += _hints.Length > 0 ? Environment.NewLine + "Text can not less than " + Validation.MinCharCount + " character" : "Text can not less than " + Validation.MinCharCount + " character";
      }

      if (Validation.MaxCharCount > 0 && Text.Length > Validation.MaxCharCount)
      {
        BackColor = QStyle.DangerColor;
        _hints += _hints.Length > 0 ? Environment.NewLine + "Text must be less than " + Validation.MinCharCount + " character" : "Text can must be less than " + Validation.MinCharCount + " character";
      }

      if (Validation.IsNumeric == true && Text != "" && float.TryParse(Text, out float _) ==false)
      {
        BackColor = QStyle.DangerColor;
        _hints += "Value must be numeric";
      }
      if (Validation.IsNumeric == true && Text != "" && float.TryParse(Text, out float _) == true && float.Parse(Text) < Validation.MinValue)
      {
        BackColor = QStyle.DangerColor;
        _hints += "Value must be greater then " + Validation.MinValue;
      }
      if (Validation.IsNumeric == true && Text != "" && float.TryParse(Text, out float _) == true && float.Parse(Text) > Validation.MaxValue)
      {
        BackColor = QStyle.DangerColor;
        _hints += "Value must be smaller then " + Validation.MaxValue;
      }
      Hints = _hints;
    }

    private void Text_Changed(object sender, EventArgs e)
    {
      Validate();
    }

    public QTextBox(IContainer container)
    {
      container.Add(this);
      InitializeComponent();
    }
    
    
    
  }
}
