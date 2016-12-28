using System;
using Strategy.Classes;
using Strategy.Enum;
using Strategy.Interfaces;

namespace Strategy {
    internal class Program {
        private static void Main(string[] args) {

            //Cria uma venda
            var sale = new Sale(1000, PaymentMethodEnum.Money);

            var discount = new Discount();

            Console.WriteLine($"-----------------------------Payment method: {sale.PaymentMethodEnum.ToString()}-----------------------------");

            Console.WriteLine($"Amount: {sale.Amount}");

            Console.WriteLine($"Discount: {discount.Calculate(sale)}");


            //Cria uma venda
            var sale2 = new Sale(550, PaymentMethodEnum.Card);

            Console.WriteLine($"-----------------------------Payment method: {sale2.PaymentMethodEnum.ToString()}-----------------------------");

            Console.WriteLine($"Amount: {sale2.Amount}");

            Console.WriteLine($"Discount: {discount.Calculate(sale2)}");

            Console.ReadKey();
        }
    }
}
