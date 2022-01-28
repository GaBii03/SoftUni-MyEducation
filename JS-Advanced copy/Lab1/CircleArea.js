function solution(a){
    let result;
    let type = typeof(a);
    if(type == 'number'){
        result = (a**2 * Math.PI).toFixed(2);
    }else{
        result = `We can not calculate the circle area, because we receive a ${type}.`;
    }

    console.log(result);
}

solution(5);