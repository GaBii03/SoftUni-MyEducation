function solve(array){

    let titles = serializedRow(array[0]);
    let rows = array
      .slice(1)
      .map(row => serializedRow(row).reduce((acc, el, i) => {
        acc[titles[i]] = el;
        return acc;
      }, {}));

     return JSON.stringify(rows);

    function serializedRow(str){
        return str
         .split(/\s*\|\s*/gim)
         .filter(x => x !== '')
         .map(x => isNaN(Number(x)) ? x : Number(Number(x).toFixed(2)));
    }
}

console.log(solve(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']));