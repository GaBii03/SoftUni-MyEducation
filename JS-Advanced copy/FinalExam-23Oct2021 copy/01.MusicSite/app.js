window.addEventListener('load', solve);

function solve() {
    const genreInputElement = document.getElementById('genre');
    const nameInputElement = document.getElementById('name');
    const authorInputElement = document.getElementById('author');
    const dateInputElement = document.getElementById('date');
    const addButtonElement = document.getElementById('add-btn');
    let likes = 0;


    addButtonElement.addEventListener('click', (e) => {

        e.preventDefault();

        if (genreInputElement.value != '' || nameInputElement.value != ''
            || authorInputElement.value != '' || dateInputElement.value != '') {

            const divAllHitsInfoElement = document.querySelector('.all-hits-container');
            const divHitInfoElement = document.createElement('div');
            const imgElement = document.createElement('img');
            const genreH2Element = document.createElement('h2');
            const nameH2Element = document.createElement('h2');
            const authorH2Element = document.createElement('h2');
            const dateH3Element = document.createElement('h3');
            const saveButtonElement = document.createElement('button');
            const likeButtonElement = document.createElement('button');
            const deleteButtonElement = document.createElement('button');

            divHitInfoElement.classList.add('hits-info');
            imgElement.setAttribute('src', './static/img/img.png');
            saveButtonElement.classList.add('save-btn');
            likeButtonElement.classList.add('like-btn');
            deleteButtonElement.classList.add('delete-btn');
            genreH2Element.textContent = `Genre: ${genreInputElement.value}`;
            nameH2Element.textContent = `Name: ${nameInputElement.value}`;
            authorH2Element.textContent = `Author: ${authorInputElement.value}`;
            dateH3Element.textContent = `Date: ${dateInputElement.value}`;
            saveButtonElement.textContent = 'Save song';
            likeButtonElement.textContent = 'Like song';
            deleteButtonElement.textContent = 'Delete';

            divHitInfoElement.appendChild(imgElement);
            divHitInfoElement.appendChild(genreH2Element);
            divHitInfoElement.appendChild(nameH2Element);
            divHitInfoElement.appendChild(authorH2Element);
            divHitInfoElement.appendChild(dateH3Element);
            divHitInfoElement.appendChild(saveButtonElement);
            divHitInfoElement.appendChild(likeButtonElement);
            divHitInfoElement.appendChild(deleteButtonElement);
            divAllHitsInfoElement.appendChild(divHitInfoElement);

            genreInputElement.value = '';
            nameInputElement.value = '';
            authorInputElement.value = '';
            dateInputElement.value = '';

            likeButtonElement.addEventListener('click', (e) => {

                e.currentTarget.disabled = true;
                likes++;
                let paragrphWithLikesElement = document.querySelector('#total-likes div p');
                paragrphWithLikesElement.textContent = `Total Likes: ${likes}`;
            })

            saveButtonElement.addEventListener('click', () => {

                let divWithSavedSongsElement = document.querySelector('.saved-container');
                const newDivHitInfoElement = document.createElement('div');
                newDivHitInfoElement.classList.add('hits-info');
                newDivHitInfoElement.appendChild(imgElement);
                newDivHitInfoElement.appendChild(genreH2Element);
                newDivHitInfoElement.appendChild(nameH2Element);
                newDivHitInfoElement.appendChild(authorH2Element);
                newDivHitInfoElement.appendChild(dateH3Element);
                newDivHitInfoElement.appendChild(deleteButtonElement);
                divWithSavedSongsElement.appendChild(newDivHitInfoElement);
                divHitInfoElement.remove();

            })

            deleteButtonElement.addEventListener('click', (e) => {
                e.currentTarget.parentElement.remove();
            })
        }

    })
}