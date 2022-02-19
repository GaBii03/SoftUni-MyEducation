
window.addEventListener('load', solution);

  function solution(){
  const nameInputElement = document.getElementById('fname');
  const emailInputElement = document.getElementById('email');
  const phoneInputElement = document.getElementById('phone');
  const addressInputElement = document.getElementById('address');
  const codeInputElement = document.getElementById('code');
  const submitButtonElement = document.getElementById('submitBTN')
  const editButtonElement = document.getElementById('editBTN')
  const continueButtonElement = document.getElementById('continueBTN');
  const ulInfoPreviewElement = document.getElementById('infoPreview');
  const divBlockElement = document.getElementById('block');

  function removeAllChildNodes(parent) {
    while (parent.firstChild) {
        parent.removeChild(parent.firstChild);
    }
  }

  submitButtonElement.addEventListener('click', (e) => {

    e.currentTarget.disabled = true;
    continueButtonElement.disabled = false;
    editButtonElement.disabled = false;
    const nameLiElement = document.createElement('li');
    nameLiElement.textContent = `Full Name: ${nameInputElement.value}`;
    const emailLiElement = document.createElement('li');
    emailLiElement.textContent = `Email: ${emailInputElement.value}`;
    const phoneLiElement = document.createElement('li');
    phoneLiElement.textContent = `Phone Number: ${phoneInputElement.value}`;
    const addressLiElement = document.createElement('li');
    addressLiElement.textContent = `Address: ${addressInputElement.value}`;
    const codeLiElement = document.createElement('li');
    codeLiElement.textContent = `Postal Code: ${codeInputElement.value}`;


    nameInputElement.value = '';
    emailInputElement.value = '';
    phoneInputElement.value = '';
    addressInputElement.value = '';
    codeInputElement.value = '';


    ulInfoPreviewElement.appendChild(nameLiElement);
    ulInfoPreviewElement.appendChild(emailLiElement);
    ulInfoPreviewElement.appendChild(phoneLiElement);
    ulInfoPreviewElement.appendChild(addressLiElement);
    ulInfoPreviewElement.appendChild(codeLiElement);

    continueButtonElement.addEventListener('click', () => {
      
      removeAllChildNodes(divBlockElement);
      const h3Element = document.createElement('h3');
      h3Element.textContent = 'Thank you for your reservation!';
      divBlockElement.appendChild(h3Element);
    })

    editButtonElement.addEventListener('click', () => {
      
      removeAllChildNodes(ulInfoPreviewElement);
      submitButtonElement.disabled = false;
      continueButtonElement.disabled = true;
      editButtonElement.disabled = true;
    })

  });
}
