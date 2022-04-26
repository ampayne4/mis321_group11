const baseUrl = "https://localhost:5001/api/Products";
function displayTable(json)
{
    var dataTable = document.getElementById("dataTable");
    var html = "<table id=\"personTable\" class=\"table table-striped table-dark\" id=><tr><th>ID</th><th>First Name</th><th>Last Name</th><th>Major</th><th>City</th></tr>";
    json.forEach(person => {
        html+=`<tr><td>${product.ProductId}</td><td>${product.ProductName}</td><td>${product.ProdPrice}</td><td>${product.ProductImg}</td><td>${product.ProductCategory}</td></tr>`;
    });
    html += "</table>";

    dataTable.innerHTML = html;
    handleTableEdit();
}
function populateList()
{
    fetch(baseUrl).then(function(response) 
    {
		console.log(response);
		return response.json();
	}).then(function(json) {
        console.log(json)
        let html = ``;
		json.forEach((product) => {
            if(product.deleted == false)
            {
                html += `<div class="card col-md-4 bg-light text-dark">`;
                html += `<img src = "${product.productImage}" class = "card-img" alt="...">`;
                html += `<class = "card-img-overlay">`
                html += `<h5 class = "card-title">`+ product.productName + `</h5>`;
                html += `<h7 class="card-title">`+ "$" + product.productPrice + `</h7>`;
                html += `<br>`
                html += `<button class = "addToCart"> Add To Cart`
                html += `</div>`
            }
		});
        document.getElementById("productPlacement").innerHTML = html;

	}).catch(function(error) {
		console.log(error);
	})
}