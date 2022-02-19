function solve(face, suit){
    const facesNums = ['2', '3', '4', '5', '6', '7', '8', '9', '10']
    const facesLetters =['J', 'Q', 'K', 'A'];
    const suitsTypes = ['S', 'H', 'D', 'C'];
    const suits = {
        S: '\u2660',
        H: '\u2665',
        D: '\u2666',
        C: '\u2663',
    };

    if(!facesNums.includes(face) && !facesLetters.includes(face)){
        throw new Error('Error');
    }

    if(!suitsTypes.includes(suit)){
        throw new Error('Error');
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

let card = solve('A', 'S');
card.toString();

