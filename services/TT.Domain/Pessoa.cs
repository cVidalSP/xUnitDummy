namespace TT.Domain
{
    public abstract class Pessoa : Entidade
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; private set; }

        public Pessoa(string nome, string sobrenome, DateTime dataNascimento) 
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            CalcularIdade(dataNascimento);
        }

        private void CalcularIdade(DateTime dataNascimento) 
        {
            int idade;

            idade = DateTime.Now.Year - dataNascimento.Year;
            Idade = DateTime.Now.DayOfYear < dataNascimento.DayOfYear ? idade - 1 : idade;
        }
    }
}
