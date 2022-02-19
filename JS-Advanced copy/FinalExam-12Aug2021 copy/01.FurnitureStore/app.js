window.addEventListener('load', solve);

// my solution 55/100
function solve() {
    const modelInputElement = document.getElementById('model');
    const yearInputElement = document.getElementById('year');
    const descriptionInputElement = document.getElementById('description');
    const priceInputElement = document.getElementById('price');
    const buttonInputElement = document.getElementById('add');
    const totalProfitElement = document.querySelector('.total-price');


    buttonInputElement.addEventListener('click', (e) => {
        e.preventDefault();
        let price = Number(priceInputElement.value).toFixed(2);
        const tbodyFurnitureListElement = document.getElementById('furniture-list');
        const tableRowInfoElement = document.createElement('tr');
        const modelElement = document.createElement('td');
        const priceElement = document.createElement('td');
        const actions = document.createElement('td');
        const moreInfoButton = document.createElement('button');
        const buyItButton = document.createElement('button');
        const hideTableRowInfoElement = document.createElement('tr');
        const yearElement = document.createElement('td');
        const descriptionElement = document.createElement('td');
        hideTableRowInfoElement.classList.add('hide');
        descriptionElement.setAttribute('colspan', 3);
        yearElement.textContent = `Year: ${yearInputElement.value}`;
        descriptionElement.textContent = `Description: ${descriptionInputElement.value}`;
        tableRowInfoElement.classList.add('info');
        
        modelElement.textContent = modelInputElement.value;
        priceElement.textContent = price;
        moreInfoButton.classList.add('moreBtn');
        buyItButton.classList.add('buyBtn');
        moreInfoButton.textContent = 'More Info';
        buyItButton.textContent = 'Buy it';
        actions.appendChild(moreInfoButton);
        actions.appendChild(buyItButton);
        tableRowInfoElement.appendChild(modelElement);
        tableRowInfoElement.appendChild(priceElement);
        tableRowInfoElement.appendChild(actions);
        hideTableRowInfoElement.appendChild(yearElement);
        hideTableRowInfoElement.appendChild(descriptionElement);
        tbodyFurnitureListElement.appendChild(tableRowInfoElement);
        tbodyFurnitureListElement.appendChild(hideTableRowInfoElement);

        modelInputElement.textContent = '';
        yearInputElement.textContent = '';
        descriptionInputElement.textContent = '';
        priceInputElement.textContent = '';

        moreInfoButton.addEventListener('click', (e) => {
            if(e.currentTarget.textContent == 'Less Info'){
                e.currentTarget.textContent = 'More Info';
                hideTableRowInfoElement.style.display = 'none';
            }else if(e.currentTarget.textContent == 'More Info'){
                e.currentTarget.textContent = 'Less Info';
                hideTableRowInfoElement.style.display = 'contents';
            }
        })
        
        buyItButton.addEventListener('click', () => {
            let currentProfit = Number(totalProfitElement.textContent);
            currentProfit += Number(price);
            totalProfitElement.textContent = currentProfit.toFixed(2);
            tableRowInfoElement.remove();
            hideTableRowInfoElement.remove();
        })
    })
}

// Ivo - solution  100/100

// function solve() {
//     const addButtonElement = document.getElementById('add');
//     const modelInputElement = document.getElementById('model');
//     const yearInputElement = document.getElementById('year');
//     const descriptionInputElement = document.getElementById('description');
//     const priceInputElement = document.getElementById('price');
//     const furnitureListElement = document.getElementById('furniture-list');

//     addButtonElement.addEventListener('click', (e) => {
//         e.preventDefault();

//         let model = modelInputElement.value;
//         let description = descriptionInputElement.value;
//         let year = Number(yearInputElement.value);
//         let price = Number(priceInputElement.value);

//         modelInputElement.value = '';
//         descriptionInputElement.value = '';
//         yearInputElement.value = '';
//         priceInputElement.value = '';

//         if (!model || !description) {
//             return;
//         }

//         if (year <= 0 || price <= 0) {
//             return;
//         }

//         let rowElement = document.createElement('tr');
//         let modelCellElement = document.createElement('td');
//         let priceCellElement = document.createElement('td');
//         let actionsCellElement = document.createElement('td');
//         let infoButtonElement = document.createElement('button');
//         let buyButtonElement = document.createElement('button');
//         let contentsRowElement = document.createElement('tr');
//         let yearContentElement = document.createElement('td');
//         let descriptionContentElement = document.createElement('td');
//         let totalPriceElement = document.querySelector('.total-price');
        
//         modelCellElement.textContent = model;
//         priceCellElement.textContent = price.toFixed(2);

//         infoButtonElement.textContent = 'More Info';
//         infoButtonElement.classList.add('moreBtn');
//         infoButtonElement.addEventListener('click', (e) => {
//             if (e.currentTarget.textContent == 'More Info') {
//                 contentsRowElement.style.display = 'contents';
//                 e.currentTarget.textContent = 'Less Info';
//             } else {
//                 contentsRowElement.style.display = 'none';
//                 e.currentTarget.textContent = 'More Info';
//             }
//         });

//         buyButtonElement.textContent = 'Buy it';
//         buyButtonElement.classList.add('buyBtn');
//         buyButtonElement.addEventListener('click', (e) => {
//             let currentTotalPrice = Number(totalPriceElement.textContent);
//             let totalPrice = currentTotalPrice + price;
//             totalPriceElement.textContent = totalPrice.toFixed(2);
            
//             rowElement.remove();
//             contentsRowElement.remove();
//         });

//         actionsCellElement.appendChild(infoButtonElement);
//         actionsCellElement.appendChild(buyButtonElement);

//         rowElement.classList.add('info');

//         rowElement.appendChild(modelCellElement);
//         rowElement.appendChild(priceCellElement);
//         rowElement.appendChild(actionsCellElement);

//         yearContentElement.textContent = `Year: ${year}`;
//         descriptionContentElement.setAttribute('colspan', 3);
//         descriptionContentElement.textContent = `Description: ${description}`;

//         contentsRowElement.classList.add('hide');
//         contentsRowElement.style.display = 'none';

//         contentsRowElement.appendChild(yearContentElement);
//         contentsRowElement.appendChild(descriptionContentElement);

//         furnitureListElement.appendChild(rowElement);
//         furnitureListElement.appendChild(contentsRowElement);
//     });
// }