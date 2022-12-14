using Microsoft.VisualBasic;


namespace HW
{
    internal class Program
    {


        static void Main(string[] args)
        {

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