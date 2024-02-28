using Aula_TDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_TDD_Test
{
    public class ClienteTest
    {
        
        [Fact]
        public void UsuarioMaiorDeIdade()
        {
            //Arrange
            bool expectativa = true;
            Cliente cliente = new Cliente();
            cliente.Nome = "Renan";
            cliente.Idade = 28;

            //act
            bool atual = cliente.MaiorDeIdade();

            //Assert
            Assert.Equal(expectativa, atual);
        }

        [Fact]
        public void UsuarioMenorDeIdade()
        {
            //Arrange
            bool expectativa = false;
            Cliente cliente = new Cliente();
            cliente.Nome = "Samuel";
            cliente.Idade = 2;

            //act
            bool atual = cliente.MaiorDeIdade();

            //Assert
            Assert.Equal(expectativa, atual);
        }

        [Theory]
        [MemberData(nameof(ListaCliente))]
        public void Os_campos_de_cliente_tem_cnteudo(Cliente cliente)
        {
            //Arrange


            //act


            //Assert
            Assert.NotEmpty(cliente.Nome);
            Assert.NotEmpty(cliente.Email);
        }
        public static IEnumerable<object[]> ListaCliente => new[]
        {
            new [] { new Cliente { Id = 1, Nome = "Renan", Email = "renan@email.com", Idade = 28} },
            new [] { new Cliente { Id = 2, Nome = "Daniel", Email = "daniel@email.com", Idade = 38} },
            new [] { new Cliente { Id = 3, Nome = "Fernando", Email = "fernando@email.com", Idade = 18} },
            new [] { new Cliente { Id = 4, Nome = "Claudio", Email = "claudio@email.com", Idade = 8} },
        };

    }
}
