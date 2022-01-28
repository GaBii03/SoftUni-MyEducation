function solve(arrayNames){

    arrayNames.sort((a, b) => a.localeCompare(b));
    for (let index = 1; index <= arrayNames.length; index++) {
        
        console.log(`${index}.${arrayNames[index-1]}`);
    }
}

solve(["John", "Bob", "Christina", "Ema"]);