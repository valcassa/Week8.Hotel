////Esercizio singolo: Creare una pagina LoginLa pagina Login contiene una form per il login con i seguenti campi:
////- username
////    - password
////    - tasto loginIl tasto login � inizialmente disabilitato.
////Quando l'utente riempie entrambi i campi, il tasto login viene abilitato.
////Cliccando su login, vengono salvati i dati sul local storage, la form scompare e compare un tasto Logout.Al caricamento della pagina, bisogna verificare se l'utente � loggato o meno (ovvero se ci sono dati nel localstorage).
////Se lo �, l'utente vede solo il tasto logout.
////Se non lo �, ricompare la form e il tasto login disabilitato.Se l'utente clicca logout, la form con il tasto di login disabilitato ricompaiono, il tasto logout � nascosto e il localstorage viene svuotato.

////Sull'hotel: L'utente riempie entrambi i campi di login.
////Cliccando su login, vengono salvati i dati sul local storage e non deve essere  pi� possibile fare login.
////(quindi per esempio la form e il tasto effettua login scompaiono, il tasto effetua login non � pi�
////cliccabile(scompare o � disabilitato)... in base a come avete strutturato voi la cosa).
////Ricaricando la pagina o andando in una delle altre pagine, se l'utente � loggato non deve essere possibile fare login.



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