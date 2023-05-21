function calcularIMC() {
    // Calcula o peso divido pela altura ao quadrado
    peso = document.getElementById("peso").value
    altura = document.getElementById("altura").value

    var imc = peso / (altura * altura)
    document.getElementById("imc").innerHTML = `O seu IMC é: ` + imc.toFixed(2)
 /*   document.createElement("h3").innerHTML = `O seu IMC é: ` + imc.toFixed(2)   */


}