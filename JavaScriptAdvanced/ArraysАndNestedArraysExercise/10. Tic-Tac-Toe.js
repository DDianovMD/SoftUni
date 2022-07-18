function solve(matrixOfCoordinates) {
    // Variables
    let dashboard = [
        [false, false, false],
        [false, false, false],
        [false, false, false],
    ];
    let rowCoordinate;
    let columnCoordinate;
    let playerOnTurn = 'firstPlayer'; // Default value - firstPlayer
    let firstPlayerMark = 'X';
    let secondPlayerMark = 'O';

    // Functions
    // Switches player turn
    function switchTurn(playerOnTurn) {
        if (playerOnTurn == 'firstPlayer') {
            return 'secondPlayer';
        } else {
            return 'firstPlayer';
        }
    }

    // Returns from matrix a column with given index as an array
    function extractColumn(matrix, index) {
        let columnArray = [];

        for (let row = 0; row < matrix.length; row++) {
            const element = matrix[row][index];
            columnArray.push(element);
        }

        return columnArray;
    }

    // Returns 'true' if all cells in a column are taken and equal
    function verticalWinCheck(dashboard) {
        let gameIsWon = false;

        let firstColumn = extractColumn(dashboard, 0);
        // Returns 'true' if all cells in first column are taken and equal
        if (
            firstColumn[0] == firstColumn[1] &&
            firstColumn[1] == firstColumn[2] &&
            firstColumn[0] != false
        ) {
            gameIsWon = true;
            return gameIsWon;
        }

        let secondColumn = extractColumn(dashboard, 1);
        // Returns 'true' if all cells in second column are taken and equal
        if (
            secondColumn[0] == secondColumn[1] &&
            secondColumn[1] == secondColumn[2] &&
            secondColumn[0] != false
        ) {
            gameIsWon = true;
            return gameIsWon;
        }

        let thirdColumn = extractColumn(dashboard, 2);
        // Returns 'true' if all cells in third column are taken and equal
        if (
            thirdColumn[0] == thirdColumn[1] &&
            thirdColumn[1] == thirdColumn[2] &&
            thirdColumn[0] != false
        ) {
            gameIsWon = true;
            return gameIsWon;
        }

        return gameIsWon;
    }

    // Returns 'true' if all cells in a row are taken and equal
    function horizontalWinCheck(dashboard) {
        let gameIsWon = false;

        for (let row = 0; row < dashboard.length; row++) {
            if (
                dashboard[row][0] == dashboard[row][1] &&
                dashboard[row][1] == dashboard[row][2] &&
                dashboard[row][0] != false
            ) {
                gameIsWon = true;
                break;
            }
        }

        return gameIsWon;
    }

    // Returns 'true' if all cells in one of the diagonals are taken and equal.
    function diagonalWinCheck(dashboard){
        let gameIsWon = false;
        let row = 0;
        let column = 0;

        // Check up-left -> down-right diagonal
        if (
            dashboard[row][column] == dashboard[row + 1][column + 1] &&
            dashboard[row + 1][column + 1] == dashboard[row + 2][column + 2] &&
            dashboard[row][column] != false
        ) {
            gameIsWon = true;
            return gameIsWon;
        }

        column = 2;
        // Check up-right -> down-left diagonal
        if (
            dashboard[row][column] == dashboard[row + 1][column - 1] &&
            dashboard[row + 1][column - 1] == dashboard[row + 2][column - 2] &&
            dashboard[row][column] != false
        ) {
            gameIsWon = true;
            return gameIsWon;
        }

        return gameIsWon;
    }

    // Returns message with the winner if game is won or returns empty string.
    function winCheck(dashboard, playerOnTurn) {
        let gameIsWon = false;
        let message = '';
        
        if (horizontalWinCheck(dashboard) == false) {
            if (verticalWinCheck(dashboard) == false) {
                if (diagonalWinCheck(dashboard) == false) {
                    gameIsWon = false;
                } else {
                    gameIsWon = true;
                }
            } else {
                gameIsWon = true;
            }
        } else {
            gameIsWon = true;
        }

        if (gameIsWon) {
            if (playerOnTurn == 'firstPlayer') {
                message = `Player ${firstPlayerMark} wins!`;
            } else {
                message = `Player ${secondPlayerMark} wins!`;
            }
        }

        return message;
    }
    
    // Program logic
    for (const currentCoordinate of matrixOfCoordinates) {
        rowCoordinate = Number(currentCoordinate[0]);
        columnCoordinate = Number(currentCoordinate[2]);
        let winningMessage = '';
        let boardIsOutOfSpace = false;

        // Check if cell with given coordinates is empty
        if (dashboard[rowCoordinate][columnCoordinate] == false) {
            if (playerOnTurn == 'firstPlayer') {
                dashboard[rowCoordinate][columnCoordinate] = firstPlayerMark;
            } else {
                dashboard[rowCoordinate][columnCoordinate] = secondPlayerMark;
            }

            // Check if current move is winning the game and show message with the winner if it is
            winningMessage = winCheck(dashboard, playerOnTurn);
            if (winningMessage != '') {
                console.log(winningMessage);
                break;
            }

            // Check if all cells in dashboard are not empty and end the game
            for (let row = 0; row < dashboard.length; row++) {
                const currentRow = dashboard[row];
                hasEmptyCell = false;

                for (const cell of currentRow) {
                    if (cell == false) {
                        hasEmptyCell = true;
                        break;
                    }
                }

                if (hasEmptyCell) {
                    break;
                } else if (hasEmptyCell == false && row == dashboard.length - 1) {
                    boardIsOutOfSpace = true;
                }
            }

            // Print message to announce that game has ended
            if (boardIsOutOfSpace) {
                console.log(`The game ended! Nobody wins :(`);
                break;
            }

            // Next player turn
            playerOnTurn = switchTurn(playerOnTurn);

        } else {
            console.log(`This place is already taken. Please choose another!`);
        }
    }

    // Print final state of dashboard
    for (const innerArray of dashboard) {
        console.log(innerArray.join('\t'));
    }

}