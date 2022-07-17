function solve(num1, num2){

    let sum = 0;

    for (let i = Number(num1); i <= Number(num2); i++) {
        const element = i;
        
        sum += element;
    }

    console.log(sum);
}