var valueToIncrease = 1000;

function Employee(firstName, lastName, salary) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.salary = salary;
}

function IncreaseEmployeeSalary(employee) {
    employee.salary += valueToIncrease;
}

function ShowEmployeeDetails() {
    var employee = new Employee("Harold", "Buenaventura", 50000);

    IncreaseEmployeeSalary(employee);

    var table = document.getElementById("table");
    if(table != null)
        table.parentNode.removeChild(table);

    var tb = document.createElement("TABLE");
    tb.setAttribute("id", "table");
    document.body.appendChild(tb);

    var tr = document.createElement("TR");
    tr.setAttribute("id", "tr1");
    document.getElementById("table").appendChild(tr);

    var thF = document.createElement("TH");
    tb = document.createTextNode("Firstname");
    thF.appendChild(tb);
    document.getElementById("tr1").appendChild(thF);

    var thL = document.createElement("TH");
    tb = document.createTextNode("Lastname");
    thL.appendChild(tb);
    document.getElementById("tr1").appendChild(thL);

    var thS = document.createElement("TH");
    tb = document.createTextNode("Salary");
    thS.appendChild(tb);
    document.getElementById("tr1").appendChild(thS);
    
    tr = document.createElement("TR");
    tr.setAttribute("id", "tr2");
    document.getElementById("table").appendChild(tr);

    var td = document.createElement("TD");
    tb = document.createTextNode(employee.firstName);
    td.appendChild(tb);
    document.getElementById("tr2").appendChild(td);

    td = document.createElement("TD");
    tb = document.createTextNode(employee.lastName);
    td.appendChild(tb);
    document.getElementById("tr2").appendChild(td);

    td = document.createElement("TD");
    tb = document.createTextNode("$"+employee.salary);
    td.appendChild(tb);
    document.getElementById("tr2").appendChild(td);
}

function MultiplyBy(num1, num2, num3) {
    var result = num1 * num2 * num3;
    console.log(num1 + " X " + num2 + " X " + num3 + " = " + result);
}

function LongestCountryName(contries) {
    var compareValue = contries[0];
    for (var i = 0; i < contries.length; i++) {
        if (contries[i].length > compareValue.length) {
            compareValue = contries[i];
        }
    }
    console.log(compareValue);
}

function Removecolor() {
    var item = document.getElementById("colorSelect");
    item.remove(item.selectedIndex);
}

function InsertRow() {
    var tableReff = document.getElementById("table").getElementsByTagName("tbody")[0];
    var nextRows = GetTotalRows("table") + 1;

    var newRow = tableReff.insertRow(tableReff.rows.length);

    var newCell1 = newRow.insertCell(0);
    var newText = document.createTextNode("Row" + nextRows + " cell1");
    newCell1.appendChild(newText);

    var newCell2 = newRow.insertCell(1);
    newText = document.createTextNode("Row" + nextRows + " cell2");
    newCell2.appendChild(newText);

}

function GetTotalRows(tableId) {
    var totalRows = 0;
    var rowCount = 0;
    var table = document.getElementById(tableId);
    var rows = table.getElementsByTagName("tr");

    for (var i = 0; i < rows.length; i++)
        totalRows++;

    return totalRows;
}