using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MangerMediator mediator = new MangerMediator();
            Colleague programmer = new Programmer(mediator);
            Colleague customer = new Customer(mediator);
            Colleague tester = new Tester(mediator);

            mediator.customer = customer;
            mediator.programmer = programmer;
            mediator.tester = tester;

            customer.Send("Есть заказ, надо сделать программу");
            programmer.Send("Программа готова, надо протестировать");
            tester.Send("Программа протестирована и готова к продаже");

            Console.Read();

        }
    }
}
