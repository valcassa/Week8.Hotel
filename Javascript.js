// JavaScript source code
////- Al caricamento della pagina Home, viene mostrato il messaggio: benvenuto.
//- In basso a destra, in tutte le pagine
//inserire un pulsante che fa comparire una form di login(con i campi username e password,
//    un tasto login(per inviare i dati) e un tasto chiudi(che chiude, fa sparire, la form)
//nell'angolo in basso a destra.

window.open(url, windowName, "height=200,width=200");

console.log("Benvenuto")



function Login() {

    let usernameInput = document.getElementsByClassName("user")
    let passwordInput = document.getElementById("password")
    let button = document.getElement("Invia")
    if (usernameInput.value != "") {
        button.style.visibility = "visible";
    }

    function windowClose() {
        newWindow.close();
    }
}