using Entities;
using Services;
using Repositories;
using System.Security.Cryptography.X509Certificates;

namespace Homework14
{
    internal class StartUp
    {
        public void Start()
        {
            Console.WriteLine("1 Task:Delegates and Events");

            EventsService calculator = new EventsService();

            calculator.OnCalculated += EventsService.HandleCalculation;
            calculator.OnCalculated += EventsService.HandleCalculation;

            EventsService.CalculateWithWrapper(calculator, 3, 7);

            Console.WriteLine("\n2 Task:LINQ");

            List<ContactEntity> contacts = ContactsRepository.GetContacts();

            LinqService.FirstOrDefaultTest(contacts);
            LinqService.WhereTest(contacts);
            LinqService.SelectTest(contacts);
            LinqService.OrderByTest(contacts);
            LinqService.SkipTest(contacts);
            LinqService.CountTest(contacts);
        }
    }
}
