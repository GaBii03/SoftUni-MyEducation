function larggest(a,b,c){
    let larggestNum;
    if(a>b && a>c)
    {
        larggestNum = a;
    }
    else if(b>a && b>c)
    {
        larggestNum = b;
    }
    else if(c>a && c>b)
    {
        larggestNum = c;
    }

    console.log(`The largest number is ${larggestNum}.`)
}
