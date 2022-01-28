function calc() {
    let firstElement = document.getElementById('num1');
    let secondElement = document.getElementById('num2');
    let outputSpaceElement = document.getElementById('sum');
    let sum = Number(firstElement.value) + Number(secondElement.value);
    outputSpaceElement.value = sum;
    // TODO: sum = num1 + num2
}
