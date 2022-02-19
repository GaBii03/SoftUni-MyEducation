function validate() {
    let inputEmailElement = document.getElementById('email');
    inputEmailElement.addEventListener('change', () => {
        let valid = new RegExp(/^[a-z0-9\.]+@([a-z-]+\.)+[a-z]{2,4}$/gm);
        if ((inputEmailElement.value).match(valid) == null && inputEmailElement.value != '') {
            inputEmailElement.classList.add('error');
        } else {
            inputEmailElement.classList.remove('error');
        }
    })
}