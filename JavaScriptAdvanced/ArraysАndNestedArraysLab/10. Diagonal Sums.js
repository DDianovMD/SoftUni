function solve(array){

    let diagonalSums = [];
    let diagonalSum = 0;

    // Calculate first diagonal sum and save it.
    for (let i = 0; i < array.length; i++) {
        const element = array[i][i];
        
        diagonalSum += element
    }

    diagonalSums.push(diagonalSum);
    diagonalSum = 0;

    for (let i = 0; i < array.length; i++) {
        const element = array[i][array.length - (1 + i)];
        
        diagonalSum += element;
    }

    diagonalSums.push(diagonalSum);

    // Return output
    return diagonalSums.join(' ');
    
}