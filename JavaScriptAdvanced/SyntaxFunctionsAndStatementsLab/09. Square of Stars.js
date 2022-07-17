function solve(size){

    let result = '';
    for (let i = 0; i < size; i++) {
        for (let j = 0; j < size; j++) {
            if (j < size - 1) {
                result += '* ';
            } else {
                result += '*\r\n';
            }
        }
        
    }

    console.log(result);
}