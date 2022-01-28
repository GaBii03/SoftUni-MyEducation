function solve(array){

    let resultArr = [];
    array = array.sort((a,b)=> a-b);
    let interations = array.length;

    for (let index = 0; index < interations; index++) {
        let currentElement = 0;
        if(index%2==0){
            currentElement = array.shift();
        }else{
            currentElement = array.pop();
        }

        resultArr.push(currentElement);
    }

    return resultArr;
}