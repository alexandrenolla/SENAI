function movimento() {
    const div = document.getElementById("div");
    let eixoX = 0;
    let eixoY = 0;

    const andando = setInterval(function() {
        eixoX += 10
        div.style.marginLeft = eixoX + "px"
    }, 100)

    setTimeout(function() {
        clearInterval(andando)
        const descendo = setInterval(function() {
            eixoY += 10
            div.style.marginTop = eixoY + "px"
            div.style.backgroundColor = "pink"
        }, 100)  
        setTimeout(function() {
            clearInterval(descendo)
        }, 10000) 
    }, 5000)
}
window.onload = movimento
