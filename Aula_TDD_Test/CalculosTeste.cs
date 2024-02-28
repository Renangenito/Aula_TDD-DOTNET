using Aula_TDD;

namespace Aula_TDD_Test
{
    public class CalculosTeste
    {
        [Fact]
        public void DividirDoisNumeros()
        {
            //Arrange
            int expectativa = 1;

            int numero1 = 2;
            int numero2 = 2;

            //act
            int retorno = new Calculos().Dividir(numero1, numero2);

            //Assert
            Assert.Equal(expectativa, retorno);
        }
        [Fact]
        public void DividirDoisNumerosPorZero()
        {
            //Arrange
            string expectativa = "Attempted to divide by zero.";

            int numero1 = 2;
            int numero2 = 0;

            var ex = Record.Exception(() => new Calculos().Dividir(numero1, numero2));

            //act
            if(!(ex is DivideByZeroException))
                Assert.True(false);

            //Assert
            Assert.Equal(expectativa, ex.Message);
        }

        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange
            int expectativa = 30;

            int numero1 = 10;
            int numero2 = 20;

            //act
            int retorno = new Calculos().Somar(numero1, numero2);

            //Assert
            Assert.Equal(expectativa, retorno);
        }

        [Fact]
        public void SomarOutrosDoisNumeros()
        {
            //Arrange
            int expectativa = 10;

            int numero1 = 4;
            int numero2 = 6;

            //act
            int retorno = new Calculos().Somar(numero1, numero2);

            //Assert
            Assert.Equal(expectativa, retorno);
        }
        [Fact]
        public void SomarDoisNumerosNegativos()
        {
            //Arrange
            int expectativa = -10;

            int numero1 = -4;
            int numero2 = -6;

            //act
            int retorno = new Calculos().Somar(numero1, numero2);

            //Assert
            Assert.Equal(expectativa, retorno);
        }

        [Theory]
        [InlineData(10, 40, 50)]
        [InlineData(-10, -40, -50)]
        [InlineData(1, 28, 29)]
        public void SomarNumeros(int numero1, int numero2, int expectativa)
        {
            //Arrange

            //act
            int retorno = new Calculos().Somar(numero1, numero2);

            //Assert
            Assert.Equal(expectativa, retorno);
        }
    }
}