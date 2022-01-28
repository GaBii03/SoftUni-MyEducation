function solve(array){

    let initialNumber = 1;
    let newArray = [];
    for (let index = 0; index < array.length; index++) {
        
        let command = array[index];
        if(command == 'add'){
            newArray.push(initialNumber);
        }else if(command == 'remove'){
            newArray.pop();
        }
        initialNumber++;
    }

    if(newArray.length>0){
        for (let index = 0; index < newArray.length; index++) {
            
            console.log(newArray[index]);
        }
    }else{
        console.log('Empty');
    }
}

solve(['add', 'add', 'add', 'add']);
console.log('-----------------------');
solve(['add', 'add', 'remove', 'add', 'add']);