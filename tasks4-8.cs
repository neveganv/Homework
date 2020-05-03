using System;

namespace Завдання_1
{
    class Student
    {
        private string surname;
        private string name;
        private int course;
        private int age;
        private int history;
        private int math;
        private int ukrainian;
        private int english;
        public double scholarship { get; set; }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int History
        {
            get { return history; }
            set { history = value; }
        }

        public int Math
        {
            get { return math; }
            set { math = value; }
        }

        public int Ukrainian
        {
            get { return ukrainian; }
            set { ukrainian = value; }
        }

        public int English
        {
            get { return english; }
            set { english = value; }
        }

        public Student(string Surname, string Name, int Course, int Age, int History, int Math, int Ukrainian, int English, double Scholarship)
        {
            surname = Surname;
            name = Name;
            course = Course;
            age = Age;
            history = History;
            math = Math;
            ukrainian = Ukrainian;
            english = English;
            scholarship = Scholarship;
        }
        public void Info() 
        {
            Console.Write("Прізвище та ім'я: {0} {1} \nКурс: {2}\nВік: {3}\n", Surname, Name, Course, Age);
            Console.Write("Історія - {0}; Математика - {1}; Укр. мова - {2}; Англ. мова - {3}\n", History, Math, Ukrainian, English);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] A = new Student[10];
            A[0] = new Student("Винович", "Костянтин", 4, 20, 3, 4, 5, 3, 1478.76);
            A[1] = new Student("Довганюк", "Анастасія", 3, 18, 4, 4, 4, 5, 879.54);
            A[2] = new Student("Козаріз", "Андрій", 5, 21, 5, 5, 5, 5, 1354.99);
            A[3] = new Student("Лесюк", "Ірина", 2, 17, 5, 5, 5, 5, 1243.87);
            A[4] = new Student("Марціновська", "Аліна", 5, 22, 3, 2, 5, 3, 678.99);
            A[5] = new Student("Рибак", "Юлія", 3, 17, 4, 4, 5, 3, 543.77);
            A[6] = new Student("Сандуляк", "Андрій", 5, 23, 3, 4, 4, 4, 567.8);
            A[7] = new Student("Сіранюк", "Владислав", 1, 15, 2, 2, 2, 2, 667.43);
            A[8] = new Student("Скрипнюк", "Христина", 3, 19, 5, 5, 5, 5, 1024.78);
            A[9] = new Student("Тимофійчук", "Віталіна", 2, 16, 3, 2, 3, 4, 786.44);

            Console.WriteLine("\n=================================================================");
            Console.WriteLine("Студенти, які отримали двійку:"); //Завдання 7.
            for (int i = 0; i < 10; i++)
            {
                if (A[i].History == 2 || A[i].Math == 2 || A[i].Ukrainian == 2 || A[i].English == 2)
                    A[i].Info();
            }

            Console.WriteLine("\n=================================================================");
            Console.WriteLine("\nСтуденти, які отримали всі п'ятірки, переміщені на початок:");
            for (int i = 0; i < 10; i++)
            {
                if (A[i].History == 5 && A[i].Math == 5 && A[i].Ukrainian == 5 && A[i].English == 5)
                    A[i].Info();
            }
            for (int i = 0; i < 10; i++)
            {
                if (A[i].History != 5 || A[i].Math != 5 || A[i].Ukrainian != 5 || A[i].English != 5)
                    A[i].Info();
            }

            Console.WriteLine("\n=================================================================");

            Student HighScholarship = new Student("невідомо", "невідомо", 0, 0, 0, 0, 0, 0, 0.00);
            for (int i = 0; i < 10; i++)
            {
                if(A[i].scholarship > HighScholarship.scholarship)
                {
                    HighScholarship = A[i];
                }
            }
            Console.WriteLine("Найвищу стипендію ({0}) отримує {1} {2}", HighScholarship.scholarship, HighScholarship.Surname, HighScholarship.Name);
            
                Console.ReadKey();
        }
    }
}