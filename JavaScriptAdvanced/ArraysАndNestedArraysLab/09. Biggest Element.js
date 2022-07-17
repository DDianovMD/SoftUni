function solve(array){

    // Variable to store biggest number.
    let biggestElement = Number.MIN_SAFE_INTEGER;

    // Get biggest number among all inner arrays.
    for (const innerArray of array) {
        for (const number of innerArray) {
            if (number > biggestElement) {
                biggestElement = number;
            }
        }
    }

    // Return output
    return biggestElement;

}