$(function () {
    // hent info med info-id fra url og vis denne i skjemaet

    const id = window.location.search.substring(1);
    const url = "Info/HentEn?" + id;
    $.get(url, function (info) {
        $("#id").val(info.id); // må ha med id inn skjemaet, hidden i html
        $("#date").val(info.date);
        $("#country").val(info.country);
        $("#shape").val(info.shape);
        $("#duration").val(info.duration);
        $("#describtion").val(info.describtion);
    });
});

function editInfo() {
    const info = {
        id: $("#id").val(), // må ha med denne som ikke har blitt endret for å vite hvilken info som skal endres
        date: $("#date").val(),
        country: $("#country").val(),
        shape: $("#shape").val(),
        duration: $("#duration").val(),
        describtion: $("#describtion").val(),
    };

    $.post("Info/Edit", info, function (OK) {
        if (OK) {
            window.location.href = 'index.html';
        }
        else {
            $("#feil").html("Feil i db - prøv igjen senere");
        }
    });
}