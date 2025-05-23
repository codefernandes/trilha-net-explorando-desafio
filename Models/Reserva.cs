namespace DesafioProjetoHospedagem.Models
{
   public class Reserva
    {
        Suite suite;
        List<Pessoa> hospedes;
        public int DiasReservados { get; set; }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;

            hospedes = new List<Pessoa>();
        }

        public void CadastrarSuite(Suite suiteReserva)
        {
            suite = suiteReserva;
        }

        public void CadastrarHospedes(List<Pessoa> hospedesReseva)
        {
            hospedes = hospedesReseva;
        }

        public int ObterQuantidadeHospedes()
        {
            return hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (DiasReservados > 10)
            {

                decimal valorTotal = DiasReservados * suite.Valor;
                decimal desconto = valorTotal * 0.10m; // 10% de desconto

                return valorTotal - desconto;
            }
            else
            {
                return DiasReservados * suite.Valor;
            }

        }

        public void RegistrarReserva()
        {
            if (hospedes.Count > suite.Quantidade)
            {
                throw new Exception("Esta suie não comporta o numero de pessoas a serem hospedadas");
            }
        }
    }
}
