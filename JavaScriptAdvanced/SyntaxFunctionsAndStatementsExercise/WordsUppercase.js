function solve(input){

    let regExPattern = /\W+/;
    let inputArray = String(input).split(regExPattern).filter(x => x);

    for (let i = 0; i < inputArray.length; i++) {
        inputArray[i] = inputArray[i].toUpperCase();        
    }

    console.log(inputArray.join(', '));
}