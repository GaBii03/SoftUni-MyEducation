function solve(array, num){

    for (let index = 1; index <= num; index++) {
        let element = array.pop();
        array.unshift(element);
    }

    console.log(array.join(' '));
}