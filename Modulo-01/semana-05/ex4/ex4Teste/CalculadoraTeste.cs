using ex4.Classes;
namespace ex4Teste;

public class CalculadoraTeste
{
    [Fact]
    public void SomarTeste()
    {
        int resultado = Calculadora.Somar(5, 5);

        int esperado = 10;

        Assert.Equal(resultado, esperado);
    }

    [Fact]
    public void SubtrairTeste()
    {
        int resultado = Calculadora.Subtrair(5, 5);

        int esperado = 0;

        Assert.Equal(resultado, esperado);
    }

    [Fact]
    public void MultiplicarTeste()
    {
        int resultado = Calculadora.Multiplicar(5, 5);

        int esperado = 25;

        Assert.Equal(resultado, esperado);
    }
    
    [Fact]
    public void DividirTeste()
    {
        int resultado = Calculadora.Dividir(5, 5);

        int esperado = 1;

        Assert.Equal(resultado, esperado);
    }  
}