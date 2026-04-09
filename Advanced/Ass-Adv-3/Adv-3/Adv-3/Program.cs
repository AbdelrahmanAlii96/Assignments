namespace Adv_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercise-1

            //List<int> IntCollection = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };

            //// ========== 1 ==========
            //Console.WriteLine("======== Printing Collection ========");
            //foreach (var num in IntCollection)
            //{
            //    Console.Write(num+ " ");
            //}


            //Console.Write($"\nCollection Count : {IntCollection.Count}");
            //Console.Write($"\nFirst Grade : {IntCollection[0]}");
            //Console.Write($"\nLast Grade : {IntCollection[^1]}");


            // ========== 3 ==========
            //Console.WriteLine("======== Sort Asceding ========");
            //IntCollection.Sort();

            //foreach (var num in IntCollection)
            //{
            //    Console.WriteLine(num);
            //}

            // ========== 4 ==========
            //Console.WriteLine("======== First Grade Above 90 ========");
            //Console.WriteLine(IntCollection.Find(n=>n>90));

            // ========== 5 ==========
            //Console.WriteLine("======== Grades below 75 ========");
            //List<int> FailingGrades = IntCollection.FindAll(n => n < 75);
            //Console.WriteLine("Failing Grades");
            //foreach (var num in FailingGrades)
            //{
            //    Console.WriteLine(num);
            //}

            //========== 6 ==========
            //Console.WriteLine("======== Removed All Grades below 75 ========");
            //IntCollection.RemoveAll(n => n < 75);
            //foreach (var num in IntCollection)
            //{
            //    Console.WriteLine(num);
            //}

            // ========== 7 ==========
            //Console.WriteLine("======== If any Grade equal 100 ========");
            //Console.WriteLine(IntCollection.Contains(100));

            // ========== 8 ==========
            //List<string> Grades = new List<string>();
            //foreach (int i in IntCollection)
            //{
            //    Grades.Add("Grade : " + i);
            //}
            //Console.WriteLine("======== String Grades ========");
            //foreach (string i in Grades)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Exercise-2
            //========== 1 ==========

            SortedList<int, string> LeaderBoard = new SortedList<int, string>();
            LeaderBoard.Add(500, "Ahmed");
            LeaderBoard.Add(200, "Sara");
            LeaderBoard.Add(800, "Ali");
            LeaderBoard.Add(350, "Mona");


            //========== 2 ==========
            //Console.WriteLine("========== Print Sorted LeaderBoard ==========");
            //foreach (var item in LeaderBoard)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //}

            //========== 3 ==========
            //Console.WriteLine($"First key : {LeaderBoard.GetKeyAtIndex(0)}");
            //Console.WriteLine($"First Value : {LeaderBoard.GetValueAtIndex(0)}");

            //========== 4 ==========
            //Console.WriteLine("Score 500 exist ? : "+ LeaderBoard.ContainsKey(500));


            //========== 5 ==========
            //if (LeaderBoard.TryGetValue(999, out string name))
            //{
            //    Console.WriteLine($"Player with 999 Score : {name}");
            //}
            //else
            //{
            //    Console.WriteLine("Not player exist with 999 Score");
            //}

            //========== 5 ==========
            //Console.WriteLine("========== Remove player with score 200 ==========");
            //LeaderBoard.Remove(200);
            //foreach (var item in LeaderBoard)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //}



            #endregion

            #region Exercise-3
            //========== 1 ==========

            Dictionary<string, string> Phonebook = new Dictionary<string, string>()
            {
                ["Ali"] = "011445566",
                ["Omar"] = "012445566",
                ["Eslam"] = "015224477",
                ["Khaled"] = "0100889966"
            };

            //========== 2 ==========

            //Phonebook["Said"] = "011114586";
            //foreach (var i in Phonebook)
            //{
            //    Console.WriteLine(i);

            //}

            //========== 3 ==========
            //Phonebook.Add("Said", "01474859");

            //========== 4 ==========
            //Console.WriteLine("Did u Add ? : "+Phonebook.TryAdd("Said", "01474859"));

            //========== 5 ==========
            //string Contactname = "Kamal";
            //if (Phonebook.ContainsKey(Contactname))
            //{
            //    Console.WriteLine($"[{Contactname} , {Phonebook[Contactname]}]");
            //}
            //else
            //{
            //    Console.WriteLine("this Contact isn't exist");
            //}

            //========== 6 ==========
            //string name = "Ali";
            //if (Phonebook.TryGetValue(name, out string value))
            //{
            //    Console.WriteLine($"[{name} , {value}]");
            //}
            //else
            //{
            //    Console.WriteLine("Not Exist");
            //}

            //========== 7 ==========
            //Console.Write("Keys : ");
            //foreach (string key in Phonebook.Keys)
            //{
            //    Console.Write($"{key}  ");
            //}
            //Console.Write("\nValues : ");
            //foreach (string value in Phonebook.Values)
            //{
            //    Console.Write($"{value}  ");
            //}

            #endregion

            #region Exercise-4
            //========== 1 ==========

            HashSet<string> Emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //========== 2 ==========

            Emails.Add("ahmed@test.com");
            Emails.Add("AHMED@test.com");
            Emails.Add("sara@test.com");
            Emails.Add("Sara@Test.Com");

            //========== 3 ==========

            //Console.WriteLine("Count : " + Emails.Count);
            //Because  case-insensitive comparer and Hashset remove duplicate 

            //========== 4 ==========
            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            //========== 5 ==========

            ////==============================//
            //var union = new HashSet<int>(setA);
            //union.UnionWith(setB);

            //Console.Write("UnionWith : ");
            //foreach (var item in union)
            //{
            //    Console.Write(item + " ");
            //}
            ////================================//
            //var intersect = new HashSet<int>(setA);
            //intersect.IntersectWith(setB);

            //Console.Write("\nIntersectWith : ");
            //foreach (var item in intersect)
            //{
            //    Console.Write(item+ " ");
            //}
            ////=================================//
            //var Except = new HashSet<int>(setA);
            //Except.ExceptWith(setB);

            //Console.Write("\nExceptWith : ");
            //foreach (var item in Except)
            //{
            //    Console.Write(item+ " ");
            //}

            //========== 6 ==========
            //HashSet<int> subset = new HashSet<int> { 1, 2 };
            //Console.WriteLine("this set is a Subsut of SetA : " + subset.IsSubsetOf(setA));

            #endregion

            #region Exercise-5

            Queue<string> printQueue = new Queue<string>();
            printQueue.Enqueue("Report.pdf");
            printQueue.Enqueue("Invoice.pdf");
            printQueue.Enqueue("Letter.docx");
            printQueue.Enqueue("Resume.pdf");
            printQueue.Enqueue("Photo.jpg");

            //========== 1 ===========

            //Console.WriteLine("===== Pring Queue =====");
            //foreach (var item in printQueue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Queue Count : "+printQueue.Count);

            //========== 2 ===========

            //Console.WriteLine("Peek to pring next : " + printQueue.Peek());

            //========== 3 ===========
            //Console.WriteLine("===== Dequeue and printing ======");
            //while (printQueue.Count > 0)
            //{
            //    Console.WriteLine($"Printing: {printQueue.Dequeue()}");
            //}

            ////========== 4 ===========
            ////you can use Question 3 to empty Queue and test it
            //Console.WriteLine("TryDequeue on empty queue:");
            //if (printQueue.TryDequeue(out string result))
            //{
            //    Console.WriteLine($"Printing: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Queue is empty, nothing to dequeue.");
            //}

            #endregion

            #region Exercise-6
            Stack<string> History = new Stack<string>();

            //=========== 1 ============
            History.Push("google.com");
            History.Push("github.com");
            History.Push("stackoverflow.com");
            History.Push("youtube.com");
            History.Push("claude.ai");

            //=========== 2 ============
            //Console.WriteLine("Peek : " + History.Peek());

            //=========== 3 ============
            //Console.WriteLine("==== Back 3 Times ====");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Press-{i + 1} : {History.Pop()}");
            //}

            //=========== 4 ============
            //Console.WriteLine("Peek : " + History.Peek());

            //=========== 5 ============
            //Stack<string> EmptyStack = new Stack<string>();
            //if (EmptyStack.TryPop(out string s))
            //{
            //    Console.WriteLine("Poped Value : " + s);
            //}
            //else
            //{
            //    Console.WriteLine("No element to pop ");
            //}


            #endregion
        }
    }
}
