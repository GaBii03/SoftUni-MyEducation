function solve(numAsString, one, two, three, four, five){

    let number = Number(numAsString);
    let commands = [one, two, three, four, five];

    for (let index = 0; index < commands.length; index++) {
        switch(commands[index]){
            case 'chop': number/=2; break;
            case 'dice': number = Math.sqrt(number); break;
            case 'spice': number += 1; break;
            case 'bake': number *= 3; break;
            case 'fillet': number *= 0.80; break;
        }
        console.log(number);
    }
}

//solve('32', 'chop', 'chop', 'chop', 'chop', 'chop');
solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet');