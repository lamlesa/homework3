using System;

namespace homework3
{
    enum Week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Cards
    {
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    public class hw3
    {
        public static void Moon(byte x)
        {
            if ((x < 6) || (x > 14))
            {
                throw new Exception("Введённое значение не является достоинством карты .");
            }
            else
            {
                Cards card = (Cards)Enum.GetValues(typeof(Cards)).GetValue(x - 6);
                Console.WriteLine($"Этому достоинству соответствует: {card}");
            }
        }
        public static void Star(char n)
        {
            byte x = Convert.ToByte(Convert.ToString(n));
            if ((x < 1) || (x > 7))
                throw new Exception("Введённое значение не является номером дня недели .");
            else
            {
                Week day = (Week)Enum.GetValues(typeof(Week)).GetValue(x - 1);
                Console.WriteLine($"\nСоответствующий день недели: {day}");
            }
        }
        static void Main(string[] args)
        {


            {
                Console.WriteLine("Задание 1:");
                int[] numbers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                Random n = new Random();
                byte count = 0;
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = n.Next(200);
                    Console.Write($"{numbers[i]} ");
                }
                for (int i = 0; i < 9; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        Console.WriteLine($"\nПорядковый номер ломающего элемента = {i + 2}");
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                if (count == 9)
                {
                    Console.WriteLine("Введённая последовательность является возрастающей .");
                }
            }

            Console.WriteLine("");

            {
                Console.WriteLine("Задание 2:");
                Console.Write("Введите достоинство карты (потом Enter): ");
                byte value;
                bool flag = byte.TryParse(Console.ReadLine(), out value);
                while (!flag)
                {
                    Console.Write("Введите достоинство карты ещё раз: ");
                    flag = byte.TryParse(Console.ReadLine(), out value);
                }
                try
                {
                    Moon(value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Спасибо за попытку !");
                }
            }

            Console.WriteLine("");

            {
                Console.WriteLine("Задание 3:");
                Console.Write("Введите род деятельности (потом Enter): ");
                string person = Console.ReadLine();
                Console.Write("Предложенный напиток: ");
                switch (person.ToLower())
                {
                    case "jabroni": Console.WriteLine("Patron Tequila"); break;
                    case "school counselor": Console.WriteLine("Anything with Alcohol"); break;
                    case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                    case "bike gang member": Console.WriteLine("Moonshine"); break;
                    case "politician": Console.WriteLine("Your tax Dollars"); break;
                    case "rapper": Console.WriteLine("Cristal"); break;
                    default: Console.WriteLine("Beer"); break;
                }
            }

            Console.WriteLine("");

            {
                Console.WriteLine("Задание 4:");
                Console.Write("Введите порядковый номер дня недели (потом Enter): ");
                char number = Console.ReadKey().KeyChar;
                bool flag = Char.IsDigit(number);
                while (!flag)
                {
                    Console.Write("\nВведите порядковый номер дня недели ещё раз: ");
                    number = Console.ReadKey().KeyChar;
                    flag = Char.IsDigit(number);
                }
                try
                {
                    Star(number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nОшибка: {ex.Message}");
                }
            }

            Console.WriteLine("");

            {
                Console.WriteLine("Задание 5:");
                byte count = 0;
                string[] toys = { "Barbie doll", "Monster High doll", "Hello Kitty", "LEGO", "Sylvanian Family" };
                foreach (string toy in toys)
                {
                    Console.WriteLine($"{toy}");
                    if (toy == "Barbie doll" || toy == "Hello Kitty")
                    {
                        count++;
                    }
                }
                Console.WriteLine($"В сумке кукол: {count}"); ;
            }

            Console.WriteLine("");

        }
    }
}