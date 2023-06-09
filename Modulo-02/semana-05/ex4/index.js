function confLogin() {
    const email = document.getElementById("email").value;
    const pass = document.getElementById("password").value;

    const verificaStorage = localStorage.getItem("login");
    if (verificaStorage != null) {

        const parseado = JSON.parse(verificaStorage)
        if (parseado.some (obj => obj.email === email && obj.pass === pass)) {

            window.location.href = './home.html'
        }
        else {
            window.alert("Usuário não cadastrado.")
        }
    }
    else {
        window.alert("Nenhum usuário cadastrado.")
    }   
}

