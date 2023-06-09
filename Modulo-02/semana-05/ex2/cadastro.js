let logins = []
const verificaStorage = sessionStorage.getItem("login");    
if (verificaStorage != null) {
    const parseado = JSON.parse(verificaStorage)
    logins = parseado
}

function confPass() {
    const email = document.getElementById("email").value;
    const pass = document.getElementById("pass").value;
    const confpass = document.getElementById("confpass").value;

    if (pass.length < 10 ) {
        erro.innerHTML = "A senha deve ter no mínimo 10 caracteres."
    }
    else if (pass !== confpass) {
        window.alert("As senhas não batem.")
    }
    else if (logins.some (obj => obj.email === email)) {
        window.alert("Email já cadastrado.")
    }
    else {
        logins.push({email: email, pass: pass});

        sessionStorage.setItem("login", JSON.stringify(logins));
        window.location.href = 'index.html'
    }
}

