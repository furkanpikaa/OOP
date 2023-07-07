using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            List<ILoggerService> loggers = new List<ILoggerService>() { smsLoggerService, databaseLoggerService };
            basvuruManager.BasvuruYap(esnafKrediManager,loggers);


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            Console.ReadLine();
        }
    }
}
