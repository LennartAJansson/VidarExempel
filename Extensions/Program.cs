// See https://aka.ms/new-console-template for more information
string text = "Hello, World!";

string encoded = text.Base64Encode();
Console.WriteLine(encoded);

var decoded = encoded.Base64Decode();
Console.WriteLine(decoded);


public static class StringExtensions
{
  public static string Base64Encode(this string plainText)
  {
    byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
    return System.Convert.ToBase64String(plainTextBytes);
  }
  public static string Base64Decode(this string base64EncodedData)
  {
    var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
    return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
  }
}
