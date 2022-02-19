/*function solve(array){
    let result  = [];

    for (const eachPiece of array) {
        let [command, string] = eachPiece.split(' ');

        if(command == 'add'){
            result.push(string);
        }else if(command == 'remove'){
            result = result.filter(word => word!=string);
        }else{
            console.log(result.join(','));
        }
    }
}

solve(['add pesho', 'add george', 'add peter', 'remove peter','print']);*/


function solve2(array){

    result = [];

    for (const eachPiece of array) {
        let [command, string] = eachPiece.split(' ');

        if(command == 'add'){
            add(string);
        }else if(command == 'remove'){
            remove(string);
        }else{
            print();
        }
    }

    function add(stringInp){
        result.push(stringInp);
    }

    function remove(stringInp){
        result = result.filter(word => word!=stringInp);
    }

    function print(){
        console.log(result.join(','));
    }
}
solve2(['add pesho', 'add george', 'add peter', 'remove peter','print']);

