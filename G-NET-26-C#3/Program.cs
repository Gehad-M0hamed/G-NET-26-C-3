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





        }
    }
}
