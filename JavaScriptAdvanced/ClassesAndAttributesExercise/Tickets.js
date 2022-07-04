function solve(input, sortingCriteria){

    class Ticket{
        constructor(destination, price, status){
            this.destination = destination;
            this.price = Number(price);
            this.status = status;
        }
    }

    let ticketsArray = [];
    
    for (let index = 0; index < input.length; index++) {
        const element = input[index];
        
        let destination = String(element).split('|')[0];
        let price = String(element).split('|')[1];
        let status = String(element).split('|')[2];

        let currentTicket = new Ticket(destination, price, status);
        ticketsArray.push(currentTicket);
    }

    if (sortingCriteria == 'destination') {
        ticketsArray.sort((x, y) => String(x.destination).localeCompare(String(y.destination)));
    } else if (sortingCriteria == 'status') {
        ticketsArray.sort((x, y) => String(x.status).localeCompare(String(y.status)));
    } else {
        ticketsArray.sort((x, y) => x.destination - y.destination);
    }

    return ticketsArray;
}