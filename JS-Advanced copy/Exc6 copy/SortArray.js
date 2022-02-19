function solve(array, theWay){
    if(theWay == 'asc'){
        return array.sort((a,b) => a-b);
    }else if(theWay == 'desc'){
        return array.sort((a,b) => b-a);
    }
}

solve([14, 7, 17, 6, 8], 'desc');