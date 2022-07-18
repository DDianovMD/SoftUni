function solve(array){

    array.sort((x, y) => x.localeCompare(y));

    for (let i = 0; i < array.length; i++) {
        const element = array[i];
        console.log(`${i+1}.${element}`);
    }

}