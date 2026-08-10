namespace Assignment_04
{
    internal class Program
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }


        public static double Divide(double a, double b)
        {
            return a / b;
        }


        public static void CalculateCircle(double radius, out double area, out double circumference)
        {
            area = Math.PI * radius * radius;
            circumference = 2 * Math.PI * radius;
        }

        /// //////////////////////////////////////////////////////


        enum DayOfWeek
        {
            Saturday = 0,
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6
        }

        /// //////////////////////////////////////////////////

        enum Grade
        {
            A, B, C, D, F
        }



        static void Main(string[] args)
        {


            #region Part 1 - Q1

            //int daynum;
            //do
            //{

            //    Console.WriteLine("Enter a day number (0-6): ");

            //} while (!int.TryParse(Console.ReadLine(), out daynum) || daynum < 0 || daynum > 6);


            //DayOfWeek day = (DayOfWeek)daynum;
            //Console.WriteLine($"Day: {day}");
            //switch (day)
            //{
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("It's a Weekend");
            //        break;

            //    default:
            //        Console.WriteLine("It's a Workday");
            //        break;
            //}
            #endregion


            #region Part 2 - Q1

            //int sum = 0;
            //int max = 0;
            //int min = 0;

            //Console.WriteLine("Enter Array Size : ");
            //int size = int.Parse(Console.ReadLine());
            //int[] numbers = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Enter Element [" + i + "] : ");
            //    numbers[i] = int.Parse(Console.ReadLine());

            //    sum += numbers[i];
            //    if (i == 0)
            //    {
            //        max = numbers[i];
            //        min = numbers[i];
            //    }
            //    else
            //    {
            //        if (numbers[i] > max)
            //        {
            //            max = numbers[i];
            //        }
            //        if (numbers[i] < min)
            //        {
            //            min = numbers[i];
            //        }
            //    }
            //}
            //double average = (double)sum / size;

            //Console.WriteLine("\nSum     = " + sum);
            //Console.WriteLine("Average = " + average);
            //Console.WriteLine("Max     = " + max);
            //Console.WriteLine("Min     = " + min);

            //Console.Write("Reverse  : ");
            //for (int i = size-1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i]);
            //    if (i > 0)
            //    {
            //        Console.Write(" , ");
            //    }
            //}


            #endregion


            #region Part 2 - Q2

            //const int students = 3;
            //const int subjects = 4;

            //double[,] grades = new double[students, subjects];
            //double classTotal = 0;

            //for (int i = 0; i < students; i++)
            //{
            //    Console.WriteLine($"Enter grades for Student {i + 1}:");

            //    for(int j = 0; j < subjects; j++)
            //    {
            //        Console.Write($"Subject {j + 1}: ");
            //        grades[i, j] = Convert.ToDouble(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Student Averages:");

            //for (int i = 0; i < students; i++)
            //{
            //    double studentTotal = 0;

            //    for (int j = 0; j < subjects; j++)
            //    {
            //        studentTotal += grades[i, j];
            //    }

            //    double studentAverage = studentTotal / subjects;
            //    classTotal += studentTotal;

            //    Console.WriteLine($"Student {i + 1} Average: {studentAverage}");
            //}

            //double classAverage = classTotal / (students * subjects);
            //Console.WriteLine($"Overall Class Average: {classAverage}");

            #endregion


            #region Part 3 - Q1

            //double result = 0;

            //Console.WriteLine("Enter your two numbers");
            //double n1 = Convert.ToDouble(Console.ReadLine());
            //double n2 = Convert.ToDouble(Console.ReadLine());
            //char operation = Convert.ToChar(Console.ReadLine());
            //switch (operation)
            //{
            //    case '+':
            //        result = Add(n1, n2);
            //        break;
            //    case '-':
            //        result = Subtract(n1, n2);
            //        break;
            //    case '*':
            //        result = Multiply(n1, n2);
            //        break;
            //    case '/':
            //        result = Divide(n1, n2);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operation.");
            //        return;
            //}

            //Console.WriteLine("The Result is : "+result);

            #endregion


            #region Part 3 - Q2

            //double area;
            //double circumference;

            //Console.Write("Enter the radius : ");
            //double radius = Convert.ToDouble(Console.ReadLine());

            //CalculateCircle(radius, out area, out circumference);

            //Console.WriteLine("Area = " + area);
            //Console.WriteLine("Circumference = "+circumference);

            #endregion


            #region Part 4 - new project


            //int[] scores = new int[5];

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.Write($"Enter score for Student {i + 1}: ");
            //    scores[i] = int.Parse(Console.ReadLine());
            //}


            //Console.WriteLine("--- Report ---");

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Grade grade = GetGrade(scores[i]);
            //    Console.WriteLine($"Student {i + 1}: {scores[i]} -> Grade: {grade}");
            //}



            //double average = GetAverage(scores);
            //Console.WriteLine("Average: " + average);


            //GetMinMax(scores, out int min, out int max);
            //Console.WriteLine("Lowest Score: "+min);
            //Console.WriteLine("Highest Score: "+max);

            //static Grade GetGrade(int score)
            //{

            //    if (score >= 90)
            //        return Grade.A;
            //    else if (score >= 80)
            //        return Grade.B;
            //    else if (score >= 70)
            //        return Grade.C;
            //    else if (score >= 60)
            //        return Grade.D;
            //    else
            //        return Grade.F;
            //}


            //static double GetAverage(int[] scores)
            //{
            //    int sum = 0;
            //    foreach (int score in scores)
            //    {
            //        sum += score;
            //    }

            //    return (double)sum / scores.Length;
            //}

            //static void GetMinMax(int[] scores, out int min, out int max)
            //{
            //    min = scores[0];
            //    max = scores[0];

            //    for (int i = 0; i < scores.Length; i++)
            //    {
            //        if (scores[i] < min)
            //        {
            //            min = scores[i];
            //        }
            //        if (scores[i] > max)
            //        {
            //            max = scores[i];
            //        }
            //    }

            //}

            #endregion
        }
    }
}
