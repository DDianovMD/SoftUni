function solve(array, firstFlavor, secondFlavor){

    let resultArray = [];
    let startingIndex = array.indexOf(firstFlavor);
    let endingIndex = array.indexOf(secondFlavor);

    for (let i = startingIndex; i <= endingIndex; i++) {
        const element = array[i];

        resultArray.push(element);
    }

    return resultArray;
}