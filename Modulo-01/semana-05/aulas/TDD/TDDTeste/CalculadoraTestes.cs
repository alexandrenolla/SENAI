using TDD.Classes;
namespace TDDTeste;

public class CalculadoraTestes
{
    [Fact] // Data Annotation de Teste Unitário
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
    [Fact(DisplayName = "Nome do Teste: Teste para somar decimais")]
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

    [Theory] // Data Annotation de teste unitário para receber massa de dados por parâmetros
    [InlineData(5, 7, 12)] // Teste com tipo de dados únicos, passados aqui na mesma linha
    [InlineData(3, 2, 5)] 
    [InlineData(-5, -3, -8)] 
    public void TestarSomaInteirosTheory(int num1, int num2, int resultadoEsperado)
    {   
        // quero fazer
        int resultado = Calculadora.Somar(num1, num2);
        // espero receber
        int esperado = resultadoEsperado;
        // validação/teste
        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [Trait("Categoria", "Somar")] // Filtro de nomeação para poder chamar apenas testes específicos. (Chave,valor)
    [InlineData(9, 3)]
    [InlineData(25, 5)]
    [InlineData(27, 2)]
    public void TestarDivisivelPorTheory(int dividendo, int divisor)
    {
        bool resultado = Calculadora.DivisivelPor(dividendo, divisor);
        
        Assert.True(resultado);
    }

    [Theory] // Recebe massa de dados recebidos pelo teste por parâmetros
    [MemberData(nameof(ListaNumeros))] // Teste com tipo de dados enumerables, passados por listas ou arrays.
    public void TestarSomaComNumeroInteirosMemberData(ListaNumeros lista)
    {
        int resultado = Calculadora.Somar(lista.num1, lista.num2);

        Assert.Equal(lista.esperado, resultado);
    }

    public static IEnumerable<object[]> ListaNumeros()
    {
        List<object[]> listageral = new List<object[]>();
        
        listageral.Add(new[] {new ListaNumeros() {num1 = 5, num2 = 5, esperado = 10}});

        listageral.Add(new[] {new ListaNumeros() {num1 = 3, num2 = 8, esperado = 11}});

        return listageral;
    }
}