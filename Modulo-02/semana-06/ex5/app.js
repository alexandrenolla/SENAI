function listaInvertida() {
    let lista = document.getElementById("lista");


    fetch('https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking').then(resp => resp.json()) //a resposta retorna outra promessa, que quando resolve, chama o resultado no próximo then
    .then(result => {
        const filtrado = result
        .filter(element => !element.nome.includes("A"))
        .map(element => element.nome);

        lista.innerText = filtrado.join(", ");
    })
}

export { listaInvertida }