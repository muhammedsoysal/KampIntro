using System;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            //ILoggerService smsLoggerService = new SmsLoggerService();

<<<<<<< HEAD
            List<ILoggerService> loggers = new List<ILoggerService>() { new DatabaseLoggerService(), new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, loggers);
=======
            List<ILoggerService>loggers = new List<ILoggerService>() { new DatabaseLoggerService(), new SmsLoggerService(),new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,loggers);
>>>>>>> ef43060a35269ea88641688595b8a3ad3828487a

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}