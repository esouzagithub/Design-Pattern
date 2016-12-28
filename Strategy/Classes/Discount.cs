using Strategy.Enum;
using Strategy.Interfaces;

namespace Strategy.Classes {

    /// <summary>
    /// Classe desconto
    /// </summary>
    public class Discount : IDiscount {

        /// <summary>
        /// Calcula desconto
        /// </summary>
        /// <param name="sale">Objeto venda</param>
        /// <returns>Valor do desconto</returns>
        public double Calculate(Sale sale) {
            //Verifica forma de pagamento
            switch (sale.PaymentMethodEnum) {
                //Cartão de crédito
                case PaymentMethodEnum.Card:
                    return new Card().Calculate(sale);
                //Moeda
                case PaymentMethodEnum.Money:
                    return new Money().Calculate(sale);
                default:
                    return 0;
            }
        }
    }
}
