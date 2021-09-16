// JavaScript source code
function save() {
    let InseredUsername = document.getElementById("username").value // recupero il valore inserito dall'user
    let InseredPassword = document.getElementById("password").value

    localStorage.setItem('username', InseredUsername) // salvataggio key e value
    localStorage.setItem('password', InseredPassword)
}
//Verifica inserimento, form scompare e compare il log
function change() {
    let inputs = document.querySelectorAll("input[type='text'], input[type=submit]")
    let loginButton = document.querySelector("input[type=submit")

    for (let i = 0; i < inputs.length; i++) {
        if (inputs[i].value == "") {
            loginButton.disabled = "true"
        }
        loginButton.disabled = false;
    }
}

function hideForm() {
    let form = document.getElementById("loginForm");
    form.style.display = "none";

    let logoutButton = document.getElementById("logOutButton")
    logoutButton.style.display = "";
}

function checkLoggedUser() {
    let storedUsername = localStorage.getItem('username')
    let storedPassword = localStorage.getItem('password')

    if (storedUsername != null && storedPassword != null) {
        hideForm()

    }
 
    }

function logOut() {
    localStorage.clear()

    let form = document.getElementById("loginForm");
    form.style.display = "";


    let logoutButton = document.getElementById("logOutButton")
    logoutButton.style.display = "none"
}