function solve(array){

    // Variables
    let number = 1;
    let resultArray = [];

    // Program logic
    for (let i = 0; i < array.length; i++) {
        const element = array[i];
        
        if (element == 'add') {
            resultArray.push(number);
        } else {
            resultArray.pop();
        }

        number += 1;
    }

    // Print output
    if (resultArray.length > 0) {
        resultArray.forEach(x => console.log(x));
    } else {
        console.log('Empty');
    }

}