$(document).ready(function () {
    getCityList();
});

var saveCity = function () {
    var city_name = $("#txtName").val();
    var state_name = $("#txtState").val();
    var country_name = $("#txtCountry").val();
    var sort_no = $("#txtSort").val();

    var model = {
        CITY_NAME: city_name, STATE_NAME: state_name, COUNRTY_NAME: country_name, SORT_NO: sort_no,
    };

    $.ajax({
        url: "/CityMaster/saveCity",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        success: function (response) {
            alert("Record Successfully Submitted");
            getCityList();
        }
    });
}

var getCityList = function () {
    $.ajax({
        url: "/CityMaster/getCityList",
        method: "post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#City_Mas_Tbl tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.CITY_CODE + "</td> <td>" + elementValue.CITY_NAME + "</td><td>"
                    + elementValue.STATE_NAME + "</td><td>" + elementValue.COUNRTY_NAME + "</td><td>" + elementValue.SORT_NO + "</td></tr>";
            });
            $("#City_Mas_Tbl").append(html);
        }
    })
}
