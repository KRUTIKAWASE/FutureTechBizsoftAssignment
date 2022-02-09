$(document).ready(function () {
    GetEmpdetails();
    getdepartmentlist();
    getcity();
    getEmpReport();
    getEmpDepReport();
});

var saveEmployee = function () {
    var first_name = $("#txtFirstName").val();
    var middle_name = $("#txtMiddleName").val();
    var last_name = $("#txtLastName").val();
    var full_name = $("#txtFirstName").val() + " " + $("#txtMiddleName").val() + " " + $("#txtLastName").val();
    var dob = $("#txtDOB").val();
    var join_date = $("#txtJoinDate").val();
    var city_code = $("#ddlCity").val();
    var dept_code = $("#ddlDept").val();
    var emp_code = $("#txtEmp").val();
    var salary = $("#txtSal").val();

    var model = {
        FIRST_NAME: first_name, MIDDLE_NAME: middle_name, LAST_NAME: last_name, FULL_NAME: full_name, DOB: dob, JOIN_DATE: join_date, CITY_CODE: city_code, DEPT_CODE: dept_code, EMP_CODE: emp_code, SALARY: salary
    };

    $.ajax({
        url: "/EmployeeMaster/saveEmployee",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",
        success: function (response) {
            
            alert("Record Submitted Successfully");
        }
    });
}


var GetEmpdetails = function () {
    $.ajax({
        url: "/EmployeeDetail/GetEmpdetails",
        method: "post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#Emp_Mas_Tbl tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.EMP_CODE + "</td> <td>" + elementValue.FIRST_NAME + "</td> <td>" + elementValue.MIDDLE_NAME + "</td><td>" + elementValue.LAST_NAME + "</td><td>" + elementValue.FULL_NAME + "</td><td>" + elementValue.DOB_String + "</td><td>" + elementValue.JOINDATE_String + "</td><td>" + elementValue.CITY_NAME + "</td><td>" + elementValue.DEPT_NAME + "</td><td>" + elementValue.SALARY + "</td></tr>";
            });
            $("#Emp_Mas_Tbl").append(html);

        }
    })
}

var getdepartmentlist = function () {
    $.ajax({
        url: "/EmployeeDetail/getdepartment",
        method: "post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#ddlDept").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<option value='" + elementValue.DEPT_CODE + "'>" + elementValue.DEPT_NAME + " </option>"
            });
            $("#ddlDept").append(html);
        }
    })
}

var getcity = function () {
    $.ajax({
        url: "/EmployeeDetail/getcity",
        method: "post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#ddlCity").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<option value='" + elementValue.CITY_CODE + "'>" + elementValue.CITY_NAME + " </option>"
            });
            $("#ddlCity").append(html);
        }
    })
}
var getEmpReport = function () {
    $.ajax({
        url: "/EmployeeDetail/GetEmpReport",
        method: "post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#Emp_Report tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.EMP_CODE + "</td> <td>" + elementValue.FULL_NAME + "</td><td>" + elementValue.SALARY + "</td></tr>";
            });
            $("#Emp_Report").append(html);

        }
    })
}
var getEmpDepReport = function () {
    $.ajax({
        url: "/EmployeeDetail/GetEmpDepReport",
        method: "post",
        //data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#Emp_DepReport tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.DEPT_NAME + "</td><td>" + elementValue.TotalEmp + "</td></tr>";
            });
            $("#Emp_DepReport").append(html);

        }
    })
}
