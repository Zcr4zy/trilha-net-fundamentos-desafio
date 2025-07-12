namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> veiculos = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Veiculo veiculo = new();
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            /* IMPLEMENTADO! */
            Console.Write("Digite a placa do veículo para estacionar: ");
            veiculo.Placa = Console.ReadLine();
            Console.Write("Informe o modelo do veículo para estacionar: ");
            veiculo.Modelo = Console.ReadLine();
            Console.Write("Informe a cor do veículo para estacionar: ");
            veiculo.Cor = Console.ReadLine();

            if (this.veiculos.Count > 0 && this.veiculos.LastOrDefault().NumeroTicketEstacionamento != null)
                veiculo.NumeroTicketEstacionamento = this.veiculos.LastOrDefault().NumeroTicketEstacionamento + 1;
            else
                veiculo.NumeroTicketEstacionamento = 1;
            
            this.veiculos.Add(veiculo);
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover: ");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            /* IMPLEMENTADO! */
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.Placa.ToUpper() == placa.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                /* IMPLEMENTADO! */

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = this.precoInicial + precoPorHora * horas;

                // TODO: Remover a placa digitada da lista de veículos
                /* IMPLEMENTADO! */

                var VeiculoRemove = veiculos.FirstOrDefault(s => s.Placa.ToUpper() == placa.ToUpper());

                veiculos.Remove(VeiculoRemove);
                Console.WriteLine($"O veículo {VeiculoRemove.Modelo} {VeiculoRemove.Cor}, com emplacamento {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                /* IMPLEMENTADO! */

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"\t{veiculo.NumeroTicketEstacionamento} - {veiculo.Modelo} {veiculo.Cor} com emplacamento {veiculo.Placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
