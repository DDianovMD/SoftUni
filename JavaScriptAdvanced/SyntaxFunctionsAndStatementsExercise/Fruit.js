function solve(fruitName, weightInGrams, price){
    let weightInKilograms = weightInGrams / 1000;

    console.log(`I need $${(price * weightInKilograms).toFixed(2)} to buy ${weightInKilograms.toFixed(2)} kilograms ${fruitName}.`)
}
