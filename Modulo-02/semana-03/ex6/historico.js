
// Histórico de imcs no historicos.html
let lista = document.getElementById("historico")




const verificaStorage = localStorage.getItem("historico")
let listaResultado = []
if (verificaStorage !== null) {
    const obj = JSON.parse(verificaStorage)
    listaResultado = obj
}

const html = listaResultado.map(r => "<h4>" + r + "</h4>")
lista.innerHTML = html

