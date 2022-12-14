using Microsoft.VisualBasic;


namespace HW
{
    //Задание 3.4.3
    enum Semaphore
    {
        Red = 100, Yellow = 200, Green = 300

    }

    internal class Program
    {
        


        static void Main(string[] args)
        {

            ///Задание 3.6.8
            double result = 10 % 3;
            Console.WriteLine(result);

            ///Задание 3.7.4
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            
            Console.WriteLine($"Your name is {name} and age is {age} ");

            Console.Write("What is your favorite day of week?: ");
            int day = checked (int.Parse(Console.ReadLine()));
            DayOfWeek d = (DayOfWeek)day;
            Console.WriteLine($"Your favorite day is {d}");
            Console.ReadKey();



            /// Задание с анкетой
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            
            Console.Write("Введите ваш возраст (число): ");
            byte age = checked ((byte) int.Parse(Console.ReadLine()));
            
            Console.WriteLine($"Вас зовут {name} и ваш возраст {age}");

            Console.Write("Введите дату вашего рождения (в формате дд.мм.гггг): ");
            var date = Console.ReadLine();
            string[] ymd = date.Split(".");
            int day = checked(int.Parse(ymd[0]));
            int month = checked(int.Parse(ymd[1]));
            int year = checked(int.Parse(ymd[2]));

            DateOnly birthdate = new DateOnly(year, month, day);
            Console.WriteLine($"Ваша дата рождения {birthdate.ToLongDateString()}");
            Console.ReadKey();

        }
    }
}