function solve(array, timesToRotate){

    // Program logic
    for (let i = 0; i < timesToRotate; i++) {
        array.unshift(array.pop());
    }

    // Print output
    console.log(array.join(' '));

}