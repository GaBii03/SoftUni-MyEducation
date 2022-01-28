function colorize() {
    //First solution not working for judge
    /*let rowElements = document.querySelectorAll('tr:nth-of-type(2n) td');

    rowElements.forEach(x => {
        x.style.backgroundColor = 'teal';
    });*/

    // Second solution
    let rowElements = document.getElementsByTagName('tr');

    // Convert to array
    let rows = Array.from(rowElements);

    rows.forEach((x, i) => {
        if (i % 2 != 0) {
            x.style.backgroundColor = 'teal';
        }
    });

}