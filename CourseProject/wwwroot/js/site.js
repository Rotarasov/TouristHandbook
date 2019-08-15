$('#submit').on('click', function (evt) {
    evt.preventDefault();
    if ($('#result').text() === "" && !$("#isAdmin").prop("checked")) {
        $.post('/viewtour', $('#calculateForm').serialize(), calculate);
    }
    else
        calculate();
})

calculate = () => {
    let people = $("input[type=number]").val();
    if (people.indexOf('.') > -1)
        $("#result").html("<p class='text-danger'>Number of people can't be fractional</p>");
    else {
        people = parseInt(people);
        if (people > 0) {
            let price = parseInt($("#price").html());
            let excursionsPrice = 0;
            $("input[type=checkbox]").each(function () {
                if ($(this).is(":checked")) {
                    excursionsPrice += parseInt($(this).attr("id")) * people;
                }
            })
            if (!excursionsPrice)
                excursionsPrice = 0;
            let total = price * people + excursionsPrice;
            $("#result").html(total + " $");
        }
        else {
            $("#result").html("<p class='text-danger'>Invalid number of people</p>");
        }
    }
}

$("#search").click(function () {
    let value = $("input[type=search]").val();
    let id = $("input[type=hidden]").val();
    let search = $("select").children("option:selected").val();
    $("#panel").load(`/home/${id}/${search}/${value}`);
})