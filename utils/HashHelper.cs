// File: Utils/HashHelper.cs
using System.Security.Cryptography;
using System.Text;

namespace MeuProjeto.Utils
{
  public static class HashHelper
  {
    public static string GenerateHash(string input)
    {
      using (var sha256 = SHA256.Create())
      {
        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
        StringBuilder builder = new StringBuilder();
        foreach (byte b in bytes)
        {
          builder.Append(b.ToString("x2"));
        }
        return builder.ToString();
      }
    }
  }
}
