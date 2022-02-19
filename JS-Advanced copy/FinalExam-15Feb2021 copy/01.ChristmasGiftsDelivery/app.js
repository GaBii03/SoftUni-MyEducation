function solution() {
    
    const giftInputNameElement = document.querySelector('input');
    const addButtonElement = document.querySelector('button');
    const removeChildren = (parent) => {
        while (parent.lastChild) {
            parent.removeChild(parent.lastChild);
        }
    };

    addButtonElement.addEventListener('click', () => {

        let giftName = giftInputNameElement.value;
        const ulElementAdd = document.querySelectorAll('ul')[0];
        const liForTheGiftElementAdd = document.createElement('li');
        const sendButtonElement = document.createElement('button');
        const discardButtonElement = document.createElement('button');
        liForTheGiftElementAdd.textContent = giftName;
        liForTheGiftElementAdd.classList.add('gift');
        sendButtonElement.setAttribute('id', 'sendButton');
        sendButtonElement.textContent = 'Send';
        discardButtonElement.setAttribute('id', 'discardButton');
        discardButtonElement.textContent = 'Discard';
        liForTheGiftElementAdd.appendChild(sendButtonElement);
        liForTheGiftElementAdd.appendChild(discardButtonElement);
        ulElementAdd.appendChild(liForTheGiftElementAdd);
        let arrayElements = Array.from(ulElementAdd.querySelectorAll('li'));
        arrayElements.sort((a,b) => a.textContent.localeCompare(b.textContent)).forEach(li => ulElementAdd.appendChild(li));
        
        giftInputNameElement.value = '';

        sendButtonElement.addEventListener('click', () => {

            const ulElementSend = document.querySelectorAll('ul')[1];
            const liForTheGiftElementSend = document.createElement('li');
            liForTheGiftElementSend.textContent = giftName;
            liForTheGiftElementSend.classList.add('gift');
            ulElementSend.appendChild(liForTheGiftElementSend);
            liForTheGiftElementAdd.remove();
            
        })

        discardButtonElement.addEventListener('click', () => {
            const ulElementDiscard = document.querySelectorAll('ul')[2];
            const liForTheGiftElementDiscard = document.createElement('li');
            liForTheGiftElementDiscard.textContent = giftName;
            liForTheGiftElementDiscard.classList.add('gift');
            ulElementDiscard.appendChild(liForTheGiftElementDiscard);
            liForTheGiftElementAdd.remove();
        })

    })
}