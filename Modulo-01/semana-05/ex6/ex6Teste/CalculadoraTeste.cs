using ex6.Classes;
namespace ex6Teste;

public class CalculadoraTeste
{
    [Fact]
    public void SomarTesteInt()
    {
        int resultado = Calculadora.Somar(5, 5);

        int esperado = 10;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void SomarTesteDouble()
    {
        double resultado = Calculadora.Somar(5.22, 5.22);

        double esperado = 10.44;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void SomarTesteFloat()
    {
        float resultado = Calculadora.Somar(5.225F, 5.225F);

        float esperado = 10.45F;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void SomarTesteDecimal()
    {
        decimal resultado = Calculadora.Somar(5.5M, 5.5M);

        decimal esperado = 11M;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void SomarTesteLong()
    {
        long resultado = Calculadora.Somar(50044, 50044);

        long esperado = 100088;

        Assert.Equal(resultado, esperado);
    }

    [Fact]
    public void SubtrairTesteInt()
    {
        int resultado = Calculadora.Subtrair(5, 5);

        int esperado = 0;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void SubtrairTesteDouble()
    {
        double resultado = Calculadora.Subtrair(5.22, 5.22);

        double esperado = 0;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void SubtrairTesteFloat()
    {
        float resultado = Calculadora.Subtrair(5.224F, 5.224F);

        float esperado = 0;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void SubtrairTesteDecimal()
    {
        decimal resultado = Calculadora.Subtrair(5.5M, 5.5M);

        decimal esperado = 0;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void SubtrairTesteLong()
    {
        long resultado = Calculadora.Subtrair(50044, 50044);

        long esperado = 0;

        Assert.Equal(resultado, esperado);
    }

    [Fact]
    public void MultiplicarTesteInt()
    {
        int resultado = Calculadora.Multiplicar(5, 5);

        int esperado = 25;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void MultiplicarTesteDouble()
    {
        double resultado = Calculadora.Multiplicar(5.05, 5.05);

        double esperado = 25.5025;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void MultiplicarTesteFloat()
    {
        float resultado = Calculadora.Multiplicar(5.20f, 5.20f);

        float esperado = 27.04f;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void MultiplicarTesteDecimal()
    {
        decimal resultado = Calculadora.Multiplicar(5.5M, 5.5M);

        decimal esperado = 30.25M;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void MultiplicarTesteLong()
    {
        long resultado = Calculadora.Multiplicar(5578, 1234);

        long esperado = 6883252;

        Assert.Equal(resultado, esperado);
    }
    
    
    [Fact]
    public void DividirTesteInt()
    {
        int resultado = Calculadora.Dividir(5, 5);

        int esperado = 1;

        Assert.Equal(resultado, esperado);
    }
    [Fact]
    public void DividirTesteDouble()
    {
        double resultado = Calculadora.Dividir(5.25, 5.25);

        double esperado = 1;

        Assert.Equal(resultado, esperado);
    }  
    [Fact]
    public void DividirTesteFloat()
    {
        float resultado = Calculadora.Dividir(5.224f, 5.224f);

        float esperado = 1.0f;

        Assert.Equal(resultado, esperado);
    }  
    [Fact]
    public void DividirTesteDecimal()
    {
        decimal resultado = Calculadora.Dividir(5.5M, 5.5M);

        decimal esperado = 1.0M;

        Assert.Equal(resultado, esperado);
    }  
    [Fact]
    public void DividirTesteLong()
    {
        long resultado = Calculadora.Dividir(556789, 123456);

        long esperado = 4;

        Assert.Equal(resultado, esperado);
    }    
}