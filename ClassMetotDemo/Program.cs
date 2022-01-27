using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir bankada müşteri takibi yapmak istiyorsunuz.
            Musteri isimli bir Class oluşturunuz.Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
            MusteriManager sınıfı oluşturunuz.Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz*/
            Customer customer1 = new Customer()
            {
                FirstName = "Muhammed",
                LastName = "Soysal",
                age = 17,
                City = "Istanbul",
                Mail = "Soysalmuhammed000@gmail.com"
            };
            Customer customer2 = new Customer();
            customer2.FirstName = "Muhammet Ali";
            customer2.LastName = "Atila";
            customer2.age = 17;
            customer2.City = "Istanbul";
            customer2.Mail = "MuhammedAliatila@gmail.com";

            Customer [] customers =new Customer[] { customer1, customer2 };
            CustomerManager customerMenager = new CustomerManager();
            customerMenager.Add(customer1);
            customerMenager.Add(customer2);
            Console.WriteLine("--------------------------");
            customerMenager.Delete(customer1);
            customerMenager.Delete(customer2);
            Console.WriteLine("--------------------------");
            customerMenager.Update(customer1);
            customerMenager.Update(customer2);
            Console.WriteLine("--------------------------");
            customerMenager.List(customers);

        }
    }
}