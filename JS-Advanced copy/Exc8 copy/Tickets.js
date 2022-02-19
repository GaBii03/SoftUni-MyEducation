function solve(array, criteria){
 
   class Ticket{
        constructor(destination, price, status){
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }
    let destination = '';
    let price = 0;
    let status = '';

    let allTickets = [];
    for (let index = 0; index < array.length; index++) {
        let currentTicketInfo = array[index].split('|');
        destination = currentTicketInfo[0];
        price = Number(currentTicketInfo[1]);
        status = currentTicketInfo[2];
        let currentTicket = new Ticket(destination, price ,status);
        allTickets[index] =currentTicket;
    }

    if(criteria == 'destination'){
        allTickets.sort((a,b) =>{
            return a.destination.localeCompare(b.destination);
        })
    }else if(criteria == 'status'){
        allTickets.sort((a,b) =>{
            return a.status.localeCompare(b.status);
        })
    }else if(criteria = 'price'){
        allTickets.sort((a,b) =>{
            return a.price - b.price
        })
    }

    return allTickets;
}

console.log(solve(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'destination'));