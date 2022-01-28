function solve(num1, num2){

    let smallOne = num1;
    if(num1>num2){
        smallOne = num2;
    }

    let greatestCommonDevisor;
    for (let index = smallOne; index > 0; index--) {
        
        if(num1%index==0 && num2 %index==0){
            greatestCommonDevisor = index;
            break;
        }
    }

    console.log(greatestCommonDevisor);
}