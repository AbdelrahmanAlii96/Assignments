namespace Assignemt_03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1
            //string productlist = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productlist += "PROD-" + i + ",";
            //}

            //a)-this code ineffiect because string is immutable
            //    new string ctreated in memory and old string copied to new string
            //    and old string becomes garbage and GC clear it


            //b)
            //StringBuilder sb = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append("PROD-");
            //    sb.Append(i);
            //    sb.Append(',');
            //}
            //string productlist = sb.ToString();

            //c)-
            //Stopwatch sw1 = Stopwatch.StartNew();
            //string productlist1 = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productlist1 += "PROD-" + i + ",";
            //}
            //sw1.Stop();
            //Console.WriteLine($"StopWatch1, {sw1.ElapsedMilliseconds} ms");

            //Stopwatch sw2 = Stopwatch.StartNew();

            //StringBuilder sb2 = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb2.Append("PROD-");
            //    sb2.Append(i);
            //    sb2.Append(',');
            //}
            //string productlist2 = sb2.ToString();
            //sw2.Stop();
            //Console.WriteLine($"StopWatch2, {sw2.ElapsedMilliseconds} ms");



            #endregion

            #region Q2
            //int age;
            //int DayOfWeek;
            //string input;

            //double baseprice = 0;
            //double finalprice = 0;
            //double weekendcharge = 0;
            //double discount = 0;


            //Console.WriteLine("Enter Your Age : ");
            //if (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            //{
            //    Console.WriteLine("Invalid Age");
            //    return;
            //}


            //Console.WriteLine("Enter Day of The Week : ");
            //if (!int.TryParse(Console.ReadLine(), out DayOfWeek) || DayOfWeek < 1 || DayOfWeek > 7)
            //{
            //    Console.WriteLine("Invalid Day of the week");
            //}

            //Console.WriteLine("Do you have Student ID (yes/no)");
            //input = Console.ReadLine().ToLower();
            //bool ValidID = (input == "yes");


            //if (age < 5)
            //{
            //    baseprice = 0;
            //}
            //else if (age >= 5 && age <= 12)
            //{
            //    baseprice = 30;
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    baseprice = 50;
            //}
            //else if (age > 60)
            //{
            //    baseprice = 25;
            //}

            //finalprice = baseprice;

            //// add 10 to non-free ticket
            //if ((DayOfWeek == 6 || DayOfWeek == 7) && baseprice > 0)
            //{
            //    weekendcharge = 10;
            //    finalprice = finalprice + 10;
            //}

            ////
            //if (ValidID && baseprice > 0)
            //{
            //    discount = finalprice * 0.20;
            //    finalprice = finalprice - discount;
            //}


            //Console.WriteLine("BreakDown");
            //Console.WriteLine("Age : "+ age);
            //Console.WriteLine("BasePrice : "+ baseprice+" LE");
            //if (DayOfWeek == 6 || DayOfWeek == 7)
            //{
            //    Console.WriteLine("weekendcharge :" + weekendcharge + " LE");
            //}
            //if(ValidID)
            //{
            //    Console.WriteLine("Valid ID and discount :" + discount + " LE");
            //}
            //Console.WriteLine("Final Price : "+finalprice+" LE");

            #endregion

            #region Q3
            //A -
            //String fileExtension = ".pdf";
            //string fileType;
            //switch (fileExtension)
            //{
            //    case ".pdf":
            //        fileType = "PDF Document";
            //        break;
            //    case ".doc":
            //        fileType = "Word Document";
            //        break;
            //    case ".docx":
            //        fileType = "Word Document";
            //        break;
            //    case ".xls":
            //        fileType = "Excel Spreadsheet";
            //        break;
            //    case ".xlsx":
            //        fileType = "Excel Spreadsheet";
            //        break;
            //    case ".jpg":
            //        fileType = "ImageFile";
            //        break;
            //    case ".png":
            //        fileType = "ImageFile";
            //        break;
            //    case ".gif":
            //        fileType = "ImageFile";
            //        break;
            //    default:
            //        fileType = "Unknown File Type";
            //        break;

            //}
            //Console.WriteLine(fileType);

            //B -

            //String fileExtension = ".pdf";
            //string fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".doc" or ".docx" => "Word Document",
            //    ".xls" or ".xlsx" => "Excel SpreadSheet",
            //    ".jpg" or ".png" or ".gif" => "Image File",
            //    _ => "Unknown File Type"
            //};
            //Console.WriteLine(fileType);


            #endregion


            #region Q4

            //int temperature = 35;
            //string weatherAdvice =
            //    temperature < 0 ? "Freezing! Stay indoors" :
            //    temperature < 15 ? "Cold. Wear a jacket." :
            //    temperature < 25 ? "pleasant weather." :
            //    temperature < 35 ? "Warm. Stay hydrated." :
            //                        "Hot! Avoid Sun exposure.";
            //Console.WriteLine(weatherAdvice);

            // no  ternary operators less readable specially when we have more conditions
            // we can choose ternary when it's simple and short condition otherwise if-else more readable

            #endregion


            #region Q5


            //string password;
            //int attempts = 0;
            //const int maxattempts = 5;
            //bool validpass = false;

            //do
            //{
            //    Console.WriteLine("Enter Password");
            //    password = Console.ReadLine();
            //    attempts++;

            //    validpass = true;
            //    bool hasupper = false;
            //    bool hasdigit = false;
            //    bool hasspace = false;

            //    if (password.Length < 8)
            //    {
            //        Console.WriteLine("Password should be at least 8 characters");
            //        validpass = false;
            //    }

            //    foreach (char c in password)
            //    {
            //        if (char.IsUpper(c))
            //        {
            //            hasupper = true;
            //        }
            //        if (char.IsDigit(c))
            //        {
            //            hasdigit = true;
            //        }
            //        if (char.IsWhiteSpace(c))
            //        {
            //            hasspace = true;
            //        }
            //    }

            //    if (!hasupper)
            //    {
            //        Console.WriteLine("password must contain at least one upper letter");
            //        validpass = false;
            //    }
            //    if (!hasdigit)
            //    {
            //        Console.WriteLine("password must contain at least one digit");
            //        validpass = false;
            //    }
            //    if (hasspace)
            //    {
            //        Console.WriteLine("password must not contain spaces");
            //        validpass = false;
            //    }


            //} while (!validpass && attempts < maxattempts);

            //if (validpass)
            //{
            //    Console.WriteLine("Password Accepted");
            //}
            //else
            //{
            //    Console.WriteLine("Account Locked");
            //}


            #endregion

            #region Q6

            //int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };
            //A -display below 50
            //Console.WriteLine("Failing Scores below 50 : ");
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] < 50)
            //    {
            //        Console.WriteLine(scores[i]);
            //    }
            //}


            //B -fine first element above 90 and stop
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] > 90)
            //    {
            //        Console.WriteLine(scores[i]);
            //        break;
            //    }
            //}

            //C - class average excluding blew 40
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] < 40)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(scores[i]);
            //}

            //D -Grade  range
            //int A = 0;
            //int B = 0;
            //int C = 0;
            //int D = 0;
            //int F = 0;
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] >= 90 && scores[i] <= 100)
            //    {
            //        A++;
            //    }
            //    else if (scores[i] >= 80 && scores[i] <= 89)
            //    {
            //        B++;
            //    }
            //    else if (scores[i] >= 70 && scores[i] <= 79)
            //    {
            //        C++;
            //    }
            //    else if (scores[i] >= 60 && scores[i] <= 69)
            //    {
            //        D++;
            //    }
            //    else if (scores[i] <= 60)
            //    {
            //        F++;
            //    }
            //}

            //Console.WriteLine("There is " + A + " hit A Grade");
            //Console.WriteLine("There is " + B + " hit B Grade");
            //Console.WriteLine("There is " + C + " hit C Grade");
            //Console.WriteLine("There is " + D + " hit D Grade");
            //Console.WriteLine("There is " + F + " hit F Grade");
            //

            #endregion
        }
    }
}
