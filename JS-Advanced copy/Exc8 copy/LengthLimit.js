class Stringer{

    // innerString = string;
    // innerLength = currLength;
    constructor(string, currLength){
        this.innerString = string;
        this.innerLength = currLength; 
    }

    increase(length){
        this.innerLength += length;
    }

    decrease(length){
        if(this.innerLength-length<0){
            this.innerLength = 0;
        }else{
            this.innerLength -= length;
        }
        
    }

    toString(){
        let output = '';
        for (let index = 0; index < this.innerString.length; index++) {
            if(index>=this.innerLength){
                output+='...'
                break;
            }else{
              output+=this.innerString[index];  
            }
            
        }

        return output;
    }
}

let test = new Stringer("Test", 5);
console.log(test.toString()); // Test
test.decrease(3);
console.log(test.toString()); // Te...
test.decrease(5);
console.log(test.toString()); // ...
test.increase(4);
 console.log(test.toString()); // Test