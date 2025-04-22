using System;

namespace Lab3_Git4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Тестування класу CinemaClient ===");

            // Створення об'єкта клієнта
            CinemaClient client = new CinemaClient(1, "Олександр Коваленко", "+380123456789", "olexandr.kovalenko@gmail.com", 100);

            // Відображення інформації про клієнта
            Console.WriteLine("\nІнформація про клієнта:");
            client.DisplayInfo();

            // Додавання бонусних балів
            Console.WriteLine("\nДодаємо бонусні бали...");
            client.AddBonusPoints(50);

            // Списання бонусних балів
            Console.WriteLine("\nСписуємо бонусні бали...");
            bool success = client.RedeemBonusPoints(120);

            if (success)
            {
                Console.WriteLine("Бонусні бали успішно списано.");
            }
            else
            {
                Console.WriteLine("Не вдалося списати бонусні бали через недостатній баланс.");
            }

            // Відображення оновленої інформації про клієнта
            Console.WriteLine("\nОновлена інформація про клієнта:");
            client.DisplayInfo();

            // Завершення програми
            Console.WriteLine("\nТестування завершено.");
        }
    }

}
