using Strategy.Enum;

namespace Strategy.Classes {
    /// <summary>
    /// Classe venda
    /// </summary>
    public class Sale {
        /// <summary>
        /// Valor da venda
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Forma de pagamento
        /// </summary>
        public PaymentMethodEnum PaymentMethodEnum { get; set; }

        /// <summary>
        /// Construtor 
        /// </summary>
        /// <param name="amount">Valor da venda</param>
        /// <param name="paymentMethodEnum">Forma de pagamento</param>
        public Sale(double amount, PaymentMethodEnum paymentMethodEnum) {
            //Atribui o valor da venda
            Amount = amount;
            //Atribui forma de pagamento
            PaymentMethodEnum = paymentMethodEnum;
        }
    }
}
