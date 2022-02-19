function createCalculator(){
    let value = 0;
    return{
        add: function(num) {value += Number(num);},
        subtract: function(num) {value -= Number(num);},
        get: function() {return value;}
    }
}

module.exports = {createCalculator};

let output = createCalculator();
output.add(10);
output.add(100);
output.subtract(20);
console.log(output.get());
