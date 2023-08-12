using System;
using TT.Domain;
using Xunit;

namespace TT.Tests
{
    public class AlunoTest
    {
        [Fact(DisplayName = "Dia do nascimento for maior que atual")]
        [Trait("Categoria", "Idade")]
        public void CalcularIdade_DiaNascimentoForMaiorQueAtual_RetonarIdadeMenosUm() 
        {
            //Arrange

            Pessoa pessoa = new Aluno("Aluno", "Teste", DateTime.Parse("23/08/1999"));

            //Assert
            Assert.Equal(23, pessoa.Idade);
        }

        [Fact(DisplayName = "Dia do nascimento for menor que atual")]
        [Trait("Categoria", "Idade")]
        public void CalcularIdade_DiaNascimentoForMenorQueAtual_RetornarIdade()
        {
            //Arrange

            Pessoa pessoa = new Aluno("Aluno", "Teste", DateTime.Parse("10/08/1999"));

            //Assert
            Assert.Equal(24, pessoa.Idade);
        }
    }
}