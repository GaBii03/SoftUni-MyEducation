function subtract() {
    let firstNumberElement = document.getElementById('firstNumber');
    let secondNumberElement = document.getElementById('secondNumber');
    let subtactedValue = Number(firstNumberElement.value) - Number(secondNumberElement.value);
    let placeResultElement = document.getElementById('result');
    placeResultElement.innerHTML = subtactedValue; 
}