function solve(number1, number2, number3){

    let numbers = [];
    numbers.push(number1);
    numbers.push(number2);
    numbers.push(number3);

    let largestNumber = Number.MIN_SAFE_INTEGER;

    for (let i = 0; i < numbers.length; i++) {
        const element = numbers[i];
        
        if (element > largestNumber) {
            largestNumber = element;
        }
    }

    console.log(`The largest number is ${largestNumber}.`);
}