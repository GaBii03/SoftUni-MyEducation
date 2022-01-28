function solve(speed, area){

    let isSpeeding = false;
    let status = '';
    let output = '';
    let currSpeedLimit = 0;
    let speedUp = 0;

    if(area == 'motorway'){
        currSpeedLimit = 130;
    }else if(area == 'interstate'){
        currSpeedLimit = 90;
    }else if(area == 'city'){
        currSpeedLimit = 50;
    }else if(area == 'residential'){
        currSpeedLimit = 20;
    }

    if(speed>currSpeedLimit){
        isSpeeding = true;
        speedUp = speed - currSpeedLimit;
        if(speedUp <= 20){
            status = 'speeding';
        }else if(speedUp <= 40){
            status = 'excessive speeding';
        }else{
            status = 'reckless driving';
        }
    }

    if(isSpeeding){
        output = `The speed is ${speedUp} km/h faster than the allowed speed of ${currSpeedLimit} - ${status}`;
    }else{
        output =`Driving ${speed} km/h in a ${currSpeedLimit} zone`;
    }

    console.log(output);
}

solve(21, 'residential');