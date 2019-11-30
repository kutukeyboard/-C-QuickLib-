using System;
using System.ComponentModel;

namespace QuickLib.Lib
{

  [TypeConverter(typeof(QValidationConverter))]
  public class QTextValidation 
  {
    public bool CanBeNullOrEmpty { get; set; }= true;
    public int MinCharCount { get; set; }
    public int MaxCharCount { get; set; }
    public bool IsNumeric { get; set; } = false;
    public float MinValue {get; set; }
    public float MaxValue {get;set;}
  }

  internal class QValidationConverter : TypeConverter
  {
    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context,
        object value, Attribute[] filter)
    {
      return TypeDescriptor.GetProperties(value, filter);
    }

    public override bool GetPropertiesSupported(ITypeDescriptorContext context)
    {
      return true;
    }
  }
}
