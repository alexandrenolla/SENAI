
// Função é um bloco de execuções estruturadas que podem ser disparadas a partir de uma evocação, tendo ou não, a declaração de parâmetros, nos quais serão computados pelo passo-a-passo de dentro da função, retornando (ou não) o resultado.

function calcularIMC(peso, altura) {
    // Calcula o peso divido pela altura ao quadrado
    var resultado = peso / (altura * altura)
    // Retorna o resultado abreviado em duas casas decimais
    return resultado.toFixed(2)
}

// Chama a função passando os valores de peso e altura como parâmetro
console.log("O seu IMC é: " + calcularIMC(78, 1.78))




