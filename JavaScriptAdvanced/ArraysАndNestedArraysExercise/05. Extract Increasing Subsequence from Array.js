function solve(array){

    // Variable
    let resultArray = [];

    // Program logic
    resultArray.push(array[0]);

    for (let i = 1; i < array.length; i++) {
        const element = array[i];
        
        if (element >= resultArray[resultArray.length - 1]) {
            resultArray.push(element);
        }
    }

    // Return output
    return resultArray;
    
}