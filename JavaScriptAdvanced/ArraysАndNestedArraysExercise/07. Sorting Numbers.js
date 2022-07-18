function solve(array) {

    // Variables
    let resultArray = [];

    // Program logic
    // Sort in ascending order
    array.sort((x, y) => x - y);

    // Fill resultarray
    while (array.length > 0) {
        // Add smallest number and remove it.
        resultArray.push(array.shift());

        // Check if array is not empty.
        if (array.length > 0) {
            // Add biggest number and remove it.
            resultArray.push(array.pop());
        }
    }

    // Return output
    return resultArray;

}