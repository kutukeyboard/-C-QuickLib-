using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickLib.Lib
{
  public class QStyle
  {

    #region Props
    public static Color PrimaryColor { get;set;} = Color.FromArgb(3,155,229);
    public static Color SuccessColor { get;set;}
    public static Color DangerColor {get;set;} = Color.FromArgb(183,28,28);
    public static Color WarningColor { get; set; }
    public static Color TextColor {get;set;} = Color.LightGray;
    public static Color BackgroundColor { get; set; } = Color.FromArgb(66,66,66);
    #endregion

    public static void Apply(Control Parent) {
      Parent.BackColor=BackgroundColor;
      foreach (Control item in Parent.Controls)
      {
        item.BackColor = BackgroundColor;
        item.ForeColor = TextColor;
        item.Font = new Font(new FontFamily("Segoe UI"),8);

        if(item.GetType() == typeof(TextBox) || item.GetType() == typeof(Controls.QTextBox)) { 
          (item as TextBox).BorderStyle = BorderStyle.FixedSingle ;
        }

        if(item.GetType() == typeof(Button)) { 
          (item as Button).FlatStyle = FlatStyle.Flat;
          (item as Button).BackColor = PrimaryColor;
        }


        if(item.HasChildren) { 
          Apply(item);
        }
      }
    }
  }
}
