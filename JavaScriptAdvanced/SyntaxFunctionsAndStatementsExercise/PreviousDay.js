function solve(year, month, day){
    let givenDate = new Date(String(year), String(month), String(day));

    if (givenDate.getDate() == 1) {
        givenDate.setDate(givenDate.getDate() - 2);
    } else {
        givenDate.setDate(givenDate.getDate() - 1);
    }
    
    
    console.log(`${givenDate.getFullYear()}-${givenDate.getMonth()}-${givenDate.getDate()}`);
}