const baseURL = "https://localhost:5001/api/Customers";
function handleOnLoad()
{ 
    populateList();
}
function Displaycustlogin()
{
    window.location.href = "./cust_login.html";
}
function Displayemplogin()
{
    window.location.href = "./employ_login.html";
}
function custSignUp()
{
    window.location.href = "./cust_signup.html";
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
		json.forEach((song) => {
            if(song.deleted == false && song.favorited == false)
            {
                html += `<div class="card col-md-4 bg-dark text-white">`;
                html += `<img src="./resources/images/music.jpeg" class="card-img" alt="...">`;
                html += `<div class="card-img-overlay">`;
                html += `<h5 class="card-title">`+song.id + ": " + song.title + `</h5>`;
                html += `</div>`;
                html += `</div>`;
            }
            else if(song.favorited == true && song.deleted == false)
            {
                html += `<div class="card col-md-4 bg-dark text-white">`;
                html += `<img src="./resources/images/music.jpeg" class="card-img" alt="...">`;
                html += `<div class="card-img-overlay">`;
                html += `<h5 class="card-title">`+ song.id + ": " + song.title + "      (favorited)" + `</h5>`;
                html += `</div>`;
                html += `</div>`;
            }
            else if(song.deleted == true && (song.favorited == true || song.favorited == false))
            {
                html += "";
            }
		});

        if(html === ``){
            html = "No Songs found :("
        }
		document.getElementById("searchSongs").innerHTML = html;

	}).catch(function(error) {
		console.log(error);
	})
}
function addSongs(){ //post
    const postSongApiUrl = baseUrl;
    const addSong = {
        title: document.getElementById('title').value,
        dateAdded: new Date().toISOString(),
        deleted: false,
        favorited: false,
    }
    fetch(postSongApiUrl, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(addSong)
    })
    .then((response) => response.text()
    );
    setTimeout(() => {
    document.getElementById("searchSongs").innerHTML = "";
    populateList();
    }, 2000);
}
function favoriteSongs(id)
{
    const deleteSongApiUrl = baseUrl + "/" + id;
    fetch(deleteSongApiUrl, {
        method: "PUT",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
    }).then((response) => {
        console.log(response);
        populateList();
    })
}
function lookForSongFavorite()
{
    let songId = document.getElementById("favoriteSong").value;
    fetch(baseUrl).then(function(response) 
    {
		console.log(response);
		return response.json();
	}).then(function(json) {
        console.log(json)
        let html = ``;
		json.forEach((song) => {
            if (song.id == songId) {
                favoriteSongs(song.id);
            }
		});
	}).catch(function(error) {
		console.log(error);
	})
}
function lookForSongDelete() 
{
    let songId = document.getElementById("deleteSong").value;
    fetch(baseUrl).then(function(response) 
    {
		return response.json();
	}).then(function(json) {
        console.log(json)
        let html = ``;
		json.forEach((song) => {
            if (song.id == songId) {
                deleteSongs(song.id);
            }
		});
	}).catch(function(error) {
		console.log(error);
	})
}
function deleteSongs(id)
{ 
    const deleteSongApiUrl = baseUrl + "/" + id;
    fetch(deleteSongApiUrl, {
        method: "DELETE",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
    }).then((response) => {
        console.log(response);
        populateList();
    })
}