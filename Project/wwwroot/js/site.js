﻿let player = "";
const viewBagTeam = JSON.parse(team.replace(/&quot;/g, '"'));
const country = ["США", "Россия", "Италия"];

function getGender(value) {
    if (value === "Мужской") {
        value = "Женский";
    } else { value = "Мужское" }
    return value;
}


$('.btn-change').click(function() {
    player = $(this).parent('td').siblings('td').map(function(i, td) {
        return $(td).text();
    });
    let optionTeam = `<option selected>${player[5]}</option>`;
    let optionCountry = `<option selected>${player[6]}</option>`;


    for (let i = 0; i < Object.keys(viewBagTeam).length; i++) {
        if (viewBagTeam[i].Name !== player[5]) {
            optionTeam += `<option value="${viewBagTeam[i].Id}">${viewBagTeam[i].Name}</option>`;
        }
    };
    for (let i = 0; i < country.length; i++) {
        if (country[i] !== player[6]) {
            optionCountry += `<option value="${country[i]}">${country[i]}</option>`;
        }
    };



    const addTable = `<form id="formAction" action="Home/Edit" method="POST">
                    <div class="form-group"><input name="Id" type="hidden" value="${player[0]}" />
                        <label class="col-form-label col-6">Имя</label>
                        <input name="FirstName" type="text" class="form-control col-12" placeholder="Имя" value="${player[1]}" />
                        <label class="col-form-label col-6">Фамилия</label>
                        <input name="LastName" type="text" class="form-control col-12" placeholder="Введите фамилию" value="${player[2]}" />
                        <label class="col-form-label col-6">Пол</label>
                        <select name="Gender" type="text" class="form-control col-12" placeholder="Пол">
                            <option value="${player[3]}" selected>${player[3]}</option>
                            <option value="${getGender(player[3])}">${getGender(player[3])}</option>
                        </select>
                        <label class="col-form-label col-6">Дата рождения</label>
                        <input name="BirthDay" type="date" class="form-control col-12" placeholder="Дата рождения" value="${player[4]}" />
                        <label class="col-form-label col-6">Команда</label>
                        <select name="TeamId" type="text" class="form-control col-12" placeholder="Введите команду">${optionTeam}</select>
                        <label class="col-form-label col-6">Страна</label>
                        <select name="Country" type="text" class="form-control col-12" placeholder="Введите страну">${optionCountry}</select>
                    </div>
                            <div class="row">
                                <div class="form-group col-8">
                                    <input type="submit" id="btnSub" value="Изменить" class="btn btn-primary"/>
                                </div>
                                <div class="form-group col-4">
                                    <input type="button" id="btnClose" class="btn btn-danger" value="Закрыть">
                                </div>
                            </div>
                    </form>`;

    $('#form-change').html(addTable).addClass("col-sm").css({ 'margin-top': '3%' });
});

$('#btnClose').click(function() {
    $('#form-change').empty();
});