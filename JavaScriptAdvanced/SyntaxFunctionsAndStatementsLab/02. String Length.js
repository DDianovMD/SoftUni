function solve(firstString, secondString, thirdString){

    let firstLength = firstString.length;
    let secondLength = secondString.length;
    let thirdLength = thirdString.length;

    let sum = firstLength + secondLength + thirdLength;
    let averageLength = Math.floor(sum / 3);

    // Print output
    console.log(sum);
    console.log(averageLength);
}