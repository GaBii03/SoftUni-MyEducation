function solve(year, month, date){

    let dateInput = `${year}-${month}-${date}`;
    let currDate = new Date(dateInput);
    currDate.setDate(currDate.getDate()-1);
    console.log(`${currDate.getFullYear()}-${currDate.getMonth()+1}-${currDate.getDate()}`);
}

