function solve(array, number){

    let newArray = [];
    let counter = 0;
    for (let index = 0; index < array.length; index+=number) {
        
        newArray[counter] = array[index];
        counter++;
    }

    return newArray;
}

console.log(solve(['5', '20', '31', '4', '20'], 2));