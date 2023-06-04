function calcularIMC() {
    // Calcula o peso divido pela altura ao quadrado
    peso = document.getElementById("peso").value
    altura = document.getElementById("altura").value

    var imc = peso / (altura * altura)

    /* document.getElementById("imc").innerHTML = `O seu IMC é: ` + imc.toFixed(2) */
    var h3 = document.getElementById("resultado")

    if (h3) {
        h3.innerHTML = `O seu IMC é: ` + imc.toFixed(2)
    }
    else {
        var h3 = document.createElement("h3")
        h3.setAttribute("id", "resultado")
        h3.innerHTML = `O seu IMC é: ` + imc.toFixed(2)

        var form = document.getElementById("form")
        form.appendChild(h3)
    }

    if (imc < 18.5) {
        var resultado = "Abaixo do peso."
        criarh4(resultado)
    }
    else if (imc >= 18.5 && imc <= 24.9) {
        var resultado = "Peso normal."
        criarh4(resultado)
    }
    else if (imc >= 25 && imc <= 29.9) {
        var resultado = "Sobrepeso."
        criarh4(resultado)      
    }
    else if (imc >= 30 && imc <= 34.9) {
        var resultado = "Obesidade grau 1."
        criarh4(resultado)
    }
    else if (imc >= 35 && imc <= 39.9) {
        var resultado = "Obesidade grau 2."
        criarh4(resultado)
    }
    else {
        var resultado = "Obesidade grau 3 (mórbida)."
        criarh4(resultado)
    }
    // Histórico de imcs no historicos.html
    listaResultado.push(resultado)
    localStorage.setItem("historico", JSON.stringify(listaResultado))

}

function criarh4(resultado) {

    var h4 = document.getElementById("faixa")
    
    if (h4) {
        h4.innerHTML = resultado
    }
    else {
        var h4 = document.createElement("h4")
        h4.setAttribute("id", "faixa")
        h4.innerHTML = resultado
        
        var form = document.getElementById("form")
        form.appendChild(h4)
    }
}

let listaResultado = []

// Histórico de imcs no historicos.html
let lista = document.getElementById("historico")

const verificaStorage = localStorage.getItem("historico")

if (verificaStorage !== null) {
    const obj = JSON.parse(verificaStorage)
    listaResultado = obj
}

listaResultado.forEach(element => {
    lista.innerHTML += "<li>" + element + "</li>" + "<br>"
});


