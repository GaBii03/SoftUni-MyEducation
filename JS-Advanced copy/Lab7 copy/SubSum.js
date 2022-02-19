function solve(numbersAsArray, start, end){
    if(!Array.isArray(numbersAsArray)){
        return NaN;
    }
    let startIndex = Math.max(start,0);
    let endIndex = Math.min(end, numbersAsArray.length - 1);

    let sum = numbersAsArray.slice(startIndex, endIndex+1)
                            .reduce((a,x) => a + Number(x), 0);
    return sum;
}

console.log(solve([10, 20, 30, 40, 50, 60], 3, 300)); //150
console.log(solve([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1)); //3.3
console.log(solve([10, 'twenty', 30, 40], 0, 2)); //NaN
console.log(solve([], 1, 2)); //0
console.log(solve('text', 0, 2)); //NaN