function solve (numbers){

    numbers.sort((a,b) => a - b);
    let newArray = [numbers[0], numbers[1]];
    console.log(newArray);
}

solve([30, 15, 50, 5]);