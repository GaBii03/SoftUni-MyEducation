function extractText() {
    let collectedElements = document.getElementById('items');
    let textAreaElement = document.getElementById('result');

    let text = collectedElements.textContent;
    textAreaElement.textContent = text;
}