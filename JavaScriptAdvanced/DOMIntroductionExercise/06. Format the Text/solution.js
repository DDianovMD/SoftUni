function solve() {
    let inputText = document.getElementById('input').value;
    let outputElement = document.getElementById('output');

    let sentencesArray = String(inputText)
        .split('.')
        .filter((element) => element);

    for (let i = 0; i < sentencesArray.length; i += 3) {
        outputElement.appendChild(document.createElement('p'));
    }

    let pElements = document.querySelectorAll('#output p');
    for (const element of pElements) {
        for (let i = 0; i < 3; i++) {
            if (i < 2) {
                element.innerText += sentencesArray[0] + '. ';
                sentencesArray.shift();
            } else {
                element.innerText += sentencesArray[0] + '.';
                sentencesArray.shift();
            }

            if (sentencesArray.length == 0) {
                break;
            }
        }
    }
}
