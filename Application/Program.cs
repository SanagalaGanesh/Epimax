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
//                Console.WriteLine(affected > 0 ? $"{affected} row(s) deleted.\n" : "⚠️ No student found with that Roll Number.\n");
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



