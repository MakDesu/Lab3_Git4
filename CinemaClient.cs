using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Git4
{
    internal class CinemaClient
    {
        // Властивості клієнта
        public int ClientId { get; set; } // Унікальний ідентифікатор клієнта
        public string FullName { get; set; } // Повне ім'я клієнта
        public string PhoneNumber { get; set; } // Номер телефону клієнта
        public string Email { get; set; } // Електронна пошта клієнта
        public int BonusPoints { get; set; } // Бонусні бали клієнта

        // Конструктор за замовчуванням
        public CinemaClient()
        {
        }

        // Конструктор з параметрами
        public CinemaClient(int clientId, string fullName, string phoneNumber, string email, int bonusPoints = 0)
        {
            ClientId = clientId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            BonusPoints = bonusPoints;
        }

        // Метод для відображення інформації про клієнта
        public void DisplayInfo()
        {
            Console.WriteLine($"ID клієнта: {ClientId}");
            Console.WriteLine($"Ім'я клієнта: {FullName}");
            Console.WriteLine($"Телефон: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Бонусні бали: {BonusPoints}");
        }

        // Метод для додавання бонусних балів
        public void AddBonusPoints(int points)
        {
            BonusPoints += points;
            Console.WriteLine($"{points} бонусних балів додано. Поточний баланс: {BonusPoints}");
        }

        // Метод для зняття бонусних балів
        public bool RedeemBonusPoints(int points)
        {
            if (BonusPoints >= points)
            {
        
                Console.WriteLine($"{points} бонусних балів списано. Поточний баланс: {BonusPoints}");
                return true;
            }
            else
            {
                Console.WriteLine("Недостатньо бонусних балів для списання.");
                return false;
            }
        }
    }
}
