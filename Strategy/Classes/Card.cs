using Strategy.Interfaces;

namespace Strategy.Classes {
    /// <summary>
    /// Classe cartão de crédito
    /// </summary>
    public class Card : IDiscount {

        /// <summary>
        /// Calcula o desconto
        /// </summary>
        /// <param name="sale">Objeto Venda</param>
        /// <returns>Valor de desconto</returns>
        public double Calculate(Sale sale) {
            //Retorna o valor de desconto
            return sale.Amount * 0.0;
        }
    }
}
