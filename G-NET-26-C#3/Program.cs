using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Text;

namespace G_NET_26_C_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1:

            //(a)immutable, meaning its contents cannot be changed after creation.
            //old string object remains in memory until the Garbage Collector(GC) removes it.
            //(b)
            // StringBuilder sb = new StringBuilder(); 
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append("PROD-").Append(i).Append(","); 
            //}
            //string productList = sb.ToString(); 
            ////(c)
            #endregion

            #region Question 2:
            //        Console.Write("Enter your age: ");
            //        int age = int.Parse(Console.ReadLine());

            //        Console.Write("Enter day of week (1-7, where 7=Fri): ");
            //        int day = int.Parse(Console.ReadLine());

            //        Console.Write("Do you have a valid student ID? (yes/no): ");
            //        string studentIdInput = Console.ReadLine().ToLower();
            //        bool isStudent = (studentIdInput == "yes");

            //        double price = 0;
            //        string breakdown = "";

            //        if (age < 5)
            //        {
            //            price = 0;
            //            breakdown = "Age < 5: Free";
            //        }
            //        else if (age >= 5 && age <= 12)
            //        {
            //            price = 30;
            //            breakdown = "Age 5-12: 30 LE";
            //        }
            //        else if (age >= 13 && age <= 59)
            //        {
            //            price = 50;
            //            breakdown = "Age 13-59: 50 LE";
            //        }
            //        else // age 60+
            //        {
            //            price = 25;
            //            breakdown = "Age 60+: 25 LE";
            //        }
            //        if (price > 0 && (day == 6 || day == 7))
            //        {
            //            price += 10;
            //            breakdown += "\nWeekend Surcharge: +10 EGP";
            //        }

            //        if (price > 0 && isStudent)
            //        {
            //            double discount = price * 0.20;
            //            price -= discount;
            //            breakdown += $"\nStudent Discount (20%): -{discount} LE";
            //        }

            //        Console.WriteLine("\n--- Price Breakdown ---");
            //        Console.WriteLine(breakdown);
            //        Console.WriteLine("-----------------------");
            //        Console.WriteLine($"Final Ticket Price: {price} LE");
            //    }
            //}


            #endregion

            #region Question 3:
            //(a)
            //string fileExtension = ".pdf";
            //string fileType;
            //switch (fileExtension)
            //{
            //    case ".pdf":
            //        fileType = "PDF Document";
            //        break;
            //    case ".docx":
            //    case ".doc":
            //        fileType = "Word Document";
            //        break;
            //    case ".xlsx":
            //    case ".xls":
            //        fileType = "Excel Spreadsheet";
            //        break;
            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Image File";
            //        break;
            //    default:
            //        fileType = "Unknown File Type";
            //        break;
            //}
            ////(b)
            //string fileExtension = ".pdf";

            //string fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".docx" or ".doc" => "Word Document",
            //    ".xlsx" or ".xls" => "Excel Spreadsheet",
            //    ".jpg" or ".png" or ".gif" => "Image File",
            //    _ => "Unknown File Type"
            //};

            #endregion

            #region Question 4:
            //int temperature = 35;

            //string weatherAdvice =
            //    (temperature < 0) ? "Freezing! Stay indoors." :
            //    (temperature < 15) ? "Cold. Wear a jacket." :
            //    (temperature < 25) ? "Pleasant weather." :
            //    (temperature < 35) ? "Warm. Stay hydrated." : "Hot! Avoid sun exposure.";

            //Console.WriteLine(weatherAdvice);
            //** No,We Choose Ternary Operator when we have simple (single) condition to assign  value to a variable.
            #endregion

            #region Question 5:
            //string password;
            //int attempts = 5;
            //bool isValid;

            //do
            //{
            //    attempts--;
            //    Console.Write($"Attempt {attempts}/5 - Enter password: ");
            //    password = Console.ReadLine();

            //    bool hasUpper = false;
            //    bool hasDigit = false;
            //    bool hasSpace = false;
            //    foreach (char c in password)
            //    {
            //        if (char.IsUpper(c)) hasUpper = true;
            //        if (char.IsDigit(c)) hasDigit = true;
            //        if (char.IsWhiteSpace(c)) hasSpace = true;
            //    }
            //    bool lengthValid = password.Length >= 8;
            //    isValid = lengthValid && hasUpper && hasDigit && !hasSpace;

            //    if (!isValid)
            //    {
            //        Console.WriteLine("Invalid password. Rules:");
            //        if (!lengthValid) Console.WriteLine("- Minimum 8 characters");
            //        if (!hasUpper) Console.WriteLine("- At least one uppercase letter");
            //        if (!hasDigit) Console.WriteLine("- At least one digit");
            //        if (hasSpace) Console.WriteLine("- No spaces allowed");
            //        Console.WriteLine();
            //    }
            //    if (attempts >= 5 && !isValid)
            //    {
            //        Console.WriteLine("Account locked.");
            //        return;
            //    }
            //}
            //while (!isValid);
            //{
            //    Console.WriteLine("Password accepted!");
            //}

            #endregion

            #region Question 6:
            //int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88 ,72 ,95 ,60 ,48};

            //// (a) Find and display all failing scores (below 50)
            //Console.WriteLine(" Failing Scores below 50: ");
            //foreach (int score in scores)
            //{
            //    if (score < 50)
            //    {
            //        Console.WriteLine(score);
            //    }
            //}

            //// (b) Find the first score above 90 and stop (break)
            //Console.WriteLine("\n First Score Above 90 :");
            //foreach (int score in scores)
            //{
            //    if (score > 90)
            //    {
            //        Console.WriteLine($" {score}");
            //        break; 
            //    }
            //}

            //// (c) Average excluding scores below 40 (considered absent)
            //Console.WriteLine("\n Class Average :");
            //double sum = 0;
            //int count = 0;
            //foreach (int score in scores)
            //{
            //    if (score < 40) continue; 

            //    sum += score;
            //    count++;
            //}
            //double average = (count > 0) ? sum / count : 0;
            //Console.WriteLine($"Average: {average}");

            //// (d) Count how many students scored in each grade range:
            //Console.WriteLine("\n Grades: ");
            //int A = 0, B = 0, C = 0, D = 0, F = 0;
            //foreach (int score in scores)
            //{
            //    if (score >= 90) A++;
            //    else if (score >= 80) B++;
            //    else if (score >= 70) C++;
            //    else if (score >= 60) D++;
            //    else F++;
            //}
            //Console.WriteLine($"A: {A}, B: {B}, C: {C}, D: {D}, F: {F}");
        
            #endregion





    }
    }
}
