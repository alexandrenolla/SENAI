function calcularIMC(peso, altura) {
    // Calcula o peso divido pela altura ao quadrado
    var resultado = peso / (altura * altura)
    // Retorna o resultado abreviado em duas casas decimais
    return resultado.toFixed(2)
}

// Chama a função passando os valores de peso e altura como parâmetro
console.log("O seu IMC é: " + calcularIMC(78, 1.78))




