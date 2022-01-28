function solve(n, k){

    numbers = [];
    let currNum = 0;
    for (let index = 0; index < n; index++) {
        if(index<k-1){
            numbers[index] = 1; 
        }else if(index==k){
            for (let index1 = 1; index1 < k; index1++) {
                currNum += numbers[index - index1];
            }
            numbers[index] = currNum;
            currNum = 0;
        }else{
            for (let index1 = 1; index1 <= k; index1++) {
                currNum += numbers[index - index1];
            }
            numbers[index] = currNum;
            currNum = 0;
        }
    }

    console.log(numbers);
}

solve(6,3);