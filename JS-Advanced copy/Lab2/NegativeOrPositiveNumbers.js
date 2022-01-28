function solve(numbersArray){

    let newNumbersArray = [];
    for (let index = 0; index < numbersArray.length; index++) {
        let currNumber = Number(numbersArray[index]);
        if(currNumber<0){
            newNumbersArray.unshift(currNumber);
        }else{
            newNumbersArray.push(currNumber);
        }
    }

    for (let index = 0; index < newNumbersArray.length; index++) {
        
        console.log(newNumbersArray[index]);
    }
}

solve([7, -2, 8, 9]);