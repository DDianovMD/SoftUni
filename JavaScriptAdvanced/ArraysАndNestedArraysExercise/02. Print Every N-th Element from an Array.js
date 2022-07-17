function solve(array, n){

    let resultArray = [];

    for (let i = 0; i < array.length; i+=n) {
        const element = array[i];
        
        resultArray.push(element);
    }

    return resultArray;
}