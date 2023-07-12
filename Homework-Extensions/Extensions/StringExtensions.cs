namespace Homework_Extensions.Extensions;
using System.Security.Cryptography;
using System.Text;

public static class StringExtensions
{
    public static bool IsNumber(string number)
    {
        int a = 0;
        if (int.TryParse(number, out a))
        {
            return true;
        }

        return false;
    }

    public static bool IsDate(string date)
    {
        DateTime checkDate;
        bool check = DateTime.TryParse(date, out checkDate);
        return check;
    }

    public static string[] ToWords(string text)
    {
        string[] words = text.Split(' ');

        return words;
    }
    public static string CalculateHash(string input)
    {
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashBytes = sha256.ComputeHash(inputBytes);
            string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            return hashString;
        }
    }

    public static void SaveToFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
    }
    
    public static string Encrypt(string plaintext, string key, string iv)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        byte[] ivBytes = Encoding.UTF8.GetBytes(iv);
        byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);

        using (Aes aes = Aes.Create())
        {
            aes.Key = keyBytes;
            aes.IV = ivBytes;

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            byte[] encryptedBytes = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);

            string encryptedString = Convert.ToBase64String(encryptedBytes);
            return encryptedString;
        }
    }
    
    public static string Decrypt(string encryptedText, string key, string iv)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        byte[] ivBytes = Encoding.UTF8.GetBytes(iv);
        byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

        using (Aes aes = Aes.Create())
        {
            aes.Key = keyBytes;
            aes.IV = ivBytes;

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

            string decryptedString = Encoding.UTF8.GetString(decryptedBytes);
            return decryptedString;
        }
    }
    
}

