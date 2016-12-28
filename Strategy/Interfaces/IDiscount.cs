using Strategy.Classes;

namespace Strategy.Interfaces {
    /// <summary>
    /// Interface de desconto
    /// </summary>
    public interface IDiscount {
        /// <summary>
        /// Calcula o desconto
        /// </summary>
        /// <param name="sale">Objeto Venda</param>
        /// <returns>Valor de desconto</returns>
        double Calculate(Sale sale); 
    }
}
