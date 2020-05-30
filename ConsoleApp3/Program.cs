using System;

namespace ConsoleApp2
{
    public class Student
    {

        static public int is_number(string input)
        {
            bool a = true;
            bool a0 = true;
            while (a0)
            {
                while (a)
                {
                    int d = input.Length;
                    foreach (char c in input)
                        if (char.IsNumber(c))
                        {
                            if ((input[0] == '0') && (d != 1))
                            {
                                Console.WriteLine("Ви ввели некоректне значення, введiть нове: ");
                                input = Console.ReadLine();
                                a = true;
                                break;
                            }
                            a = false;
                        }
                        else if ((input[0] == '-') && (d != 1) && (input[1] != '-'))
                            continue;
                        else
                        {
                            Console.WriteLine("Ви ввели некоректне значення, введiть нове: ");
                            input = Console.ReadLine();
                            a = true;
                            break;
                        }
                }

                if (Convert.ToInt32(input) >= 0)
                {
                    a0 = false;
                }
                else
                {
                    Console.WriteLine("Ви ввели некоректне значення, введiть нове: ");
                    input = Console.ReadLine();
                    a = true;
                }
            }
            return Convert.ToInt32(input);
        }

        static public double Average(Monday monday, int j)
        {
            double s = 0;
            for (int i = 0; i < 3; i++)
                s += monday[i, j];
            return s / 3;
        }
        static public double Average(Tuesday tuesday, int j)
        {
            double s = 0;
            for (int i = 0; i < 3; i++)
                s += tuesday[i, j];
            return s / 3;
        }
        static public double Average(Wednesday wednesday, int j)
        {
            double s = 0;
            for (int i = 0; i < 3; i++)
                s += wednesday[i, j];
            return s / 3;
        }
        static public double Average(Thursday thursday, int j)
        {
            double s = 0;
            for (int i = 0; i < 3; i++)
                s += thursday[i, j];
            return s / 3;
        }
        static public double Average(Friday friday, int j)
        {
            double s = 0;
            for (int i = 0; i < 3; i++)
                s += friday[i, j];
            return s / 3;
        }

        public class Temperature
        {
            private string[] temperature;
            public Temperature(int N)
            {
                temperature = new string[N];
            }

            public string this[int Index]
            {
                get
                {
                    return temperature[Index];
                }
                set
                {
                    temperature[Index] = value;
                }
            }
        }
        public class Monday
        {
            private int[,] monday;
            public Monday(int N, int M)
            {
                monday = new int[N, M];
            }

            public int this[int Index1, int Index2]
            {
                get
                {
                    return monday[Index1, Index2];
                }
                set
                {
                    monday[Index1, Index2] = value;
                }
            }
        }
        public class Tuesday
        {
            private int[,] tuesday;
            public Tuesday(int N, int M)
            {
                tuesday = new int[N, M];
            }

            public int this[int Index1, int Index2]
            {
                get
                {
                    return tuesday[Index1, Index2];
                }
                set
                {
                    tuesday[Index1, Index2] = value;
                }
            }
        }
        public class Wednesday
        {
            private int[,] wednesday;
            public Wednesday(int N, int M)
            {
                wednesday = new int[N, M];
            }

            public int this[int Index1, int Index2]
            {
                get
                {
                    return wednesday[Index1, Index2];
                }
                set
                {
                    wednesday[Index1, Index2] = value;
                }
            }
        }
        public class Thursday
        {
            private int[,] thursday;
            public Thursday(int N, int M)
            {
                thursday = new int[N, M];
            }

            public int this[int Index1, int Index2]
            {
                get
                {
                    return thursday[Index1, Index2];
                }
                set
                {
                    thursday[Index1, Index2] = value;
                }
            }
        }
        public class Friday
        {
            private int[,] friday;
            public Friday(int N, int M)
            {
                friday = new int[N, M];
            }

            public int this[int Index1, int Index2]
            {
                get
                {
                    return friday[Index1, Index2];
                }
                set
                {
                    friday[Index1, Index2] = value;
                }
            }
        }

        public Student() { }

        public void Print()
        {
            Console.WriteLine("Введiть кiлькiсть студентiв: ");
            string input0 = Console.ReadLine();
            int n = is_number(input0);

            Temperature temperature = new Temperature(n);
            Monday monday = new Monday(3, n);
            Tuesday tuesday = new Tuesday(3, n);
            Wednesday wednesday = new Wednesday(3, n);
            Thursday thursday = new Thursday(3, n);
            Friday friday = new Friday(3, n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nДні " + (i + 1) + " : ");
                temperature[i] = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Введiть " + (j + 1) + " Понеділок: ");
                    string input = Console.ReadLine();
                    tuesday[j, i] = is_number(input);
                }
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Введiть " + (j + 1) + " Вівторок: ");
                    string input = Console.ReadLine();
                    tuesday[j, i] = is_number(input);
                }
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Введiть " + (j + 1) + " Середа: ");
                    string input = Console.ReadLine();
                    wednesday[j, i] = is_number(input);
                }
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Введiть " + (j + 1) + " Четвер: ");
                    string input = Console.ReadLine();
                    thursday[j, i] = is_number(input);
                }
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Введiть " + (j + 1) + "П'ятниця : ");
                    string input = Console.ReadLine();
                    friday[j, i] = is_number(input);
                }
                Console.WriteLine();
            }

            double[,] a = new double[5, n];
            for (int i = 0; i < n; i++)
            {
                a[0, i] = Average(monday, i);
            }
            for (int i = 0; i < n; i++)
            {
                a[1, i] = Average(tuesday, i);
            }
            for (int i = 0; i < n; i++)
            {
                a[2, i] = Average(wednesday, i);
            }
            for (int i = 0; i < n; i++)
            {
                a[3, i] = Average(thursday, i);
            }
            for (int i = 0; i < n; i++)
            {
                a[4, i] = Average(friday, i);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Температура\tПонеділок\t\tВівторк\t\tСереда\t\tЧетвер\t\tП'ятниця");
                Console.WriteLine("{0}\t\t{1}, {2}, {3}\t\t\t{4}, {5}, {6}\t\t{7}, {8}, {9}\t\t{10}, {11}, {12}\t\t{13}, {14}, {15}", temperature[i], monday[0, i], monday[1, i], monday[2, i], tuesday[0, i], tuesday[1, i], tuesday[2, i], wednesday[0, i], wednesday[1, i], wednesday[2, i], thursday[0, i], thursday[1, i], thursday[2, i], friday[0, i], friday[1, i], friday[2, i]);
                Console.WriteLine(" два дні з найбільшим перепадом температури повітря:\t{0:F1}\t\t\t{1:F1}\t\t{2:F1}\t\t{3:F1}\t\t{4:F1}", a[0, i], a[1, i], a[2, i], a[3, i], a[4, i]);
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Print();
        }
    }
}
