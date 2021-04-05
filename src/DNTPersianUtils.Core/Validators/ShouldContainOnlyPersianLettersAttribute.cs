using System;
using System.ComponentModel.DataAnnotations;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// Determines whether the specified value of the object is a valid Persian letter.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Parameter)]
    public sealed class ShouldContainOnlyPersianLettersAttribute : ValidationAttribute
    {
        /// <summary>
        /// Determines whether the specified value of the object is valid.
        /// </summary>
        public override bool IsValid(object? value)
        {
            if (value is null)
            {
                return true; // returning false, makes this field required.
            }

            var valStr = value.ToString();
            if (string.IsNullOrWhiteSpace(valStr))
            {
                return true; // returning false, makes this field required.
            }

            return valStr.ContainsOnlyFarsiLetters();
        }
    }
}