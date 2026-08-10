namespace Assignment_oop_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 - Q1
            //class  reference type , Heap , copy reference 
            //struct value type , Stack , copy value itself

            //Personclass p1 = new Personclass();
            //p1.Name = "Farida";
            //Personclass p2 = p1;
            //p2.Name = "Ahmed";
            //Console.WriteLine(p1.Name);
            //Console.WriteLine(p2.Name);

            //Console.WriteLine("===================");

            //PersonStruct s1 = new PersonStruct();
            //s1.Name = "Farida";
            //PersonStruct s2 = new PersonStruct();
            //s2.Name = "Ahmed";
            //Console.WriteLine(s1.Name);
            //Console.WriteLine(s2.Name);


            #endregion

            #region Part 1 - Q2
            //Public - accessible from everywhere
            //Private - accessible only inside same class
            //Personclass person = new Personclass();
            //person.Name = "Khaled";
            //person.age // we can't acces age here like name 

            #endregion

            #region Part 1 - Q3
            /*
            Creation steps :
            1- open visual studio 
            2- create new project
            3-select class libabry
            4-name it
            5- click create
            6- then write your code and build it

            using steps :
            1-open your project
            2-add reference to libabry 
            by right click on project and choose add then project reference and select your project libabry
            3-then u can use your libarary code


            */


            #endregion

            #region Part 1 - Q4
            /*
            1- Class libarary 1) -is collection of usuable classes , methods , functions compiled to DLL file
              wich is can be usable in other apps
              2) - if  contains : classes , methods , properties , interfaces , bussiness logic .
              3)- no main method we just build it .

            2-we use class libarary for  :-
                    1) - Resuabilty : we write code once and use it in many projects .
                    2)- organiztionwe : keep appilcations clean and structured .
                    3)- Teamwork : different developers work on different libararies . 
                    4)- maintenance : fix bug once , all projects benefit .


            */

            #endregion


            #region Part 2
            Console.Write("Enter Movie Name: ");
            String moviename = Console.ReadLine();

            Console.Write("Enter Ticket Type (0 = Standard ,1 = VIP , 2 = Max) : ");
            int typeinput = int.Parse(Console.ReadLine());
            TicketType type = (TicketType)typeinput;

            Console.Write("Enter Seat (A , B , C . . . )");
            char row = char.Parse(Console.ReadLine());

            Console.Write("Enter Seat Number : ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter Price : ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Discount Amount : ");
            double discount = double.Parse(Console.ReadLine());

            Seat seat = new Seat(row, number);

            Ticket t = new Ticket(moviename, type, seat, price);


            Console.WriteLine("===Ticket Info===");
            t.PrintTicket(14);



            Console.WriteLine("===After Discount===");
            Console.WriteLine($"Discount Before : {t.GetPrice}");
            t.ApplyDiscount(discount);
            Console.WriteLine($"Discount After : {t.GetPrice}");
            t.PrintTicket(14);


            #endregion
        }
    }
}
