function solve(array){ //NOT SOLVED!!!!!!!!!!!
    
    let bottles = new Map();

    for (let index = 0; index < array.length; index++) {

        let info = array[index].split(' => ');
        let fruit = info[0];
        let quantity = Number(info[1]);

        if(bottles.has(fruit)){
            let allQuan = bottles.get(fruit);
            allQuan+=quantity;
            bottles[fruit]  =allQuan;
        }else{
            bottles.set(fruit, quantity)
        }
        // if(bottles.has(fruit)){
        //     quantity += bottles.get(fruit);
        //     bottles.delete(fruit);
        // }

        // bottles.set(fruit, quantity);
        
    }

    for (const key of bottles) {
        let number = 0;
        if(key[1]>1000){
            let left = key[1] % 1000;
            number = (key[1] - left)/1000;
        }
        
        if(number>0){
            console.log(`${key[0]} => ${number}`);
        }
        
    }
}

solve(['Orange => 2000',
       'Peach => 1432',
       'Banana => 450',
       'Peach => 600',
       'Strawberry => 549']);