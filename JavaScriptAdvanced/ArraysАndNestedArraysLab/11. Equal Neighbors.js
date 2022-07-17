function solve(array) {

    let numberOfPairs = 0;
    let firstArray = [];
    let secondArray = [];

    // Search for equal neighbors in vertical direction.
    for (let i = 0; i < array.length - 1; i++) {
        firstArray = array[i];
        secondArray = array[i + 1];

        for (let j = 0; j < firstArray.length; j++) {
            if (firstArray[j] == secondArray[j]) {
                numberOfPairs += 1;
            }
        }
    }

    // Search for equal neighbors in horizontal direction.
    for (const innerArray of array) {
        for (let k = 0; k < innerArray.length - 1; k++) {
            if (innerArray[k] == innerArray[k + 1]) {
                numberOfPairs += 1;
            }
        }
    }

    // Print output
    console.log(numberOfPairs);
    
}