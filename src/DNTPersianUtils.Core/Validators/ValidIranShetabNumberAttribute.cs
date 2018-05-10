using System;
using System.ComponentModel.DataAnnotations;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// Determines whether the specified value of the object is a valid IranShetabNumber.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ValidIranShetabNumberAttribute : ValidationAttribute
    {
        /// <summary>
        /// Determines whether the specified value of the object is valid.
        /// </summary>
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true; // returning false, makes this field required.
            }
            return value.ToString().IsValidIranShetabNumber();
        }
    }
}