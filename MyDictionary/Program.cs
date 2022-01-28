using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Aynen derste yaptığımız MyList gibi siz de kendi Dictonary sınıfınızı yazınız. (MyDictionary)
             Sadece ekleme (Add) metodunu yazınız.
             */
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Ahmet");
            dic.Add(2, "Muhammed");
            foreach (var dickisi in dic)
            {
                Console.WriteLine(dickisi);
            }
            Console.WriteLine(dic.Count);   

            Console.WriteLine("------------------------");

            MyDictionary  <int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1, "Muhammed");
            myDictionary.Add(2, "Sıla");
            myDictionary.Add(3, "Elif");
            myDictionary.Add(4, "Muhammet Ali");
            foreach (var kisi in myDictionary.Valuee)
            {
                Console.WriteLine(kisi);
            }
            foreach (var kisi in myDictionary.Keyy)
            {
                Console.WriteLine(kisi);
            }
        }
    }
}