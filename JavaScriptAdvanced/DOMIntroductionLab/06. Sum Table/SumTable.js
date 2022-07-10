function sumTable() {
    let tdElements = document.getElementsByTagName('td');
    let sumElement = document.getElementById('sum');
    let sum = 0;

    for (let i = 0; i < tdElements.length; i++) {
        const element = tdElements[i];
        
        if (i % 2 != 0) {
            sum += Number(element.innerText);
        }
    }

    sumElement.innerText = sum;
}