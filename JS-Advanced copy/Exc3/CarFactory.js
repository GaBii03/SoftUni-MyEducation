function solve(object){

    let output = {};
    let engine = {};
    let carrige = {};
    output['model'] = object.model;
    if(object.power<=90){
        engine['power'] = 90;
        engine['volume'] = 1800;
    }else if(object.power<=120){
        engine['power'] = 120;
        engine['volume'] = 2400;
    }else if(object.power<=200){
        engine['power'] = 200;
        engine['volume'] = 3500;
    }

    output['engine'] = engine;

    carrige['type'] = object.carriage;
    carrige['color'] = object.color;

    output['carrige'] = carrige;

    let wheelSize = 0;
    let wheelSizeArr = [];
    if(object.wheelsize % 2 == 0){
        wheelSize = object.wheelsize - 1;
    }else{
        wheelSize = object.wheelsize;
    }

    for (let index = 0; index < 4; index++) {
        
        wheelSizeArr[index] = wheelSize;
    }

    output['wheels'] = wheelSizeArr;

    //return output;
    console.log(output);

}

solve({
    model: 'Brichka',
    power: 65,
    color: 'white',
    carriage: 'hatchback',
    wheelsize: 16
});