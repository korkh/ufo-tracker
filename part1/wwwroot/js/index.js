$(function () {
    hentAlle();
});

function hentAlle() {
    $.get("Info/HentAlle", function (infoer) {
        console.log(infoer)
        formaterInfoer(infoer);
    });
}

function formaterInfoer(infoer) {
    let ut = "<table class='table table-striped'>" +
        "<tr>" +
        "<th>Date/Time</th><th>Country</th><th>Shape</th><th>Duration</th><th>Describtion</th>" +
        "</tr>";
    for (let info of infoer) {
        ut += "<tr>" +
            "<td>" + info.date + "</td>" +
            "<td>" + info.country + "</td>" +
            "<td>" + info.shape + "</td>" +
            "<td>" + info.duration + "</td>" +
            "<td>" + info.describtion + "</td>" +
            "<td> <a class='btn btn-primary' href='edit.html?id=" + info.id + "'>Edit</a></td>" +
            "<td> <button class='btn btn-danger' onclick='remove(" + info.id + ")'>Remove</button></td>" +
            "</tr>";
    }
    ut += "</table>";
    console.log(ut)
    $("#infoene").html(ut);
}

function remove(id) {
    const url = "Info/Remove?id=" + id;
    $.get(url, function (OK) {
        if (OK) {
            window.location.href = 'index.html';
        }
        else {
            $("#feil").html("Feil i db - prøv igjen senere");
        }

    });
};