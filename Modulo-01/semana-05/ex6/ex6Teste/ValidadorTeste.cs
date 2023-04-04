using ex6.Classes;

public class ValidadorDeNumerosTeste
{
    [Fact]
    public void TesteEhNumeroPrimo()
    {
        bool esperado = ValidadorDeNumeros.EhNumeroPrimo(7);
        Assert.True(esperado);

    }

    [Fact]
    public void TesteParOuImpar()
    {
        string resultado = ValidadorDeNumeros.ParOuImpar(8);
        string esperado = "Par";
        Assert.Equal(esperado, resultado);

    }

    [Fact]
    public void TesteEhDiviselPor()
    {
        bool esperado = ValidadorDeNumeros.EhDivisivelPor(15, 3);
        Assert.True(esperado);

    }
}