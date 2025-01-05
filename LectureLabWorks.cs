using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {/*
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = " JK Rowling";
            book1.pagenumber = 250;

            Book book2 = new Book();
            book2.title = "Lordd of the Rings";
            book2.author = "Tolkien";
            book2.pagenumber = 350;

            Console.WriteLine(book1.title);
            book1.Borrow(book1.title);

            Console.ReadLine();

        }


        class Book
        {
            public string title;
            public string author;
            public int pagenumber;

            public void Borrow(string title)
            {
                Console.WriteLine("The" + title + "book is borrowed.");
            }
        }
    }

        static void Main(string[] args )
        {
            Student student1 = new Student();
            student1.name = "Sultan Gül ";
            student1.surname = "Aşkın";
            student1.showinfo(student1.name, student1.surname);
            student1.midexam = 80;
            student1.finalexam = 100;
            Console.WriteLine(student1.getaverage(student1.midexam, student1.finalexam));

            Console.ReadLine();

        }

        class Student
        {
            public string name;
            public string surname;
            public int midexam;
            public int finalexam;

            public double getaverage(int midexam, int finalexam)
            {
                double average = midexam * 0.4 + finalexam * 0.6;
                return average;
            }

            public void showinfo(string name, string surname)
            {
                Console.WriteLine("Adı " + name + "Soyadı " + surname);
            }

        }


        class Car
        {
            string name;

            public Car()
            {
                Console.WriteLine("Car object has been created");
            }
        }

        static void Main (string[] args)
        {
            for (int i = 1; i<= 5; i++)
            {
                Car car = new Car();
            }

            Console.ReadLine();
        }

        class Car
        {
            public int numberofDoors;
        }
        
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine("Number of the doors : " + car1.numberofDoors);

            Console.ReadLine();
        }


        class Car
        {
            public int numberofDoors;

            public Car(int doors)
            {
                numberofDoors = doors;
            }
        }

        static void Main (string[] args)
        {
            Car car1 = new Car(1);
            Car car2 = new Car(5);
            
            Console.WriteLine(car2.numberofDoors);

            Console.ReadLine();
        }


        class Car
        {
            public Car()
            {
                Console.WriteLine("Car object has been created");
            }

            static Car()
            {
                Console.WriteLine("It  runs before constructor");
               
            }

        }

        static void Main(string[] args)
        {
            for (int i=1; i<= 5; i++)
            {
                Car car = new Car();
            }

            Console.ReadLine();
        }


        class Person
        {
            private string name; //field
            private int age;  //field

            public string Name //property
            {
                get { return name; }
                set { name = value; }
                
            }

            public int Age //property
            {
                get
                {
                    return age;
                }
                set
                {
                    if (value < 0)
                        age = 0;
                    else age = value;
                }
            }
        }
        
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Ahmet";
            p1.Age = -15;
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Age);
            Console.ReadLine();

        }

        class Person
        {
            private int Age;
            private string Name;
            private string eyecolour; //field


            public string Eyecolour // property
            {
                get
                {
                    return eyecolour;
                }
                set
                {
                    if (value != "Kahverengi" && value != "Yeşil" && value != "Mavi" && value != "Siyah")
                        eyecolour = "Kahverengi";
                    else
                        eyecolour = value;
                }
            }

            static void Main(string[] args)
            {
                Person p1 = new Person();

                p1.Age = 30;
                p1.Name = "Ahmet";
                p1.Eyecolour = "Mavi";

                Console.WriteLine(p1.Eyecolour);
                Console.ReadLine();
            }

        }

        class Book
        {
            public int number;

            public Book(int id)
            {
                number = id;
                Console.WriteLine(number + ". book object has been created");
            }

            ~Book()
            {
                Console.WriteLine(number + "object has been deleted");
            }

            static void Main(string[] args)
            {
                for (int i = 1; i <= 5; i++)
                new Book(i);

                Console.WriteLine("-----------");
                GC.Collect();
                Console.ReadLine();

            }
        }

        class Test
        {
            int num;

            public Test(int num)
            {
                this.num = num;
            }

            static void Main(string[]args)
            {
                Test t1 = new Test(4);
                Console.WriteLine("Value of num: " + t1.num);
                Console.ReadLine();
            }
        }

        class Test
        {
            int num;

            public Test(int num1, int num2)
            {
                Console.WriteLine("Constructor with two parameter");
            }

            //invokes the constructor with 2 parameters

            public Test(int num) : this(33, 22)
            {
                Console.WriteLine("Constructor with one parameter");
            }

            static void Main(string[] args)
            {
                Test t2 = new Test(11);
                Console.ReadLine();
            }
        }

        class Student
        {
            public string name;
            public string surname;
            public int midtermexamgrade;
            public int finalexamgrade;
            public double average;

            public Student(string name, string surname, int midtermexamgrade, int finalexamgrade)
            {
                this.name = name;
                this.surname = surname;
                this.midtermexamgrade = midtermexamgrade;
                this.finalexamgrade = finalexamgrade;

            }


            public double getAverage()
            {
                average = ((midtermexamgrade * 0.4 )+( finalexamgrade * 0.6));
                return average;
            }

            public void showinfo()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Surname: " + surname);

            }
            static void Main(string[] args)
            {
                Student std1 = new Student("Meltem", "Aşkın", 62, 100);
                std1.showinfo();
                Console.Write("Average : " + std1.getAverage());

                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your surname: ");
                string surname = Console.ReadLine();

                Console.Write("Enter your midterm exam grade: ");
                int midtermexamgrade = int.Parse(Console.ReadLine());

                Console.Write("Enter your final exam grade: ");
                int finalexamgrade = int.Parse(Console.ReadLine());

                Student std2 = new Student (name, surname, midtermexamgrade, finalexamgrade);

                std2.showinfo();
                Console.WriteLine("Average : " + std2.getAverage());

                Console.ReadLine();


            }
        }
        

        static void Main(string[] args)
        {
            int[] arraynumber = { 12, 25, 48, 54, 62, 78, 96, 63, 52, 10, 10, 10, 20, 20, 30 };

            Console.Write("Please enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            foreach (var number in arraynumber)
            {
                if (number== userNumber)
                {
                    counter++;
                }
            }

            if (counter > 0)
            {
                Console.WriteLine("The number {0} appears {1} times in the array.", userNumber, counter);
            }
            else
            {
                Console.WriteLine("The number{0} is not found in the array.", userNumber);
            }
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("Emine");
            myAL.Add("UÇAR");
            myAL.Add("MIS");


            
            myAL.Insert(0,"fgnjfj");
            myAL.Remove("Emine");

            bool isthere = myAL.Contains("Emine");
                Console.WriteLine(isthere);
            Console.ReadLine();
            myAL.Sort();

            foreach (var i in myAL)
                Console.WriteLine(i);
            Console.ReadLine();

            Console.WriteLine("Count:  {0}", myAL.Count);
            Console.WriteLine("Capacity: {0}", myAL.Capacity);
            Console.ReadLine();

            for(int i = 0;i<myAL.Count; i++)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }

            if (myAL.Contains("UÇAR"))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        

        public class Cat
        {
            protected int numberOfFeet = 4;

            public void hunt()
            {
                Console.WriteLine("Cat hunted");
                Console.ReadLine();

            }
        }

        public class  Tiger: Cat
        {
            static void Main(string[] args)
            {
                Tiger tg = new Tiger();
                tg.hunt();

                Console.WriteLine("Number of feet: " + tg.numberOfFeet);
                Console.ReadLine();


            }
        }

        public class BankAccount
        {
            public BankAccount()
            {
                Console.WriteLine("BankAccount constructor method");
                Console.ReadLine();

            }
        }

        public class SavingsAccount : BankAccount
        {
            public SavingsAccount()
            {
                Console.WriteLine("SavingAccount constructor method");
                Console.ReadLine();
            }
        }

        public class GoldSavingAccount : SavingsAccount
        {
            public GoldSavingAccount()
            {
                Console.WriteLine("GoldSavingAccount constructor method");
                Console.ReadLine();

            }
        }

        static void Main(string[] args)
        {
            GoldSavingAccount gsa = new GoldSavingAccount();
        }

        static void Main(string[] args)
        {
            Cat ct = new Cat(2, "White");
            Console.WriteLine($"Cat's age: {ct.age}, color: {ct.color}");
            ct.Eat(); // Base class'dan gelen Eat metodunu çağırır
            ct.meow(); // Cat sınıfına özel meow metodunu çağırabilir

            // Dog sınıfı için örnek oluşturma ve metod çağrısı
            Dog dog = new Dog("Labrador", "Black");
            Console.WriteLine($"Dog's breed: {dog.breed}, color: {dog.color}");
            dog.Eat(); // Base class'dan gelen Eat metodunu çağırır
            dog.bark(); // Dog sınıfına özel bark metodunu çağırabilir

            Console.ReadLine(); // Çıkmadan önce terminalde bekler
        }

        public class Animal
        {
            public string color;

            public Animal (string color)
            {
                this.color = color;
            }

            public void Eat()
            {
                Console.WriteLine("Animal eat");
               
            }
        }

        public class Cat : Animal
        {
            public int age;

            public Cat(int age, string color) : base(color) { this.age = age; }

            public void meow()
            {
                Console.WriteLine("Meow!");
            }
        }

        public class Dog: Animal
        {
            public string breed;

            public Dog(string breed, string color) : base (color)
            {
                this.breed = breed;
            }

            public void bark()
            {
                Console.WriteLine("Woof!");
            }
        }


        public class Person
        {
            public string nameSurname;
            public string date;
            public char gender;

            public Person(string nameSurname, string date, char gender)
            {
                this.nameSurname = nameSurname;
                this.date = date;
                this.gender = gender;
            }   

            public void ShowPersonInfo()
            {
                Console.WriteLine("Name and Surname: " + this.nameSurname);
            }
        }
        public class Student: Person
        {
            int studentID;
            string department;

            public Student(string nameSurname, string date, char gender,
                int studentID, string derartment) : base (nameSurname,date, gender)
            {
                this.studentID = studentID;
                this.department = department;
            }

            public void ShowStudentInfo()
            {
                Console.WriteLine("Name and Surname : " + this.nameSurname + "Student ID: " + this.studentID);
            }
        }

        public class Staff : Person
        {
            int staffID;
            string department;
            string title;

            public Staff(string nameSurname, string date, char gender, int staffID, string department, string title) : base(nameSurname, date, gender)
            {
                this.staffID = staffID;
                this.department = department;
                this.title = title;
            }

            public void ShowStaffInfo()
            {
                Console.WriteLine("Name and Surname : " + this.nameSurname + "Staff ID: " + this.staffID);
            }

            static void Main(string[] args)
            {
                Student student1 = new Student("Aynur Kaya", "20/10/21", 'K', 213234334, "MIS");
                Staff staff1 = new Staff("Emine", "83954", 'K', 435344, "dfrg", "tgffghtdhgtf");
                Person person1 = new Person("fgthdhgtf", "65563635", 'E');

                student1.ShowStudentInfo();
                staff1.ShowStaffInfo();
                person1.ShowPersonInfo();
                Console.ReadLine();
            }
        }

        public class Calculate
        {
            public void AddNumbers(int a , int b)
            {
                Console.WriteLine("a+b={0}", a + b);
            }

            public void AddNumbers(int a, int b, int c)
            {
                Console.WriteLine("a+b+c={0}", a + b + c);
            }
        }

        static void Main(string[] args)
        {
            Calculate c= new Calculate();
            c.AddNumbers(1, 2);
            c.AddNumbers(1, 2, 3);

            Console.ReadLine();
        }

        public class Chef
        {
            public void MakeChicken()
            {
                Console.WriteLine("The Chef makes chicken");
            }

            public virtual void MakeSpecialDish()
            {
                Console.WriteLine("The Chef makes special barbecue ribs");
            }
        }

        public class TurkishChef: Chef
        {
            public override void MakeSpecialDish()
            {
                Console.WriteLine("The Chef makes special İskender kebab");
            }
        }

        static void Main(string[] args)
        {
            Chef chef = new Chef();
            Chef trchef = new TurkishChef();

            chef.MakeSpecialDish();
            trchef.MakeSpecialDish();
            Console.ReadLine();
        }


        public class Employee
        {
            public Employee()
            {
                salary = 17000;
            }
            public string nameSurname;
            protected decimal salary;

            public decimal Salary
            {
                get
                {
                    return salary;
                }
            }

            public virtual void CalculateSalary()
            {

            }

            public class Officer : Employee
            {
                public Officer()
                {

                }

                public override void CalculateSalary()
                {
                    salary = 25000;
                }
            }

            public class Manager : Employee
            {
                public Manager()
                {

                }
                public override void CalculateSalary()
                {
                    salary = 42000;
                }
            }

            static void Main(string[]args)
            {
                Employee employee = new Employee();
                employee.CalculateSalary();
                Console.WriteLine(employee.Salary);

                Employee employee2 = new Officer();
                employee2.CalculateSalary();
                Console.WriteLine(employee2.Salary);

                Employee employee3 = new Manager();
                employee3.CalculateSalary();
                Console.WriteLine(employee3.Salary);

                Console.ReadLine();


            }

            
        }


        public class Employee
        {
            public Employee()
            {

            }

            private const decimal minimumvage = 17000;
            private const decimal familysupport = 4000;

            public string nameSurname;
            protected decimal salary;

            public decimal Salary
            {
                get
                {
                    return salary;
                }
            }

            public virtual void CalculateSalary()
            {
                salary = minimumvage + familysupport;
            }

            public class Officer: Employee
            {
                public Officer()
                {

                }

                public override void CalculateSalary()
                {
                    base.CalculateSalary();
                    salary *= 2;
                }
            }

            public class  Manager : Employee
            {
                public Manager()
                {

                }
                public override void CalculateSalary()
                {
                    base.CalculateSalary();
                    salary *= 4;
                }

            }
        }

        static void Main(string[] args)
        {
            // Employee için örnek
            Employee employee = new Employee();
            employee.CalculateSalary();
            Console.WriteLine($"Employee Salary: {employee.Salary}");

            // Officer için örnek
            Employee officer = new Employee.Officer();
            officer.CalculateSalary();
            Console.WriteLine($"Officer Salary: {officer.Salary}");

            // Manager için örnek
            Employee manager = new Employee.Manager();
            manager.CalculateSalary();
            Console.WriteLine($"Manager Salary: {manager.Salary}");

            Console.ReadLine(); // Programın kapanmaması için bekle
        }



        public class Student
        {
            public Student() { }
            private const decimal unitCourseFee = 800;
            public string nameSurname { get; set; }
            public int numberOfCredits { get; set; }
            public decimal totalCourseFee { get; set; }

            public virtual void CalculateCourseFee()
            {
                totalCourseFee += unitCourseFee * numberOfCredits;
            }

            public class ScholarshipStudent : Student
            {
                public ScholarshipStudent() { }
                public int scholarshipRate;
                public decimal scholarshipDiscount { get; set; }

                public override void CalculateCourseFee()
                {
                    base.CalculateCourseFee();
                    scholarshipDiscount = (totalCourseFee * scholarshipRate) / 100;
                }
            }

            static void Main(string[] args)
            {
                Student student = new Student();
                student.numberOfCredits = 28;
                student.CalculateCourseFee();
                Console.WriteLine("Total Course Fee = " + student.totalCourseFee);

                ScholarshipStudent scholarshipstudent = new ScholarshipStudent();
                scholarshipstudent.numberOfCredits = 28;
                scholarshipstudent.scholarshipRate = 20;

                scholarshipstudent.CalculateCourseFee();

                Console.WriteLine("Scholarship Discount = " + scholarshipstudent.scholarshipDiscount);
                Console.ReadLine();
            }
        }
         
        abstract class Shape
        {
            public abstract double GetArea();
            public abstract double GetPerimeter();
        }

        class Rectangle : Shape
        {
            private double width;
            private double height;

            public Rectangle ( double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public override double GetArea()
            {
                return (width * height);
            }

            public override double GetPerimeter()
            {
                return 2* (width + height);
            }

        }

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 8);
            Console.WriteLine("Area =" + r.GetArea());
            Console.WriteLine("Perimeter =" + r.GetPerimeter());
            Console.ReadLine();
        }

        

public abstract class Employee
    {
        public const decimal minimumwage = 17000;

        public string NameSurname { get; set; }

        public decimal Salary { get; set; }

        public abstract void CalculateSalary();
    }

    public class Civilservant : Employee
    {
        public override void CalculateSalary()
        {
            Salary = minimumwage * 2;
        }
    }

    public class Salesperson : Employee
    {
        public decimal MonthlySales = 10000;

        public decimal Salesbonus { get; set; }

        public override void CalculateSalary()
        {
            Salary = minimumwage * 2;
            Salesbonus = MonthlySales / 10;
            Salary += Salesbonus;
        }
    }

    // Accountant sınıfını buraya ekledim
    public class Accountant : Employee
    {
        public override void CalculateSalary()
        {
            Salary = minimumwage * 1.5m; // Örnek olarak maaşı 1.5 katı yaptım
        }
    }

    
        static void Main(string[] args)
        {
            // Civilservant nesnesi
            Civilservant civilservant = new Civilservant();
            Console.WriteLine("Enter the name of the civil servant");
            civilservant.NameSurname = Console.ReadLine();
            civilservant.CalculateSalary();
            Console.WriteLine($"Civilservant {civilservant.NameSurname} Salary: {civilservant.Salary}");

            // Salesperson nesnesi
            Salesperson salesperson = new Salesperson();
            Console.WriteLine("Enter the name of the salesperson");
            salesperson.NameSurname = Console.ReadLine();
            salesperson.CalculateSalary();
            Console.WriteLine($"Salesperson {salesperson.NameSurname} Salary: {salesperson.Salary}");

            // Accountant nesnesi - buradaki eksik sınıf tanımını ekledim
            Accountant accountant = new Accountant();
            Console.WriteLine("Enter the name of the accountant");
            accountant.NameSurname = Console.ReadLine();
            accountant.CalculateSalary();
            Console.WriteLine($"Accountant {accountant.NameSurname} Salary: {accountant.Salary}");

            Console.ReadLine(); // Programın kapanmaması için bekler
        }

        public interface IFlyable
        {
            void Fly();
        }

        public interface ISwimmable
        {
            void Swim();
        }

        public class Bird: IFlyable, ISwimmable
        {
            private string name;

            public Bird(string name)
            {
                this.name = name;
            }

            public void Fly()
            {
                Console.WriteLine(name + " is flying.");
            }

            public void Swim()
            {
                Console.WriteLine(name + " is swimming.");
            }

            static void Main(string[] args)
            {
                Bird bird = new Bird("Eagle");
                bird.Fly();
                bird.Swim();

                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            checkAge(15);
            Console.ReadLine();
        }

        static void checkAge(int age)
        {
            if (age<18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough");
            }
        }

        static void Main(string[]args)
        {
            double length, width;

            try
            {
                Console.WriteLine("Enter the length of the rectangle");
                length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the width of the rectangle");
                width = Convert.ToDouble(Console.ReadLine());

                double area = length * width;

                Console.WriteLine("The area of the rectangle is:" + area);

            }

            catch ( FormatException)
            {
                Console.WriteLine("Invalid input! Please enter valid numeric values.");

            }

            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            Console.ReadKey();
        }*/

    }

}



