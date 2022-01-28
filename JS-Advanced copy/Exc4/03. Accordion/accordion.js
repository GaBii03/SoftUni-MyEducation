function toggle() {

    let buttonElement = document.querySelector('.button')
    let textElement = document.getElementById('extra');

    console.log(buttonElement);
    
    if(buttonElement.textContent == 'More'){
        textElement.style.display = 'block';
        buttonElement.textContent = 'Less';
    }
    else{
        textElement.style.display = 'none' ;
        buttonElement.textContent = 'More';
    }
}