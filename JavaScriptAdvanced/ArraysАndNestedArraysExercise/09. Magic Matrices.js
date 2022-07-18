function solve(matrix){

    //A matrix is magical if the sums of the cells of every row and every column are equal.

    // Variables
    let isMagical = true;

    // Functions
    function calculateArraySum(array){
        let sum = 0;

        for (const number of array) {
            sum += number;
        }

        return sum;
    }

    function getMatrixColumn(matrix, columnIndex) {
        let columnArray = [];

        for (let row = 0; row < matrix.length; row++) {
            columnArray.push(matrix[row][columnIndex]);
        }

        return columnArray;
    }

    // Program logic
    // 1. Check for rows sum equality
    for (let row = 0; row < matrix.length - 1; row++) {
        const firstInnerArray = matrix[row];
        const secondInnerArray = matrix[row + 1];
        let firstArraySum = calculateArraySum(firstInnerArray);
        let secondArraySum = calculateArraySum(secondInnerArray);

        if (firstArraySum != secondArraySum) {
            isMagical = false;
            break;
        }
    }

    // 2. If all row's sums are equal we check for columns sum equality
    if (isMagical) {
        for (let columnIndex = 0; columnIndex < matrix.length - 1; columnIndex++) {
            let firstColumnArray = getMatrixColumn(matrix, columnIndex);
            let secondColumnArray = getMatrixColumn(matrix, columnIndex + 1);
            let firstColumnSum = calculateArraySum(firstColumnArray);
            let secondColumnSum = calculateArraySum(secondColumnArray);

            if (firstColumnSum != secondColumnSum) {
                isMagical = false;
                break;
            }
        }
    }

    // 3. Print output
    console.log(isMagical);

}