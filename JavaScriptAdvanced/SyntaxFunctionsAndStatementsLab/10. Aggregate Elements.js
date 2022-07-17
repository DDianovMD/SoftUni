function solve(array){

    let sum = 0;
    let inverseValuesSum = 0;
    let concatResult = '';

    for (let i = 0; i < array.length; i++) {
        const element = array[i];
        sum += Number(element);
        inverseValuesSum += Number(1 / element);
        concatResult += String(element);
    }

    console.log(sum);
    console.log(inverseValuesSum);
    console.log(concatResult);
    
}