function solve(array){

    let newArr = [];
    let counter = 0;
    for (let index = 0; index < array.length; index++) {
       
        if(index == 0){
            newArr[counter] = array[0];
            counter++;
            continue;
        }

        if(array[index]>newArr[counter-1]){
            newArr[counter] = array[index];
            counter++; 
        }

    }

    return newArr;
}

console.log(solve([1, 3, 8, 4, 10, 12, 3, 2, 24]));