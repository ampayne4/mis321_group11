const baseUrl = "https://localhost:5001/api/Customers";

function test(){
    console.log(sessionStorage.getItem("email"));
    console.log(sessionStorage.getItem("password"));
}


function custLogin(){
    var email = document.getElementById("email").value;
    var password = document.getElementById("Pass").value;

    const url = baseUrl;



    console.log(email);
    console.log(password);

    fetch(url).then(function(response){
        return response.json();
    }).then(function(json){
        console.log(json);
        json.forEach((customer) => {
            console.log(customer.custFName)
            if(email === customer.custEmail && password === customer.custPassword)
            {
                console.log("Email and password match!");
                sessionStorage.setItem("email", customer.custEmail);
                sessionStorage.setItem("password", custPassword);
            }
		});
    }).catch(function(error){
        console.log(error);
    });

    // fetch(url).then(function(response) {
	// 	console.log(response);
	// 	return response.json();
	// }).then(function(json) {
    //     console.log(json)
	// 	json.forEach((customer) => {
    //         console.log(customer.custId);
	// 	});

	// }).catch(function(error) {
	// 	console.log(error);
	// })

}







function findSongs(){
    // var url = "https://www.songsterr.com/a/ra/songs.json?pattern="
    const url = "https://localhost:5001/api/Songs"
    //var url = "jhdjjtqo9w5bzq2t.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
    let searchString = document.getElementById("searchSong").value;

    //url += searchString;

    console.log(searchString)

    fetch(url).then(function(response) {
		console.log(response);
		return response.json();
	}).then(function(json) {
        console.log(json)
        let html = ``;
        let count = 0
        html += `<div class = "row">`
		json.forEach((song) => {
            console.log(song.songTitle)
            if(song.deleted == "n"){
                html += `<div class="card col-md-4 bg-dark text-white">`;
                html += `<img src="./resources/images/music.jpeg" class="card-img" alt="...">`;
                html += `<div class="card-img-overlay">`;
                html += `<h5 class="card-title">`+song.songTitle+`</h5>`;
                html += `</div>`;
                html += `</div>`;
            }
            

            if (count ==3){
                html += `</div><div class = "row">`;
            }
		});
		
        if(html === ``){
            html = "No Songs found :("
        }
		document.getElementById("cards").innerHTML = html;

	}).catch(function(error) {
		console.log(error);
	})
}