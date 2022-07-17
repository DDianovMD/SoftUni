function solve(array){

    let result = '';

    for (let i = 0; i < array.length; i++) {
        const element = array[i];
        
        if (i % 2 == 0) {
            result += `${String(element)} `;
        }
    }

    console.log(result);
}