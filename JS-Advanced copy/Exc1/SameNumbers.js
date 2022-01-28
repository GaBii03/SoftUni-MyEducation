function solve(number){

    let numberAsString = number.toString();
    let length = numberAsString.length;
    let isSame = true;
    let sum = Number(numberAsString[length-1]);

    for (let index = 0; index < length-1; index++) {

        let number = Number(numberAsString[index]);
        sum+=number;
        if(numberAsString[index] !== numberAsString[index+1]){
            isSame = false;
        }
    }

    console.log(isSame);
    console.log(sum);
}

solve(2222);