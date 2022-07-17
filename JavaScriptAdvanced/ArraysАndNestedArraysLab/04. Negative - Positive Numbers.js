function solve(array){

    let result = [];

    for (let i = 0; i < array.length; i++) {
        const element = array[i];
        
        if (element < 0) {
            result.unshift(element);
        } else {
            result.push(element);
        }
    }

    result.forEach(x => console.log(x));
    
}