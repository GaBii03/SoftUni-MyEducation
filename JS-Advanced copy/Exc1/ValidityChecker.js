function solve(x1, y1, x2, y2){

    let sum1 = Math.sqrt(((x1-y1)**2));
    let sum2 = Math.sqrt(((x2-y2)**2));
    let sum3 = Math.sqrt(((x1-x2)**2)+((y1-y2)**2));

    if(Number.isInteger(sum1)){
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    }else{
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }

    if(Number.isInteger(sum2)){
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    }else{
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }

    if(Number.isInteger(sum3)){
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    }else{
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
}

//solve(3, 0, 0, 4);
solve(2, 1, 1, 1);
    