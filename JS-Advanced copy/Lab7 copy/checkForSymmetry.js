function isSymmetric(arr) {
    if (!Array.isArray(arr)){        
        return false; // Non-arrays are non-symmetric
    }    
    let reversed = arr.slice(0).reverse();
    let equal = (JSON.stringify(arr) == JSON.stringify(reversed));    
    return equal;
}


console.log(isSymmetric([100]));
console.log(isSymmetric(['yes', 'no', 'maybe', 'no', 'yes']));
console.log(isSymmetric(['yes', 'no', 'maybe', 'yes', 'yes']));
console.log(isSymmetric([1, 2, 3, 4, 5, 4, 3, 2, '1']));

module.exports = isSymmetric;