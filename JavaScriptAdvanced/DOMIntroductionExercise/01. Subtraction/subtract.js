function subtract() {
    let firstNumberElement = document.getElementById('firstNumber');
    let secondNumberElement = document.getElementById('secondNumber');
    let resultElement = document.getElementById('result');

    resultElement.innerText = Number(firstNumberElement.value) - Number(secondNumberElement.value);
}