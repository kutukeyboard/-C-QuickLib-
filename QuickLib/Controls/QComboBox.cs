using System;
using System.ComponentModel;
using System.Windows.Forms;
using QuickLib.Lib;

namespace QuickLib.Controls
{
  public partial class QComboBox : ComboBox
  {
    #region Props
    private ToolTip _tooltip = new ToolTip();
    
    public string Hints {
      set { _tooltip.SetToolTip(this, value); }
    }
    #endregion

    #region Container
    public QComboBox()
    {
      InitializeComponent();
    }

    public QComboBox(IContainer container)
    {
      this.AutoCompleteSource = AutoCompleteSource.ListItems;
      this.AutoCompleteMode = AutoCompleteMode.Suggest;
      this.DropDownStyle = ComboBoxStyle.DropDown;

      container.Add(this);

      InitializeComponent();
    }
    #endregion

    #region Methods
    
    private void Validate()
    { 
      string _hints ="";
      this.BackColor = QStyle.BackgroundColor;
      int index = this.Items.IndexOf(this.Text);
      if (index <0) { 
        this.BackColor = QStyle.DangerColor;
        _hints = "Please select item from dropdown list";
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
