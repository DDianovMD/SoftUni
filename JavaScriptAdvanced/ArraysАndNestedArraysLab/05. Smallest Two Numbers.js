function solve(array) {

    // Variable which stores smallest two numbers.
    smallestTwoNumbers = [];

    // Sort array ascending.
    array = array.sort((x, y) => x - y);

    // Get first two numbers from sorted array.
    smallestTwoNumbers.push(array[0]);
    smallestTwoNumbers.push(array[1]);

    // Return output
    return smallestTwoNumbers;
}