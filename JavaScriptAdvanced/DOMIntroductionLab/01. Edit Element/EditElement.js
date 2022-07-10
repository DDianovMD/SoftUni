function editElement(element, textToReplace, newText) {

    while (element.innerText.includes(textToReplace)) {
        element.textContent = element.innerText.replace(textToReplace, newText);
    }
}