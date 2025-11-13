//using System;
//using Microsoft.Data.SqlClient;

//namespace Application
//{

//    class Program
//    {
//        static void Main()
//        {

//            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=School;User Id=Nexus;Password=nexus@sql;Trusted_Connection=True;TrustServerCertificate=True;";

//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                conn.Open();
//                Console.WriteLine("Connected to SQL Server!\n");

//                while (true)
//                {
//                    Console.WriteLine("Choose an option:");
//                    Console.WriteLine("1. Insert Student");
//                    Console.WriteLine("2. Update Student");
//                    Console.WriteLine("3. Delete Student");
//                    Console.WriteLine("4. View All Students");
//                    Console.WriteLine("5. Exit");
//                    Console.Write("Enter your choice: ");
//                    string choice = Console.ReadLine();

//                    switch (choice)
//                    {
//                        case "1":
//                            InsertStudent(conn);
//                            break;
//                        case "2":
//                            UpdateStudent(conn);
//                            break;
//                        case "3":
//                            DeleteStudent(conn);
//                            break;
//                        case "4":
//                            ViewStudents(conn);
//                            break;
//                        case "5":
//                            Console.WriteLine("Exiting...");
//                            return;
//                        default:
//                            Console.WriteLine("Invalid choice! Try again.\n");
//                            break;
//                    }
//                }
//            }
//        }

//        static void InsertStudent(SqlConnection conn)
//        {
//            string insert = "INSERT INTO student (Name, RollNumber) VALUES (@name, @roll)";
//            using (SqlCommand cmd = new SqlCommand(insert, conn))
//            {
//                Console.Write("Enter Student Name: ");
//                string name = Console.ReadLine();
//                Console.Write("Enter Student Roll Number: ");
//                string roll = Console.ReadLine();

//                cmd.Parameters.AddWithValue("@name", name);
//                cmd.Parameters.AddWithValue("@roll", roll);

//                int affected = cmd.ExecuteNonQuery();
//                Console.WriteLine($" {affected} row(s) inserted.\n");
//            }
//        }

//        static void UpdateStudent(SqlConnection conn)
//        {
//            string update = "UPDATE student SET Name = @name WHERE RollNumber = @roll";
//            using (SqlCommand cmd = new SqlCommand(update, conn))
//            {
//                Console.Write("Enter Roll Number of student to update: ");
//                string roll = Console.ReadLine();
//                Console.Write("Enter new Name: ");
//                string name = Console.ReadLine();

//                cmd.Parameters.AddWithValue("@name", name);
//                cmd.Parameters.AddWithValue("@roll", roll);

//                int affected = cmd.ExecuteNonQuery();
//                Console.WriteLine(affected > 0 ? $" {affected} row(s) updated.\n" : " No student found with that Roll Number.\n");
//            }
//        }

//        static void DeleteStudent(SqlConnection conn)
//        {
//            string delete = "DELETE FROM student WHERE RollNumber = @roll";
//            using (SqlCommand cmd = new SqlCommand(delete, conn))
//            {
//                Console.Write("Enter Roll Number of student to delete: ");
//                String roll = Console.ReadLine();

//                cmd.Parameters.AddWithValue("@roll", roll);

//                int affected = cmd.ExecuteNonQuery();
//                Console.WriteLine(affected > 0 ? $"{affected} row(s) deleted.\n" : "No student found with that Roll Number.\n");
//            }
//        }

//        static void ViewStudents(SqlConnection conn)
//        {
//            string select = "SELECT * FROM student";
//            using (SqlCommand cmd = new SqlCommand(select, conn))
//            using (SqlDataReader reader = cmd.ExecuteReader())
//            {
//                Console.WriteLine("\nStudents in database:");
//                while (reader.Read())
//                {
//                    Console.WriteLine($"Name: {reader["Name"]}, Roll: {reader["RollNumber"]}");
//                }
//                Console.WriteLine();
//            }
//        }
//    }


//}

//class Operation
//{
//    delegate int One (int x, int y);
//    delegate int Two (int x, int y);
//    public static int Add(int a, int b)
//    {
//        return a + b;
//    }
//    public static int sub(int a, int b)
//    {
//        return a - b;
//    }
//    public static void Main()
//    {
//        int a = 10;
//        int b = 20;
//        One obj1 = new One(Add);
//        Two obj2 = new Two(sub);
//        Console.WriteLine("Addition: " + obj1(a, b));
//        Console.WriteLine("Subtraction: " + obj2(a, b));
//    }
//}


//class A
//{
//     private int x = 100;
//        protected void Display() 
//    {
//        Console.WriteLine(x);

//    } 
//}
//class B : A
//{
//    public void Show()
//    {
//        Display();
//    }
//}   
//class Program
//{
//    public static void Main()
//    {
//        B obj = new B();
//        obj.Show();
//    }
//}


//class Person
//{
//    private int age = 10;
//    public int Age
//    {
//        get{
//            return age;
//        }
//        set{
//            age= value;
//        }

//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        Person p= new Person();
//        p.Age = 18;
//        Console.WriteLine(p.Age);
//    }
//}

//class Persons
//{
//    public string Name = Console.ReadLine();
//    public int Age = int.Parse(Console.ReadLine());
//}
//class Vote : Persons
//{
//    public bool b;
//   public void check()
//    {
//        if (Age >= 18)
//        {
//            Console.WriteLine($"{Name} is ELIGIBLE To Vote");
//             b = true;
//        }
//        else
//        {
//            Console.WriteLine($"{Name} is INELIGIBLE To Vote");
//        }
//    }

//}
//class Greating : Vote
//{
//    public void display() 
//    {
//        if (b) 
//        {
//            Console.WriteLine("Vote is a RESPONSIBILITY");
//        }
//    }
//}
//class Program { 
//public static void Main()
//{
//        Greating V=new Greating();
//        V.check();
//        V.display();
//}
//}

//interface Vote
//{
//    void check();
//    void display();

//}
//interface Greetings
//{
//    void display();
//}

//class Helo : Greetings
//{
//    public void display()
//    {
//        Console.WriteLine("WELCOME CHECK YOUR ELEGIBILTY HERE !");

//    }

//}
//class Persons : Vote
//{
//    public string Name = Console.ReadLine();
//    public int Age = int.Parse(Console.ReadLine());
//    public bool b;
//    public void check()
//    {
//        if (Age >= 18)
//        {
//            Console.WriteLine($"{Name} is ELIGIBLE To Vote");
//            b = true;
//        }
//        else
//        {
//            Console.WriteLine($"{Name} is INELIGIBLE To Vote");
//        }

//    }
//    public void display()
//    {
//        if (b)
//        {
//            Console.WriteLine("Vote is a RESPONSIBILITY");
//        }
//    }

//}

//class Program
//{

//    public static void Main()
//    {
//        Greetings G = new Helo();
//        G.display();
//        Vote V = new Persons();
//        V.check();
//        V.display();

//    }
//}


// Polymorphism

//1.Over Ridding - RunTime Polymorphism

//class A
//{
//    public virtual void show()
//    {
//        Console.WriteLine("Hello");
//    }
//}
//class B:A
//{
//    public override void show() {
//        Console.WriteLine("Hello World");
//    }
//}
//class P
//{
//    public static void Main()
//    {
//        B b = new B(); 
//        b.show();
//    }
//}

//2.Over Loading - Compile Time Polymorphism

//class A
//{
//    public void Add(int x, int y)
//    {
//        Console.WriteLine(x + y);
//    }
//    public void Add(int a,int b,int c)
//    {
//        Console.WriteLine((a + b)-c);
//    }

//}
//class P
//{
//    public static void Main()
//    {
//        A b = new A();
//        b.Add(20,19);
//        b.Add(10, 5,2);
//    }
//}

//abstract class A // Abstract Class
//{
//    public abstract void show(); // Abstract Method
//    public void hello()
//    {
//        string x=Console.ReadLine();
//        Console.WriteLine($"Hello {x}");
//    }
//}
//class B:A 
//{
//    public override void show()    // Override should be written to use Abstract Method
//    { 
//        Console.WriteLine("Your Balance is XXXX ");
//    }
//}
//class P
//{
//    public static void Main()
//    {
//        B b = new B();
//        b.hello();
//        b.show();
//    }
//}

//List<string> A = new List<String>() {"Ganesh","Uzma","Vaishuu"};
//foreach(string i in A)
//{
//    Console.Write(i+",");
//}

//List<int> B = new List<int>() { 1, 2, 3, 4, 5 };
//Console.WriteLine(B);
//B.Add(6);
//B[0] = 2;
//B.Remove(2);
//B.RemoveAt(0);
//B.Clear();
//foreach (int i in B)
//{
//    Console.WriteLine(i);
//}

//Dictionary<int, string> A = new Dictionary<int, string>()
//{ { 1, "uzma" },{2,"Ganesh"},{ 3,"Vaishu"} };
////A.Remove(1);
//A[1] = "Uzma Afreen";
//A[2] = "S.Ganesh";
//A[3] = "M.Vaishnavi";
//foreach (var i in A)
//{
//    Console.WriteLine(i);
//}

// Queue -- FirstInFirstOut FIFO -- Enqueue,Dequeue,Peek,clear

//Queue<char> B = new Queue<char>();
//B.Enqueue('A');
//B.Enqueue('B');
//B.Enqueue('C');
////Console.WriteLine(B.Peek());
//B.Dequeue();
//Console.WriteLine(B.Peek());

// Stack -- LastInFristOut LIFO -- Push,Pop,Peek,clear

//Stack<int> A = new Stack<int>();
//A.Push(0);
//A.Push(1);
//A.Push(2);
//A.Push(3);
//A.Push(4);
////Console.WriteLine(A.Peek())
////Console.WriteLine(A.Peek());
//A.Pop();
//A.Pop();
//A.Clear();
//Console.WriteLine(A.Peek());
//foreach (int i in A)
//{
//    Console.WriteLine(i);
//}

//HashSet<int> A=new HashSet<int>() { 1,2,3,4,45,5 };
//foreach (int i in A)
//{
//    Console.WriteLine(i);
//}

//LINQ -- Language Integrated Query

//using System.Linq;

// Where

//List<int> A = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
////var e= A.Where(x => x % 2 == 0); 
//foreach (int i in A)
//{
//    Console.Write(i + " ");
//}

//class Student {
//    public int id;
//    public required string name;
//    public required string rollnumber;
//    public int age;
//}
//class Program
//{
//    public static void Main()
//    { 
//        List<Student> students = new List<Student>()
//        {
//            new Student(){ id=1, name="Ganesh", rollnumber="S101", age=20 },
//            new Student(){ id=2, name="Uzma", rollnumber="S102", age=19 },
//            new Student(){ id=3, name="Vaishnavi", rollnumber="S103", age=21 },
//            new Student(){ id=4, name="Aarav", rollnumber="S104", age=18 },
//            new Student(){ id=5, name="Mira", rollnumber="S105", age=22 }
//        }; 
//        foreach (Student i in students)
//        {
//            Console.WriteLine($"{i.id},{i.name},{i.rollnumber},{i.age}");
//        }

//    }
//}

//OfTypeL<>()

//List<object> A = new List<object>() { 1, "ganesh", 3, "Rakesh", 5, "Uday", 7,"Hanu", 9, 10 };

//var e = A.OfType<int>();
//var f = A.OfType<string>();

//foreach (var i in f)

//{
//    Console.WriteLine(i + " ");
//}

//using System.Collections.Generic;

//class Student
//{
//    public int id;
//    public  string name;
//    public string rollnumber;
//    public int age;
//    public List<string> Names = new List<string>();
//}
//class Program
//{
//    public static void Main()
//    {
//        var students = new List<Student>()
//        {
//            new Student() { id=1, Names=new List<string>{"Ganesh","kanmani" },rollnumber="S102", age=19 },
//            new Student(){ id=2, Names=new List<string>{"Uzma","sahera"}, rollnumber="S102", age=19 },
//            new Student(){ id=3, Names=new List<string>{"Vaishnavi","eshwar" }, rollnumber="S103", age=21 },
//            new Student(){ id=4, Names=new List<string>{"Aarav","subbbu"},rollnumber="S104", age=18 },
//            new Student(){ id=5, Names=new List<string>{"Mira" ,"ram"}, rollnumber="S105", age=22 }
//        };


//        var names = students.SelectMany(s => s.Names);
//        foreach (var i in names)
//        {
//            Console.Write(i+"");            
//        }

//    }
//}

//List<int> A = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//var e = A.Select(s=>s); 
//foreach (int i in e)
//{
//    Console.Write(i + " ");
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Student
//{
//    public int id;
//    public string name;
//    public string rollnumber;
//    public int age;
//    public List<string> Names = new List<string>();
//}

//class Program
//{
//    public static void Main()
//    {
//        var students = new List<Student>()
//        {
//            new Student() { id=1, Names=new List<string>{"Ganesh","Kanmani"}, rollnumber="S102", age=19 },
//            new Student(){ id=2, Names=new List<string>{"Uzma","Sahera"}, rollnumber="S102", age=19 },
//            new Student(){ id=3, Names=new List<string>{"Vaishnavi","Eshwar"}, rollnumber="S103", age=21 },
//            new Student(){ id=4, Names=new List<string>{"Aarav","Subbu"}, rollnumber="S104", age=18 },
//            new Student(){ id=5, Names=new List<string>{"Mira","Ram"}, rollnumber="S105", age=22 }
//        };

//        var names = students.SelectMany(s => s.Names);

//        foreach (var i in names)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}


//class Program
//{
//    public static  void Hello()
//    {
//        Console.WriteLine("Hello World");
//    }

//}

//using System;

//public class NotificationService
//{
//    // Step 1: Delegate declaration
//    public delegate void Notify(string message);

//    // Step 2: Different notification methods
//    public static void SendEmail(string msg)
//    {
//        Console.WriteLine("Email sent: " + msg);
//    }

//    public static void SendSMS(string msg)
//    {
//        Console.WriteLine("SMS sent: " + msg);
//    }

//    public static void SendPush(string msg)
//    {
//        Console.WriteLine("Push Notification: " + msg);
//    }

//    public static void Main()
//    {
//        // Step 3: User chooses how to be notified
//        Notify notifyUser;

//        Console.WriteLine("Choose notification type: 1.Email 2.SMS 3.Push");
//        int choice = int.Parse(Console.ReadLine());

//        if (choice == 1)
//            notifyUser = SendEmail;
//        else if (choice == 2)
//            notifyUser = SendSMS;
//        else
//            notifyUser = SendPush;

//        // Step 4: Send notification
//        notifyUser("Hello Chiru! Your order is ready.");
//    }
//}

//using System;
//using System.IO;
//using System.Threading.Tasks;

//public class Program
//{
//    public static async Task Main()
//    {
//        string filePath = "C:\\Users\\sanag\\OneDrive\\Desktop\\1.txt.txt";
//        string content = await ReadFileAsync(filePath);
//        Console.WriteLine(content);
//    }

//    public static async Task<string> ReadFileAsync(string filePath)
//    {
//        using (StreamReader reader = new StreamReader(filePath))
//        {
//            string content = await reader.ReadToEndAsync();
//            return content;
//        }
//    }
//}


//using System;
//using System.Net.Http;
//using System.Threading.Tasks;

//public class Program
//{
//    public static async Task Main()
//    {
//        string url = "https://api.github.com/users/SanagalaGanesh";

//        using (HttpClient client = new HttpClient())
//        {
//            client.DefaultRequestHeaders.Add("User-Agent", "MyCSharpApp");
//            HttpResponseMessage response = await client.GetAsync(url);
//            string result = await response.Content.ReadAsStringAsync();
//            Console.WriteLine(result);
//        }
//    }
//}

//using System.Threading;
//class P
//{
//    static void task1()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine("Task 1");
//        }
//        Console.WriteLine("exiting t1");

//    }
//    static void task2()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine("Task 2");
//            if (i == 5)
//            {
//                Console.WriteLine("Going to sleep");
//                Thread.Sleep(5000);
//                Console.WriteLine("Woke UP");
//            }
//        }
//        Console.WriteLine("exiting t2");

//    }

//    static void task3()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine("Task 3");
//        }
//        Console.WriteLine("exiting t3");

//    }
//    public static void Main()
//    {
//        Thread t1 = new Thread(task1);
//        Thread t2 = new Thread(task2);
//        Thread t3 = new Thread(task3);

//        t1.Start();
//        t2.Start();
//        t3.Start();
//        t2.Join();
//        Console.WriteLine("exiting Main Thread");

//    }
//}



//class Program
//{
//    static void DoSomeWork()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine($"Worker thread: printing {i}");
//            Thread.Sleep(5000); 
//        }
//        Console.WriteLine("EXIT METHOD");
//    }
//    static void Main()
//    {
//        Thread t1 = new Thread(DoSomeWork);
//        t1.Start();
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine($"Main thread: printing {i}");
//            Thread.Sleep(4000); 
//        }
//        t1.Join();

//        Console.WriteLine("Main thread: All work done!");
//    }


//}



//class P
//{
//    static void namaste()
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine("Namaste");
//            Thread.Sleep(2000);
//        }

//            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//    }

//    static void hello()
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine("Hello");
//            Thread.Sleep(1000);
//        }
//        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

//    }
//    public static void Main()
//    {
//       ThreadPool.QueueUserWorkItem(_=> namaste());
//        ThreadPool.QueueUserWorkItem(_ => hello());
//        Thread.Sleep(10000);
//        Console.WriteLine("Main Thread Exiting");
//    }
//}

// Delegates ie type safe function pointers used to pass methods as arguments to other methods. 



using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

//class P
//{
//    delegate int Calc(int x, int y);
//    public static int Add(int a, int b)
//    {
//        return a + b;
//    }
//    public static int  Mul(int a, int b)
//    {
//        return a * b;
//    }
//    public static void Main()
//    {
//        Console.WriteLine("1.Addition\n2.Multiplication");
//        Dictionary<int,Calc> A = new Dictionary<int, Calc>
//        { { 1,Add },{2,Mul} };

//        Console.WriteLine("Enter your choice :");
//        int choice = int.Parse(Console.ReadLine());

//        if (A.ContainsKey(choice))
//        {
//            Calc c= A[choice];
//            Console.WriteLine("Enter two numbers :");
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine("Result :" + c(a, b));
//        }
//        else
//        {
//            Console.WriteLine("Invalid Choice");
//        }

//    }
//}

// Action,Func,Predicate Delegates    

// Action - (used for methods that do not return a value,instead of delegate).
// No return type and return type is void ie used only for void methods,
// can have 0 or more parameters of different types.
// ie action<int(input parameter),string(input parameter),...void(output or return type value)>

// Func -  (used for methods that return a value,instead of delegate).
// Has return type and can have 0 or more parameters of different types.
// The last parameter is the return type ie used for methods that return a value.
// ie func<int(input parameter),string(input parameter),string(output or return type value)>

// Predicate - (used for methods that return a boolean value,instead of delegate).
// Has return type as bool and can have only one parameter of any type.
// ie predicate<int(input parameter),bool(output or return type value)>

//class P
//{
//    static void Hello(int no,string name)
//    {
//        Console.WriteLine("Hello" +" "+ no +" "+name);
//    }
//    static string Hello1(string name)
//    {
//        return "Hello " + name;
//    }
//    static bool Hello2(string name)
//    {
//        if (name=="ganesh")
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//    public static void Main()
//    {
//        Action<int,string> greet = Hello;
//        greet(1,"ganesh");
//        Func<string,string> greet1 = Hello1;
//        Predicate<string> greet2 = Hello2;
//        Console.WriteLine(greet2("ganesh")); 
//        Console.WriteLine(greet1("ganesh"));
//    }
//}

//class P
//{
//    static int add(int x, int y)=>x+y;
//    static int sub(int x, int y)=>x-y;
//    static int mul(int x, int y)=>x*y;
//    static int div(int x, int y)=>x/y;
//    public static void Main()
//    {
//        Dictionary<string,Func<int,int,int>> A = new Dictionary<string, Func<int, int, int>>()
//        { { "add",add },{ "sub",sub },{ "mul",mul },{ "div",div } };
//        Console.WriteLine("Enter operation to perform(add,sub,mul,div):");
//        string op = Console.ReadLine();

//        if (A.ContainsKey(op))
//        {
//            Func<int, int, int> operation = A[op];
//            Console.WriteLine("Enter two numbers:");
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            int result = operation(a, b);
//            Console.WriteLine($"Result: {result}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid operation!");
//        }
//    }
//}


class P
{
    public delegate void User();
    public event User onclick;

    public void ButtonClick()
    {
        if (onclick != null)
        {
           Console.WriteLine("Button Clicked!");
        }
        else
        {
          Console.WriteLine("No event subscribers.");
        }
    }
}