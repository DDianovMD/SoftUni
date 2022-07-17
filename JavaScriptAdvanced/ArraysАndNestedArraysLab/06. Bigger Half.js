function solve(array){

    let biggerHalf = [];

    // Sort numbers in the array ascending.
    array = array.sort((x, y) => x - y);

    if (array.length % 2 == 0) {
        for (let i = array.length / 2; i < array.length; i++) {
            const element = array[i];
            biggerHalf.push(element);
        }
    } else {
        for (let i = Math.floor(array.length / 2); i < array.length; i++) {
            const element = array[i];
            biggerHalf.push(element);
        }
    }

    return biggerHalf;
    
}