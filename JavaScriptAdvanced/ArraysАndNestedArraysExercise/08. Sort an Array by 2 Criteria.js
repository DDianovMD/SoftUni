function solve(array){

    // First sorting criteria - by a length in ascending order.
    // Second sorting criteria - by alphabetical value in ascending order.
    // The comparison should be case-insensitive.

    // Program logic.
    array.sort((x, y) => {
            if(x.length != y.length) {
                return x.length - y.length;
            } else {
                return x.toLowerCase().localeCompare(y.toLowerCase());
            }
        });

    // Print sorted array.
    array.forEach(x => console.log(x));

}