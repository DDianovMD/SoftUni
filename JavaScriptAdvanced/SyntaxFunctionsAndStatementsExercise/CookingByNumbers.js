function solve(number, arg1, arg2, arg3, arg4, arg5){
    let num = Number(number);
    let operations = [arg1, arg2, arg3, arg4, arg5];

    for (let i = 0; i < operations.length; i++) {
        const element = operations[i];
        
        if (element == 'chop') {
            num /= 2;
        } else if (element == 'dice') {
            num = Math.sqrt(num);
        } else if (element == 'spice') {
            num += 1;
        } else if (element == 'bake') {
            num *= 3;
        } else if (element == 'fillet') {
            num -= num * 0.2;
        }

        console.log(num);
    }
}