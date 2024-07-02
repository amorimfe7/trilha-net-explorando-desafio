namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int nmrHospedes = hospedes.Count();
            int capacidadeSuite = Suite.Capacidade;

            if (nmrHospedes <= capacidadeSuite)
            {
                Hospedes = hospedes;
                Console.WriteLine("Cadastro de Hospedes realizado com sucesso.");
            }
            else
            {
                throw new ArgumentException("A Suite não comporta a quantidade de hospedes indicado");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int qtdHospedes = Hospedes.Count();

            return qtdHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            int diasReservados = DiasReservados;
            decimal valorDiaria = Suite.ValorDiaria;

            decimal valorTotal = diasReservados*valorDiaria;

            if (diasReservados >= 10)
            {
                valorTotal *= 0.9M;
                Console.WriteLine("Devido a quantidade de diárias, você ganhou 10% de Desconto!");
            }

            return valorTotal;
        }
    }
}