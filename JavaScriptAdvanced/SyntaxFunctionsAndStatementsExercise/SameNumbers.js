function solve(number){
    let isTrue = true;
    let sum = 0;

    let numberAsString = String(number);

    for (let i = 0; i < numberAsString.length - 1; i++) {
        const element = numberAsString[i];

        if(element != numberAsString[i + 1]){
            isTrue = false
        }
        
        sum += Number(element);
    }

    sum += Number(numberAsString[numberAsString.length - 1]);

    console.log(isTrue);
    console.log(sum);
}
