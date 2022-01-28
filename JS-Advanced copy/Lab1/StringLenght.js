function lenght(a, b, c){
    let sum ;
    let average;

    let aLength = a.length;
    let bLength = b.length;
    let cLength = c.length;
    sum = aLength+bLength+cLength;
    average = Math.floor(sum / 3);

    console.log(sum);
    console.log(average);
}
