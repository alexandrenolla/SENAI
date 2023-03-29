using TDD.Classes;
namespace TDDTeste;

public class CalculadoraTestes
{
    [Fact]
    public void TestarSomaComNumeroInteiros()
    {   // recebe o resultado
        int resultado = Calculadora.Somar(5, 5);

        // resultado a ser comparado
        int esperado = 10;

        // string nome = "";

        // executa a comparação
        Assert.Equal(resultado, esperado);
        //Assert.Contains(10, new List<int>(){10, 20, 15, 30});
        //Assert.InRange(10,5,30);
        //Assert.Empty(nome);
    }
    [Fact(DisplayName = "Teste para somar decimais")]
    public void TestarSomaComNumeroDecimais()
    {   // recebe o resultado
        decimal resultado = Calculadora.Somar(5.2M, 5.8M);

        // resultado a ser comparado
        decimal esperado = 11M;

        // string nome = "";

        // executa a comparação
        Assert.Equal(resultado, esperado);
        //Assert.Contains(10, new List<int>(){10, 20, 15, 30});
        //Assert.InRange(10,5,30);
        //Assert.Empty(nome);
    }

    //[Fact]
    [Fact (Skip="Teste não implementado")]
    public void TestarMetodoDivisivelPor()
    {
       bool result = Calculadora.DivisivelPor(4, 2);

        Assert.True(result);
        //Assert.False(result);
    }
}