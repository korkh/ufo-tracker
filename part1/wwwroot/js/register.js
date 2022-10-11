function registerInfo() {
    const info = {
        date: $("#date").val(),
        country: $("#country").val(),
        shape: $("#shape").val(),
        duration: $("#duration").val(),
        describtion: $("#describtion").val(),
    }
    console.log(info)
    $.post("Info/Registrer", info, function (OK) {
        if (OK) {
            window.location.href = 'index.html';
        }
        else {
            $("#feil").html("Feil i db - prøv igjen senere");
        }
    });
};