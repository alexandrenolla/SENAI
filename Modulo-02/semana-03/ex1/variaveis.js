// string - Armazena valores em tempo.
var nome = "Henrique Douglas"

// number - Armazena valores em número, independente de serem inteiros ou flutuantes.
var idade = 24
var salario = 1300.50

// Boolean - Operador lógico
var estaDeRecuperacao = false

// Objeto - Coleção, ou variável iterável. Armazena um grupo de valores separados em pares de chave - valor.

var aluno = {
    nome: "Henrique Douglas",
    idade: 24,
    cidade: "Floripa",
    estado: "SC",
    nomeCachorro: null
}

aluno.estado = "CE"

// Array - Também uma coleção ou variável iterável.  Armazena os valores por índice de posição.

var numerosSorteados = [12,15,45,23,22]

console.log(numerosSorteados[4])

numerosSorteados.push(999)

console.log(numerosSorteados)

// null - Armazena o espaço vazio.

var comissao = null

comissao = 200
console.log(comissao)
