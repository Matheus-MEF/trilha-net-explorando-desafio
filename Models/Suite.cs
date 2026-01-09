namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }
// logo abaixo vemos um construtor que recebe 3 parâmetros, ele serve para inicializar as propriedades da classe Suite quando um novo objeto é criado.
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
// abaixo temos as propriedades da classe Suite, que representam os atributos de uma suíte em um sistema de hospedagem.
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}