function solve(fruit, weighInGrams, pricePerKilo){

    let weightInKilo = weighInGrams/1000;
    let money = weightInKilo*pricePerKilo;
    console.log(`I need $${money.toFixed(2)} to buy ${weightInKilo.toFixed(2)} kilograms ${fruit}.`);
}