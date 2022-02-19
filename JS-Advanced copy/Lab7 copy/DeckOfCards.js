function printDeckOfCards(cards) {
    let result = '';

    function createCard (input){
        let output = '';
        let face = input[0] + input[1];
        let suit = input[2];

        if(input.length == 2){
            face = input[0];
            suit = input[1];
        }
        
        const faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
        const suits = {
            S: '\u2660',
            H: '\u2665',
            D: '\u2666',
            C: '\u2663',
        };
        
        if(!faces.includes(face) || !suits.hasOwnProperty(suit)){
            output = `Invalid card: ${face}${suit}`;
            return output;
        }
        
        let card = {
            face,
            suit, 
            toString(){
                 return this.face + suits[this.suit];
             }
         };
        
         return card;
    }

    for (let index = 0; index < cards.length; index++) {
        let input = cards[index];
       
        let resultFromFunc = createCard(input);
        if(resultFromFunc === `Invalid card: ${input}`){
            result = resultFromFunc;
            break;
        }else{
            result += resultFromFunc.toString() + ' ';
        }
        
        
    }

    console.log(result);
  }

  let output = printDeckOfCards(['5S', '3D', 'QD', '1C']);

  