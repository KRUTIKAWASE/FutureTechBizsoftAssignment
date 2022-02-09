$(document).ready(function () {
    getCurrentEmployee();
    getEmployee();
});

var saveSalary = function () {
    var emp_code = $("#ddlEmp").val();
    var month = $("#ddlMonth").val();
    var salary = $("#txtSalary").val();
    var comments = $("#txtComment").val();
    
    var model = {
        EMP_CODE: emp_code, MONTH: month, SALARY: salary, COMMENTS: comments
    };

    $.ajax({
        url: "/Salary/saveSalary",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        success: function (response) {
            alert("Record Successfully Submitted");
            getCurrentEmployee();
        }
    });
}

var getCurrentEmployee = function () {
    $.ajax({
        url: "/Salary/getCurrentEmployee",
        method: "post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#Emp_Salary_Tbl tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.SEQ_NO + "</td><td>" + elementValue.FULL_NAME + "</td><td>" + elementValue.MONTH + "</td><td>" + elementValue.SALARY + "</td><td>" + elementValue.COMMENTS + "</td></tr>";
            });
            $("#Emp_Salary_Tbl").append(html);

        }
    });
}

var getEmployee = function () {
    $.ajax({
        url: "/Salary/getEmployee",
        method: "post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#ddlEmp").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<option value='" + elementValue.EMP_CODE + "'>" + elementValue.FULL_NAME + " </option>"
            });
            $("#ddlEmp").append(html);
        }
    });
}

