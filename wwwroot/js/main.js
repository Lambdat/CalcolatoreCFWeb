//Script all'avvio del documento
$(document).ready(function () {


    //Carichiamo all'interno degli appositi div(selettore che punta i vari id interessati)
    //il contenuto dei documenti html presenti in wwwroot

    $("#calcolatore").load("html/calcolatore.html");
    $("#elenco").load("html/elenco.html");

    //Andiamo prima a nascondere al primo avvio tutti i div della classe "sezione"
    $(".sezione").hide();


    //All'evento di click del bottone avente classe "bottoneMenu"
    $(".bottoneMenu").click(function () {

        //Andiamo a prendere il contenuto dell'attributo custom "divDaAprire" e le mettiamo in una variabile
        let divDaAprire = $(this).attr("divDaAprire");


        //Ogni qualvolta verrà avviata questa funzione (al click) andremo di nuovo a nascondere i div di classe "sezione"
        $(".sezione").hide();

        //Con un semplice controllo sulla variabile "divDaAprie" andiamo a vedere quale div andare ad aprire appunto
        switch (divDaAprire)
        {

            case "calcolatore":

                $("#calcolatore").show();

                break;

            case "elenco":

                $("#elenco").show();

                break;

        }

    });




});