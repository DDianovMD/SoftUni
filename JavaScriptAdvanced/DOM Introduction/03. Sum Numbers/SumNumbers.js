function calc() {
    let firstNumberElement = document.getElementById('num1');
    let secondNumberElement = document.getElementById('num2');
    let sumElement = document.getElementById('sum');

    sumElement.value = Number(firstNumberElement.value) + Number(secondNumberElement.value);
}
