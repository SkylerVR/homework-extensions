using Homework_Extensions.Extensions;

class Program
{
    public static void Main(string[] args)
    {
        string stringedNumber = "2222";
        bool isNumber = StringExtensions.IsNumber(stringedNumber);
        Console.WriteLine(isNumber);
        
        string stringedDate = "2022-05-30 14:30:00";
        bool isDate = StringExtensions.IsDate(stringedDate);
        Console.WriteLine(isDate);

        string toWords = "Hello World";
        Console.WriteLine(StringExtensions.ToWords(toWords)[0]);
        
        string input = "Encrypt My Message";
        string hash = StringExtensions.CalculateHash(input);
        Console.WriteLine(hash);
        
        string filePath = "/i.txt";
        string content = "Hello, world!";

        StringExtensions.SaveToFile(filePath, content);
        
        string plaintext = "Gamarjoba !";
        string key = "0123456789ABCDEF";
        string iv = "FEDCBA9876543210";

        string encryptedText = StringExtensions.Encrypt(plaintext, key, iv);
        Console.WriteLine(encryptedText);

        string decrypted = StringExtensions.Decrypt(encryptedText, key, iv);
        Console.WriteLine(decrypted);

        
        // Double Extensions
        double getPercent = DoubleExtensions.ToPercent(1.5);
        Console.WriteLine(getPercent);
        
        Console.WriteLine(DoubleExtensions.RoundDown(36.7));
        decimal convertToDecimal = DoubleExtensions.ToDecimal(223.23);
        Console.WriteLine(convertToDecimal);
        bool isGreater = DoubleExtensions.IsGreater(22, 2);
        Console.WriteLine(isGreater);
        bool isLess = DoubleExtensions.IsLess(42, 12);
        Console.WriteLine(isLess);
        
        // DateTime Extensions
        DateTime firstDate = DateTime.Now;
        DateTime secondDate = DateTime.Now.AddDays(30);
        DateTime minDate = DateExtensions.Min(firstDate, secondDate);
        Console.WriteLine(minDate);

        DateTime firstDateMax = DateTime.Now;
        DateTime secondDateMax = DateTime.Now.AddDays(30);
        DateTime maxDate = DateExtensions.Max(firstDateMax, secondDateMax);
        Console.WriteLine(maxDate);
        
        var date = new DateTime(2022, 11, 23);
        DateTime beginingOfMonth = DateExtensions.BeginingOfMonth(date);
        Console.WriteLine(beginingOfMonth);
        
        var lastDate = new DateTime(2022, 11, 23);
        DateTime lastDateMonth = DateExtensions.EndOfMonth(lastDate);
        Console.WriteLine(lastDateMonth);
    }    
}