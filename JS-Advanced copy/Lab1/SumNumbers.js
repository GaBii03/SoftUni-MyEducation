function solve(n, m){
    let first = Number(n);
    let last = Number(m);
    let sum =0;
    for (let index = first; index <= last; index++) {
        sum+= index;
    }

    console.log(sum);
}

solve('1','5')