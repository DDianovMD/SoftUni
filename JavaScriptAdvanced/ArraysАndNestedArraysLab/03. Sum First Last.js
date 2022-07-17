function solve(array) {

    let sum = 0;
    const firstElement = Number(array[0]);
    const lastElement = Number(array[array.length - 1]);

    sum = firstElement + lastElement;

    console.log(sum);

}