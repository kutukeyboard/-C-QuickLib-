using System;
using System.ComponentModel;

namespace QuickLib.Lib
{

  [TypeConverter(typeof(QValidationConverter))]
  public class QTextValidation 
  {
    public bool CanBeNullOrEmpty { get; set; }= true;
    
    int _minCharCount;
    public int MinCharCount {  
      get=> _minCharCount;
      set {
        _minCharCount = value;
        if (value > MaxCharCount) { 
          MaxCharCount = value;
        }
      }
    }

    int _maxCharCount;
    public int MaxCharCount { 
      get=> _maxCharCount;
      set { 
        _maxCharCount = value;
        if(value < MinCharCount) { 
          MinCharCount = value;
        }
      }
    }

    bool _isNumeric;
    public bool IsNumeric {  
    get=> _isNumeric;
      set { 
        _isNumeric = value;
        if(value == true) { 
          IsEmailAddress = false;
        }
      }
    }

    float _minValue;
    public float MinValue {
      get=> _minValue;
      set { 
        _minValue = value;
        if(value > MaxValue) { 
          MaxValue = value;
        }
      }
    } 

    float _maxValue;
    public float MaxValue {
      get=> _maxValue;
      set { 
        _maxValue = value;
        if(value < MinValue) { 
          MinValue = value;
        }
      }
    }

    bool _isEmailAddress = false;
    public bool IsEmailAddress {
      get => _isEmailAddress;
      set {
        _isEmailAddress = value;
        if (value == true)
        {
          IsNumeric = false;
          IsPhoneNumber = false;
          MinCharCount = 10;
          MaxCharCount = 255;
        }
      }
    }

    bool _isPhoneNumber;
    public bool IsPhoneNumber { 
      get=>_isPhoneNumber;
      set { 
        _isPhoneNumber = value;
        if(value == true) {
          IsNumeric = false;
          IsEmailAddress = false;
          MinCharCount = 5;
          MaxCharCount = 20;
        }
      }
    }
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
