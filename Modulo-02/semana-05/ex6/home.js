var mock = [
    {
        titulo: 'Trapiche',
        imagem: './imgs/trapiche.jpeg',
        subtitulo: 'Trapiche vazio'
    },
    {
        titulo: 'Trapiche',
        imagem: './imgs/trapiche2.jpeg',
        subtitulo: 'Trapiche com o Eros'
    },
    {
        titulo: 'Trapiche',
        imagem: './imgs/trapiche3.jpeg',
        subtitulo: 'Trapiche em família'
    },
    {
        titulo: 'Lugares',
        imagem: './imgs/lugares.jpeg',
        subtitulo: 'Austria?'
    },
    {
        titulo: 'Lugares',
        imagem: './imgs/lugares2.jpeg',
        subtitulo: 'Praga'
    },
    {
        titulo: 'Lugares',
        imagem: './imgs/lugares3.png',
        subtitulo: 'Londres'
    },
    {
        titulo: 'Amor',
        imagem: './imgs/amor.jpeg',
        subtitulo: 'Na cama'
    },
    {
        titulo: 'Amor',
        imagem: './imgs/amor2.jpeg',
        subtitulo: 'Na cama 2'
    },
    {
        titulo: 'Amor',
        imagem: './imgs/amor3.jpeg',
        subtitulo: 'Beijo na testa'
    }
]
sessionStorage.setItem("mock", JSON.stringify(mock));
const section = document.getElementById("section");

function pesquisar() {
    section.innerHTML = '';
    const recuperado = sessionStorage.getItem("mock");
    const parseado = JSON.parse(recuperado);
    const pesquisa = document.getElementById("pesquisa").value;

    parseado.forEach(element => {
        if (element.titulo.includes(pesquisa) || element.subtitulo.includes(pesquisa)) {
            const div = document.createElement("div");

            const h2 = document.createElement("h2");
            h2.innerHTML = element.titulo;
            div.appendChild(h2);
            

            const img = document.createElement("img");
            img.setAttribute('src', element.imagem)
            div.appendChild(img);
            

            const h3 = document.createElement("h3");
            h3.innerHTML = element.subtitulo;
            div.appendChild(h3);
          

            section.appendChild(div)
        }
    })
}