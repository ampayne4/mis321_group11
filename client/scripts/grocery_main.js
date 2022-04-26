function displayTable(json){
    var dataTable = document.getElementById("dataTable");
    var html = "<table id=\"personTable\" class=\"table table-striped table-dark\" id=><tr><th>ID</th><th>First Name</th><th>Last Name</th><th>Major</th><th>City</th></tr>";
    json.forEach(person => {
        html+=`<tr><td>${product.ProductId}</td><td>${product.ProductName}</td><td>${product.ProdPrice}</td><td>${product.ProductImg}</td><td>${product.ProductCategory}</td></tr>`;
    });
    html += "</table>";

    dataTable.innerHTML = html;
    handleTableEdit();
}
