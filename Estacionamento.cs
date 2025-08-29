namespace DesafioFundamentos;

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

    public void AdicionarVeiculo()
    {
        Console.Write("Digite a placa do veículo para estacionar: ");
        string placa = (Console.ReadLine() ?? "Não pode ser nulo").ToUpper() ;
        if (veiculos.Any(x => x.ToUpper() == placa))
        {
            Console.WriteLine($"O veículo com placa: {placa} já está estacionado.");
        }
        else 
        { 
            veiculos.Add(placa);
            Console.WriteLine($"O veículo com a placa {placa} foi estácionado com sucesso.");
        }
        }
        

    

    public void RemoverVeiculo()
    {
        string placa = "";
        Console.Write("Digite a placa do carro que gostaria de retirar: ");
        placa = (Console.ReadLine() ?? "Não pode ser nulo").ToUpper();

        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            int horas = 0;
            decimal valorTotal = 0;
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            horas = Convert.ToInt32(Console.ReadLine() ?? "0");
            valorTotal = precoInicial + precoPorHora * horas;

            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são: ");
            foreach (var veiculo in veiculos)
                Console.WriteLine(veiculo);
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
