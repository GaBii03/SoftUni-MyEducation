function solve(numbers){

    let oddNumbers = [];
    for (let index = 1; index < numbers.length; index+=2) {
        
        oddNumbers.unshift(numbers[index]*2);
    }

    console.log(oddNumbers.join(' '));
}

solve([22, 555, 43, 77, 2]);