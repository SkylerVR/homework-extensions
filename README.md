# Do Jobs
# დაწერეთ შემდეგი Extension ფუნქციები:

# String:
# IsNumber() - ფუნქციამ უნდა დააბრუნოს true, თუ string არის რიცხვი
# IsDate() - ფუნქციამ უნდა დააბრუნოს true, თუ string არის თარიღი
# ToWords() - ფუნქციამ უნდა დააბრუნოს string[] მასივი, რომლის თითოეულ ელემენტში იქნება ერთი სიტყვა (მაგ. “extension methods”.ToWords() უნდა დააბრუნოს [”extension”, “methods”]
# CalculateHash() - უნდა დააბრუნოს ტექსტის Sha256 ჰეში
# SaveToFile(string filePath) - მითითებულ მისამართზე უნდა შექმნას ფაილი და შეინახოს ტექსტი
# Encrypt(string key, string iv) - უნდა დააბრუნოს დაშიფრული ტექსტი
# Decrypt(string key, string iv) - უნდა დააბრუნოს გაშიფრული ტექსტი

# double:

# ToPercent() - უნდა დააბრუნოს რიცხვის პროცენტული მნიშვნელობა (მაგ. 0.5.ToPercent() უნდა დააბრუნოს 50)
# RoundDown() - რიცხვი უნდა დაამრგვალოს უახლოს მცირე მთელ რიცხვამდე (მაგ. 36.7.RoundDown() უნდა დააბრუნოს 36)
# ToDecimal() - რიცხვი უნდა დააბრუნოს decimal ტიპად
# IsGreater(double number) - უნდა დააბრუნოს true, თუ რიცხვი მეტია number-ზე
# IsLess(double number) - უნდა დააბრუნოს true, თუ რიცხვი ნაკლებია number-ზე

# DateTime:

# Min(DateTime date) - უნდა დააბრუნოს ორ თარიღს შორის რომელიც მცირეა
# Max(DateTime date) - უნდა დააბრუნოს ორ თარიღს შორის რომელიც მეტია
# BeginingOfMonth() - უნდა დააბრუნოს თარიღის თვის დასაწყისი. მაგ. var date = new DateTime(2022, 11, 23); date.BeginingOfMonth() → უნდა დააბრუნოს DateTime(2022, 11, 01)
# EndOfMonth() - უნდა დააბრუნოს თარიღის თვის ბოლო. მაგ. var date = new DateTime(2022, 11, 23); date.BeginingOfMonth() → უნდა დააბრუნოს DateTime(2022, 11, 30)
