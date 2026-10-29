using System;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== 1. Car ShowInfo ==="); Task1();
        Console.WriteLine("\n=== 2. Student CalculateGrade ==="); Task2();
        Console.WriteLine("\n=== 3. Discount ==="); Task3();
        Console.WriteLine("\n=== 4. Delivery ==="); Task4();
        Console.WriteLine("\n=== 5. Book DisplayBook ==="); Task5();
        Console.WriteLine("\n=== 6. AddScore ==="); Task6();
        Console.WriteLine("\n=== 7. SaveFile ==="); Task7();
        Console.WriteLine("\n=== 8. Geometry CalculateVolume ==="); Task8();
        Console.WriteLine("\n=== 9. Taxi CalculateFare ==="); Task9();
        Console.WriteLine("\n=== 10. Library SearchBook ==="); Task10();
        Console.WriteLine("\n=== 11. Sort ==="); Task11();
        Console.WriteLine("\n=== 12. Analyze ==="); Task12();
        Console.WriteLine("\n=== 13. ValidatePassword ==="); Task13();
        Console.WriteLine("\n=== 14. ConvertCurrency ==="); Task14();
        Console.WriteLine("\n=== 15. FormatDate ==="); Task15();
        Console.WriteLine("\n=== 16. SendNotification ==="); Task16();
        Console.WriteLine("\n=== 17. CreateEmployee ==="); Task17();
        Console.WriteLine("\n=== 18. UpdateStock ==="); Task18();
        Console.WriteLine("\n=== 19. Calculate ==="); Task19();
        Console.WriteLine("\n=== 20. Login ==="); Task20();
        Console.WriteLine("\n=== 21. ResizeImage ==="); Task21();
        Console.WriteLine("\n=== 22. CalculateFuelCost ==="); Task22();
        Console.WriteLine("\n=== 23. CalculateFinalPrice ==="); Task23();
        Console.WriteLine("\n=== 24. EvaluateStudent ==="); Task24();
        Console.WriteLine("\n=== 25. Helper ==="); Task25();

        Console.WriteLine("\nAll tasks completed.");
    }

    // ---------- 1 ----------
    class Car
    {
        public string Brand;
        public int Year;
        public double Price;
        public Car(string b, int y = 0, double p = 0) { Brand = b; Year = y; Price = p; }
        public void ShowInfo() => Console.WriteLine(Brand);
        public void ShowInfo(bool withYear) =>
            Console.WriteLine(withYear ? $"{Brand} ({Year})" : Brand);
        public void ShowInfo(bool withYear, bool withPrice) =>
            Console.WriteLine(withYear && withPrice ? $"{Brand} ({Year}) - ${Price}" : Brand);
    }
    static void Task1()
    {
        var c = new Car("Toyota", 2020, 25000);
        c.ShowInfo();
        c.ShowInfo(true);
        c.ShowInfo(true, true);
    }

    // ---------- 2 ----------
    class Student
    {
        public double CalculateGrade(double a) => a;
        public double CalculateGrade(double a, double b) => (a + b) / 2;
        public double CalculateGrade(double a, double b, double c) => (a + b + c) / 3;
    }
    static void Task2()
    {
        var s = new Student();
        Console.WriteLine(s.CalculateGrade(80));
        Console.WriteLine(s.CalculateGrade(80, 90));
        Console.WriteLine(s.CalculateGrade(80, 90, 100));
    }

    // ---------- 3 ----------
    class Discount
    {
        public double CalculateDiscount(double price, double percent) =>
            price * percent / 100;
        public double CalculateDiscount(double price, double fixedAmount, bool isFixed) =>
            isFixed ? Math.Min(price, fixedAmount) : price * fixedAmount / 100;
    }
    static void Task3()
    {
        var d = new Discount();
        Console.WriteLine("Percent: " + d.CalculateDiscount(1000, 10));
        Console.WriteLine("Fixed: " + d.CalculateDiscount(1000, 150, true));
    }

    // ---------- 4 ----------
    class Delivery
    {
        public double CalculateDelivery(double dist) => dist * 50;
        public double CalculateDelivery(double dist, bool urgent) =>
            urgent ? dist * 100 : dist * 50;
        public double CalculateDelivery(double dist, double weight, bool withWeight) =>
            withWeight ? dist * 50 + weight * 20 : dist * 50;
    }
    static void Task4()
    {
        var d = new Delivery();
        Console.WriteLine("Regular: " + d.CalculateDelivery(10));
        Console.WriteLine("Urgent: " + d.CalculateDelivery(10, true));
        Console.WriteLine("Weight: " + d.CalculateDelivery(10, 5, true));
    }

    // ---------- 5 ----------
    class Book
    {
        public string Title, Author;
        public int Year;
        public Book(string t, string a = "", int y = 0) { Title = t; Author = a; Year = y; }
        public void DisplayBook() => Console.WriteLine(Title);
        public void DisplayBook(bool withAuthor) =>
            Console.WriteLine(withAuthor ? $"{Title} by {Author}" : Title);
        public void DisplayBook(bool withAuthor, bool withYear) =>
            Console.WriteLine(withAuthor && withYear ? $"{Title} by {Author} ({Year})" : Title);
    }
    static void Task5()
    {
        var b = new Book("C# in Depth", "Jon Skeet", 2019);
        b.DisplayBook();
        b.DisplayBook(true);
        b.DisplayBook(true, true);
    }

    // ---------- 6 ----------
    class Game
    {
        public int Score = 0;
        public void AddScore(int points) => Score += points;
        public void AddScore(int points, int bonus) => Score += points + bonus;
        public void AddScore(int points, double multiplier) => Score += (int)(points * multiplier);
    }
    static void Task6()
    {
        var g = new Game();
        g.AddScore(10); Console.WriteLine(g.Score);
        g.AddScore(10, 5); Console.WriteLine(g.Score);
        g.AddScore(10, 2.0); Console.WriteLine(g.Score);
    }

    // ---------- 7 ----------
    class FileSaver
    {
        public void SaveFile(string text, string path) =>
            File.WriteAllText(path, text);
        public void SaveFile(string[] lines, string path) =>
            File.WriteAllLines(path, lines);
        public void SaveFile(string text, string path, Encoding encoding) =>
            File.WriteAllText(path, text, encoding);
    }
    static void Task7()
    {
        var fs = new FileSaver();
        string p1 = "file1.txt", p2 = "file2.txt", p3 = "file3.txt";
        fs.SaveFile("Hello", p1);
        fs.SaveFile(new[] { "line1", "line2" }, p2);
        fs.SaveFile("Hello UTF8", p3, Encoding.UTF8);
        Console.WriteLine("Files saved: " + p1 + ", " + p2 + ", " + p3);
        File.Delete(p1); File.Delete(p2); File.Delete(p3);
    }

    // ---------- 8 ----------
    class Geometry
    {
        public double CalculateVolume(double side) => side * side * side;
        public double CalculateVolume(double w, double h, double d) => w * h * d;
        public double CalculateVolume(double radius, double height, bool isCylinder) =>
            isCylinder ? Math.PI * radius * radius * height : 0;
    }
    static void Task8()
    {
        var g = new Geometry();
        Console.WriteLine("Cube: " + g.CalculateVolume(3));
        Console.WriteLine("Box: " + g.CalculateVolume(2, 3, 4));
        Console.WriteLine("Cylinder: " + g.CalculateVolume(2, 5, true));
    }

    // ---------- 9 ----------
    class Taxi
    {
        public double CalculateFare(double dist) => dist * 100;
        public double CalculateFare(double dist, double waitMin) => dist * 100 + waitMin * 20;
        public double CalculateFare(double dist, string carClass) =>
            dist * (carClass == "Business" ? 200 : carClass == "Comfort" ? 150 : 100);
    }
    static void Task9()
    {
        var t = new Taxi();
        Console.WriteLine("Basic: " + t.CalculateFare(10));
        Console.WriteLine("With wait: " + t.CalculateFare(10, 5));
        Console.WriteLine("Business: " + t.CalculateFare(10, "Business"));
    }

    // ---------- 10 ----------
    class Library
    {
        private string[] titles = { "C#", "Java", "Python" };
        private string[] authors = { "Skeet", "Bloch", "Lutz" };
        public string SearchBook(string title) =>
            Array.IndexOf(titles, title) >= 0 ? "Found: " + title : "Not found";
        public string SearchBook(string title, string author)
        {
            int i = Array.IndexOf(titles, title);
            return i >= 0 && authors[i] == author ? "Found: " + title : "Not found";
        }
        public string SearchBook(bool byAuthor, string author)
        {
            int i = Array.IndexOf(authors, author);
            return i >= 0 ? "Found: " + titles[i] : "Not found";
        }
    }
    static void Task10()
    {
        var l = new Library();
        Console.WriteLine(l.SearchBook("C#"));
        Console.WriteLine(l.SearchBook("C#", "Skeet"));
        Console.WriteLine(l.SearchBook(true, "Bloch"));
    }

    // ---------- 11 ----------
    class Sorter
    {
        public int[] Sort(int[] arr) { var c = (int[])arr.Clone(); Array.Sort(c); return c; }
        public double[] Sort(double[] arr) { var c = (double[])arr.Clone(); Array.Sort(c); return c; }
        public string[] Sort(string[] arr) { var c = (string[])arr.Clone(); Array.Sort(c); return c; }
    }
    static void Task11()
    {
        var s = new Sorter();
        Console.WriteLine(string.Join(",", s.Sort(new[] { 3, 1, 2 })));
        Console.WriteLine(string.Join(",", s.Sort(new[] { 3.5, 1.2, 2.8 })));
        Console.WriteLine(string.Join(",", s.Sort(new[] { "c", "a", "b" })));
    }

    // ---------- 12 ----------
    class Stats
    {
        public (double min, double max, double avg) Analyze(int[] arr) =>
            (arr.Min(), arr.Max(), arr.Average());
        public (double min, double max, double avg) Analyze(double[] arr) =>
            (arr.Min(), arr.Max(), arr.Average());
    }
    static void Task12()
    {
        var s = new Stats();
        Console.WriteLine(s.Analyze(new[] { 1, 2, 3, 4, 5 }));
        Console.WriteLine(s.Analyze(new[] { 1.5, 2.5, 3.5 }));
    }

    // ---------- 13 ----------
    class PasswordValidator
    {
        public bool ValidatePassword(string p, int minLength) => p.Length >= minLength;
        public bool ValidatePassword(string p, int minLength, bool requireDigits) =>
            p.Length >= minLength && p.Any(char.IsDigit);
        public bool ValidatePassword(string p, int minLength, bool requireDigits, bool requireSpecial) =>
            p.Length >= minLength &&
            (!requireDigits || p.Any(char.IsDigit)) &&
            (!requireSpecial || p.Any(c => !char.IsLetterOrDigit(c)));
    }
    static void Task13()
    {
        var v = new PasswordValidator();
        Console.WriteLine(v.ValidatePassword("secret123", 8));
        Console.WriteLine(v.ValidatePassword("secret123", 8, true));
        Console.WriteLine(v.ValidatePassword("secret123!", 8, true, true));
    }

    // ---------- 14 ----------
    class CurrencyConverter
    {
        public double ConvertCurrency(double usd, double rate) => usd * rate;
        public double ConvertCurrency(double usd, double rate, double commission) =>
            usd * rate * (1 - commission);
    }
    static void Task14()
    {
        var c = new CurrencyConverter();
        Console.WriteLine("Fixed: " + c.ConvertCurrency(100, 500));
        Console.WriteLine("With commission: " + c.ConvertCurrency(100, 500, 0.02));
    }

    // ---------- 15 ----------
    class DateFormatter
    {
        public string FormatDate(DateTime date) => date.ToString("dd.MM.yyyy");
        public string FormatDate(string dateStr) => dateStr;
        public string FormatDate(DateTime date, bool withTime) =>
            date.ToString(withTime ? "dd.MM.yyyy HH:mm" : "dd.MM.yyyy");
    }
    static void Task15()
    {
        var f = new DateFormatter();
        var d = new DateTime(2024, 6, 1, 15, 30, 0);
        Console.WriteLine(f.FormatDate(d));
        Console.WriteLine(f.FormatDate("01.06.2024"));
        Console.WriteLine(f.FormatDate(d, true));
    }

    // ---------- 16 ----------
    class Notifier
    {
        public void SendNotification(string msg) => Console.WriteLine(msg);
        public void SendNotification(string title, string msg) =>
            Console.WriteLine($"[{title}] {msg}");
        public void SendNotification(string title, string msg, string recipient) =>
            Console.WriteLine($"[{title}] to {recipient}: {msg}");
    }
    static void Task16()
    {
        var n = new Notifier();
        n.SendNotification("Hello");
        n.SendNotification("Info", "Hello");
        n.SendNotification("Alert", "Hello", "admin@mail.com");
    }

    // ---------- 17 ----------
    class Employee
    {
        public string Name, Position;
        public double Salary;
        public Employee(string n, string p = "", double s = 0) { Name = n; Position = p; Salary = s; }
        public override string ToString() => $"{Name}, {Position}, {Salary}";
    }
    class EmployeeFactory
    {
        public Employee CreateEmployee(string name) => new Employee(name);
        public Employee CreateEmployee(string name, string position) => new Employee(name, position);
        public Employee CreateEmployee(string name, string position, double salary) =>
            new Employee(name, position, salary);
    }
    static void Task17()
    {
        var f = new EmployeeFactory();
        Console.WriteLine(f.CreateEmployee("Alice"));
        Console.WriteLine(f.CreateEmployee("Bob", "Dev"));
        Console.WriteLine(f.CreateEmployee("Carol", "Manager", 5000));
    }

    // ---------- 18 ----------
    class Stock
    {
        public int Quantity = 0;
        public void UpdateStock(int add) => Quantity += add;
        public void UpdateStock(int sub, bool isDecrease) =>
            Quantity = isDecrease ? Math.Max(0, Quantity - sub) : Quantity + sub;
        public void UpdateStock(int newQty, string set) =>
            Quantity = set == "set" ? newQty : Quantity;
    }
    static void Task18()
    {
        var s = new Stock();
        s.UpdateStock(10); Console.WriteLine(s.Quantity);
        s.UpdateStock(3, true); Console.WriteLine(s.Quantity);
        s.UpdateStock(50, "set"); Console.WriteLine(s.Quantity);
    }

    // ---------- 19 ----------
    class MathLib
    {
        public int Calculate(int a, int b, string op) =>
            op == "+" ? a + b : op == "-" ? a - b : op == "*" ? a * b : a / b;
        public double Calculate(double a, double b, string op) =>
            op == "+" ? a + b : op == "-" ? a - b : op == "*" ? a * b : a / b;
    }
    static void Task19()
    {
        var m = new MathLib();
        Console.WriteLine(m.Calculate(10, 2, "+"));
        Console.WriteLine(m.Calculate(10.5, 2.5, "/"));
    }

    // ---------- 20 ----------
    class Auth
    {
        public bool Login(string login, string password) =>
            login == "admin" && password == "123";
        public bool Login(string email, string password, bool isEmail) =>
            isEmail && email == "admin@mail.com" && password == "123";
        public bool Login(string login, string password, string code) =>
            login == "admin" && password == "123" && code == "0000";
    }
    static void Task20()
    {
        var a = new Auth();
        Console.WriteLine(a.Login("admin", "123"));
        Console.WriteLine(a.Login("admin@mail.com", "123", true));
        Console.WriteLine(a.Login("admin", "123", "0000"));
    }

    // ---------- 21 ----------
    class ImageResizer
    {
        public string ResizeImage(int w, int h) => $"Resized to {w}x{h}";
        public string ResizeImage(double scale) => $"Scaled by {scale}";
        public string ResizeImage(int w, int h, int maxW, int maxH)
        {
            double scale = Math.Min((double)maxW / w, (double)maxH / h);
            return $"Resized with proportions to {w * scale:F0}x{h * scale:F0}";
        }
    }
    static void Task21()
    {
        var r = new ImageResizer();
        Console.WriteLine(r.ResizeImage(800, 600));
        Console.WriteLine(r.ResizeImage(0.5));
        Console.WriteLine(r.ResizeImage(1920, 1080, 800, 600));
    }

    // ---------- 22 ----------
    class FuelCost
    {
        public double CalculateFuelCost(double dist, double consumption) =>
            dist / 100 * consumption;
        public double CalculateFuelCost(double dist, double consumption, double price) =>
            dist / 100 * consumption * price;
    }
    static void Task22()
    {
        var f = new FuelCost();
        Console.WriteLine("Litres: " + f.CalculateFuelCost(500, 7.5));
        Console.WriteLine("Cost: " + f.CalculateFuelCost(500, 7.5, 230));
    }

    // ---------- 23 ----------
    class Electronics
    {
        public double CalculateFinalPrice(double price, double discount) =>
            price * (1 - discount);
        public double CalculateFinalPrice(double price, double discount, double tax) =>
            price * (1 - discount) * (1 + tax);
        public double CalculateFinalPrice(double price, double discount, double tax, double delivery) =>
            price * (1 - discount) * (1 + tax) + delivery;
    }
    static void Task23()
    {
        var e = new Electronics();
        Console.WriteLine(e.CalculateFinalPrice(1000, 0.1));
        Console.WriteLine(e.CalculateFinalPrice(1000, 0.1, 0.12));
        Console.WriteLine(e.CalculateFinalPrice(1000, 0.1, 0.12, 50));
    }

    // ---------- 24 ----------
    class Evaluator
    {
        public double EvaluateStudent(double exam) => exam;
        public double EvaluateStudent(double exam, double test) => (exam + test) / 2;
        public double EvaluateStudent(double[] exams) => exams.Average();
    }
    static void Task24()
    {
        var e = new Evaluator();
        Console.WriteLine(e.EvaluateStudent(80));
        Console.WriteLine(e.EvaluateStudent(80, 90));
        Console.WriteLine(e.EvaluateStudent(new[] { 80.0, 90.0, 100.0 }));
    }

    // ---------- 25 ----------
    class Helper
    {
        // Calculate
        public int Calculate(int a, int b) => a + b;
        public double Calculate(double a, double b) => a + b;
        public double Calculate(double a, double b, string op) =>
            op == "+" ? a + b : op == "-" ? a - b : op == "*" ? a * b : a / b;

        // Format
        public string Format(int n) => n.ToString("N0");
        public string Format(string s) => s.ToUpper();
        public string Format(DateTime d) => d.ToString("dd.MM.yyyy");

        // Find
        public int Find(int[] arr, int target) => Array.IndexOf(arr, target);
        public int Find(string text, string sub) => text.IndexOf(sub);

        // Display
        public void Display(int n) => Console.WriteLine("Int: " + n);
        public void Display(string s) => Console.WriteLine("String: " + s);
        public void Display(double d) => Console.WriteLine("Double: " + d);
        public void Display(DateTime d) => Console.WriteLine("Date: " + d.ToString("dd.MM.yyyy"));
    }
    static void Task25()
    {
        var h = new Helper();
        Console.WriteLine(h.Calculate(2, 3));
        Console.WriteLine(h.Calculate(2.5, 3.5));
        Console.WriteLine(h.Calculate(10, 4, "*"));
        Console.WriteLine(h.Format(1234567));
        Console.WriteLine(h.Format("hello"));
        Console.WriteLine(h.Format(DateTime.Now));
        Console.WriteLine(h.Find(new[] { 1, 2, 3 }, 2));
        Console.WriteLine(h.Find("hello world", "world"));
        h.Display(42);
        h.Display("hi");
        h.Display(3.14);
        h.Display(DateTime.Now);
    }
}