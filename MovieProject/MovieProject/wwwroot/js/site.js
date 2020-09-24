// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function postComment(commentContainer) {
    document.getElementById(commentContainer).innerHTML = "";
    document.getElementById(commentContainer).className = '';
    document.getElementById(commentContainer).className = 'd-flex justify-content-center';
    document.getElementById(commentContainer).innerHTML = '<div class="spinner-border" role="status"></div>';

    const data = { Name: document.getElementById('nameOfPersonComment').value, Description: document.getElementById('comment').value, MovieId: document.getElementById('movieID').value, Date: new Date().toJSON().slice(0, 10).replace(/-/g, '/') };

    fetch('https://localhost:5001/Comment', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(data),
    })
    .then(data => {
        getComments(commentContainer);
    })
    .catch((error) => {
        console.error('Error:', error);
    });
}

function getActualDate() {
    return new Date().toISOString().slice(0, 10)
}

function getComments(commentContainer) {
    document.getElementById(commentContainer).className = '';
    document.getElementById(commentContainer).innerHTML = "";

    fetch('https://localhost:5001/Comment/GetAllByMovieID/' + document.getElementById('movieID').value)
        .then(response => response.json())
        .then(data => {
            data.map(value => {
                document.getElementById(commentContainer).innerHTML += '<div class="card col-auto mb-2" style="width: 100%;"><div class="card-body"><h5 class="card-title">' + value.name + '</h5><p class="card-text">' + value.description + '</p></div></div>';
            });
        });
    document.getElementById('nameOfPersonComment').value = '';
    document.getElementById('comment').value = '';
}