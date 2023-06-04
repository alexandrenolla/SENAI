function mostrarStorage() {

    const obj = {
        chave1: "valor1",
        chave2: "valor2",
        chave3: "valor3"
    }
    
    localStorage.setItem("obj", JSON.stringify(obj))
    const recuperado = localStorage.getItem("obj")
    const parseado = JSON.parse(recuperado)

    const h4 = document.getElementById("h4")

    // no console
    console.log(parseado)
    // na página
    for (chave in parseado) {          
        h4.innerHTML += chave + ": " + parseado[chave] + "<br>"
    }                                //objeto[chave] retorna o valor da chave
}
window.onload = mostrarStorage