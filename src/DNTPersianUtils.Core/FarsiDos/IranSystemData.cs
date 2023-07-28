using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     اطلاعات رشته ايران سيستمي
/// </summary>
public class IranSystemData
{
   /// <summary>
   ///     اطلاعات رشته ايران سيستمي
   /// </summary>
   public IranSystemData()
    {
    }

   /// <summary>
   ///     اطلاعات رشته ايران سيستمي
   /// </summary>
   public IranSystemData(string text, byte[] bytes)
    {
        Text = text;
        Bytes = bytes;
    }

   /// <summary>
   ///     رشته ايران سيستمي
   /// </summary>
   public string Text { set; get; } = string.Empty;

   /// <summary>
   ///     بايت‌هاي اصلي رشته ايران سيستمي
   /// </summary>
   public byte[] Bytes { set; get; } = Array.Empty<byte>();
}