function listaInvertida() {
    let lista = document.getElementById("lista");
    let listaInvertida = document.getElementById("listaInvertida");
    let list = []

    fetch('https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking').then(resp => resp.json()) //a resposta retorna outra promessa, que quando resolve, chama o resultado no próximo then
    .then(result => {
        result.forEach(element => {
            list.push(JSON.stringify(element));
        });
        lista.innerText = list; //lista na ordem

        let itensInvertidos = ''
        for (let i = list.length - 1; i >= 0; i--) {
            itensInvertidos += list[i] +'\n';
        }
        listaInvertida.innerText = itensInvertidos; //lista invertida
    })
    .catch(error => {
        console.log('Error:', error);
    })
}

export { listaInvertida }