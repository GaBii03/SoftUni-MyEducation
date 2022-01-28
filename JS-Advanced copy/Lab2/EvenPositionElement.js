function solve(numbers){

    let result = '';
    for (let index = 0; index < numbers.length; index+=2) {

        result += numbers[index] + ' ';
    }

    console.log(result);
}

solve([11, 33, 44, 55, 22, 534, 999]);