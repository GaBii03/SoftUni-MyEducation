function solve(numbers){

    let newArray = [];
    numbers.sort((a, b) => a - b);
    let isEven = true;

    if(numbers.length%2!=0){
        isEven = false;
    }

    let counter = 0;
    if(isEven){
        for (let index = numbers.length/2; index <= numbers.length -1; index++) {

            newArray[counter] = numbers[index];
            counter++;
        }
    }else{
        for (let index = numbers.length/2 - 0.5; index <= numbers.length -1; index++) {

            newArray[counter] = numbers[index];
            counter++;
        }
    }

    return newArray;
}

solve([4, 7, 2, 5]);
solve([3, 19, 14, 7, 2, 19, 6]);