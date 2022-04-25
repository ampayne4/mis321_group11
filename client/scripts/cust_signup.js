const baseUrl = "https://localhost:5001/api/Customers";
// function handleOnLoad()
// { 
//     populateList();
// }
// function populateList()
// {
//     postCustomer();
// }
function createUserAccount(){
    const postUrl = baseUrl;
    const sendCust = {
        custFName: document.getElementById("fname").value,
        custLName: document.getElementById("lname").value,
        custEmail: document.getElementById("email").value,
        custPassword: document.getElementById("psw").value,
        cardName: document.getElementById("cdn").value,
        cardNo: document.getElementById("cardno").value,
        cvvNo: document.getElementById("cvvno").value,
        cddate: document.getElementById("cddate").value,
    }
    fetch(postUrl, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(sendCust)
    })
}

// function favoriteSongs(id)
// {
//     const deleteSongApiUrl = baseUrl + "/" + id;
//     fetch(deleteSongApiUrl, {
//         method: "PUT",
//         headers: {
//             "Accept": 'application/json',
//             "Content-Type": 'application/json',
//         },
//     }).then((response) => {
//         console.log(response);
//         populateList();
//     })
// }
// function lookForSongFavorite()
// {
//     let songId = document.getElementById("favoriteSong").value;
//     fetch(baseUrl).then(function(response) 
//     {
// 		console.log(response);
// 		return response.json();
// 	}).then(function(json) {
//         console.log(json)
//         let html = ``;
// 		json.forEach((song) => {
//             if (song.id == songId) {
//                 favoriteSongs(song.id);
//             }
// 		});
// 	}).catch(function(error) {
// 		console.log(error);
// 	})
// }
// function lookForSongDelete() 
// {
//     let songId = document.getElementById("deleteSong").value;
//     fetch(baseUrl).then(function(response) 
//     {
// 		return response.json();
// 	}).then(function(json) {
//         console.log(json)
//         let html = ``;
// 		json.forEach((song) => {
//             if (song.id == songId) {
//                 deleteSongs(song.id);
//             }
// 		});
// 	}).catch(function(error) {
// 		console.log(error);
// 	})
// }
// function deleteSongs(id)
// { 
//     const deleteSongApiUrl = baseUrl + "/" + id;
//     fetch(deleteSongApiUrl, {
//         method: "DELETE",
//         headers: {
//             "Accept": 'application/json',
//             "Content-Type": 'application/json',
//         },
//     }).then((response) => {
//         console.log(response);
//         populateList();
//     })
// }