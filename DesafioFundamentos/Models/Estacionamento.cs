namespace DesafioFundamentos.Models
{
    /// <summary>
    /// Classe responsável por toda lógica de gerenciamento do estacionamento
    /// </summary>
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        /// <summary>
        /// Função responsável por cadastrar um veículo no estacionamento 
        /// </summary>
        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string addPlaca = Console.ReadLine();
            string placa = addPlaca.ToUpper();
            this.veiculos.Add(placa);
            Console.WriteLine($"Veículo {placa} adicionado no sistema!");
        }

        /// <summary>
        /// Função responsável por remover a placa do veículo do sistema
        /// </summary>
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = this.precoInicial + (this.precoPorHora * horas);
                
                // TODO: Remover a placa digitada da lista de veículos
                this.veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        /// <summary>
        /// Função responsável por Listar a placa de todos os veículos que estão no estacionamento
        /// </summary>
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                int cont = 1;
                foreach (string item in this.veiculos)
                {
                    Console.WriteLine($"Veículo {cont} : {item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
