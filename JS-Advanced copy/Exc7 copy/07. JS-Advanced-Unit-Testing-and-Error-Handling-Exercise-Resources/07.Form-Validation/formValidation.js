function validate() {
    let usernameInputElement = document.getElementById('username');
    let emailInputElement = document.getElementById('email');
    let passwordInputElement = document.getElementById('password');
    let confPassInputElement = document.getElementById('confirm-password');
    let companyCheckerElement = document.getElementById('company');
    let submitButtonElement = document.getElementById('submit');
   
    submitButtonElement.addEventListener('click', () =>{
        if((usernameInputElement.value).match(/^[A-Za-z0-9]{2,19}$/) === null){
            usernameInputElement.style.borderColor = 'red';
        }else{
            usernameInputElement.style.borderColor = 'none';
        }

        if((emailInputElement.value).match(/^[a-z0-9\.]+@([a-z-]+\.)+[a-z]{2,4}$/) === null){
            emailInputElement.style.borderColor = 'red';
        }else{
            emailInputElement.style.borderColor = 'none';
        }
         event.preventDefault();
    });


}
