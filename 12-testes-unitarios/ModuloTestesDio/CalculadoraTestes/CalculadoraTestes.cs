using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;
        
        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;
        
        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarTrue()
    {
        // arrange
        int num = 4;

        // act
        bool resultado = _calc.EhPar(num);

        // assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] {2, 4})]
    [InlineData(new int[] {6, 8, 10})]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // act / assert (juntos!)
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}