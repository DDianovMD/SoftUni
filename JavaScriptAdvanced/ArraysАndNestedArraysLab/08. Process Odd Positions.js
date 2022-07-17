function solve(array){
    
    // Array which stores doubled elements at odd position.
    let doubledElementsAtOddPosition = [];

    // Save doubled elements at odd position.
    for (let i = 0; i < array.length; i++) {
        const element = array[i];
        
        // Check if position is odd.
        if (i % 2 != 0) {
            doubledElementsAtOddPosition.push(element * 2);
        }
    }

    // Reverse the array of saved elements
    doubledElementsAtOddPosition = doubledElementsAtOddPosition.reverse();

    // Return output
    return doubledElementsAtOddPosition;

}