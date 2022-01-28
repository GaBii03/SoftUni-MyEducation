function solve(array){

    let first = Number(array.shift());
    let last = Number(array.pop());
    let sum = first+last;
    return sum;
}

console.log(solve(['20', '30', '40']));