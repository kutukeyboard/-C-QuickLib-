using System;
using System.ComponentModel;
using System.Windows.Forms;
using QuickLib.Lib;
using System.Text.RegularExpressions;

namespace QuickLib.Controls
{
  public partial class QTextBox : TextBox
  {
    #region Props
    private ToolTip _tooltip = new ToolTip();
    public QTextValidation Validation { get;set;} = new QTextValidation();
    
    public string Hints { 
      set {_tooltip.SetToolTip(this, value);}
    }
    #endregion

    #region Container
    public QTextBox()
    {
      InitializeComponent();
    }
    public QTextBox(IContainer container)
    {
      container.Add(this);
      InitializeComponent();
    }
    #endregion

    #region Methods
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
        _hints += _hints.Length > 0 ? Environment.NewLine + "Text must be less than " + Validation.MaxCharCount + " character" : "Text can must be less than " + Validation.MaxCharCount + " character";
      }

      if (Validation.IsNumeric == true && Text != "" && float.TryParse(Text, out float _) ==false)
      {
        BackColor = QStyle.DangerColor;
        _hints += _hints.Length > 0 ? Environment.NewLine + "Value must be numeric" : "Value must be numeric";
      }
      if (Validation.IsNumeric == true && Text != "" && float.TryParse(Text, out float _) == true && float.Parse(Text) < Validation.MinValue)
      {
        BackColor = QStyle.DangerColor;
        _hints += _hints.Length > 0 ? Environment.NewLine + "Value must be greater then " + Validation.MinValue : "Value must be greater then " + Validation.MinValue;
      }
      if (Validation.IsNumeric == true && Text != "" && float.TryParse(Text, out float _) == true && float.Parse(Text) > Validation.MaxValue)
      {
        BackColor = QStyle.DangerColor;
        _hints += _hints.Length > 0 ? Environment.NewLine + "Value must be smaller then " + Validation.MaxValue : "Value must be smaller then " + Validation.MaxValue;
      }

      if(Validation.IsEmailAddress == true && Text !="" && !Regex.IsMatch(Text, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$")) {
        BackColor = QStyle.DangerColor;
        _hints += _hints.Length > 0 ? Environment.NewLine + "Email address must be in format : xxx@xxx.xx" : "Email address must be in format : xxx@xxx.xx";
      }

      if (Validation.IsPhoneNumber == true && Text != "" && !Regex.IsMatch(Text, "^((\\+[0-9]{2}-?)|0)?[0-9]+$"))
      {
        BackColor = QStyle.DangerColor;
        _hints += _hints.Length > 0 ? Environment.NewLine + "Phone number must be in number only" : "Phone number must be in number only";
      }
      Hints = _hints;
    }

    private void Text_Changed(object sender, EventArgs e)
    {
      Validate();
    }
    #endregion

  }
}
