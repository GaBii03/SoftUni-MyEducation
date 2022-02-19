const expect = require('chai').expect;
const {cinema} = require('./cinema')

describe("Cinema", function() {

    describe("Show Mivie tests", function() {  

        it("Should return error if the length of the array is zero", function() {
            expect(cinema.showMovies([])).to.equal("There are currently no movies to show.");
        });
        it("Should return the available movies separated by comma and space(1)", function() {
            expect(cinema.showMovies(['My movie', 'Spiderman', 'Now', 'After']))
            .to.equal("My movie, Spiderman, Now, After");
        });
        it("Should return the available movies separated by comma and space(2)", function() {
            expect(cinema.showMovies(['My Movie', 'Spiderman', 'Now', 'After2']))
            .to.equal("My Movie, Spiderman, Now, After2");
        });
        it("Should return the available movies separated by comma and space(3)", function() {
            expect(cinema.showMovies(['My movie']))
            .to.equal('My movie');
        });
    }); 
    
    describe('Ticket price tests', () =>{

        it('Should throw error if the projection type is not valid(1)',() =>{
            expect(() => cinema.ticketPrice('kid')).to.throw('Invalid projection type.');
        });
        it('Should throw error if the projection type is not valid(2)',() =>{
            expect(() => cinema.ticketPrice('')).to.throw('Invalid projection type.');
        });
        it('Should throw error if the projection type is not valid(3)',() =>{
            expect(() => cinema.ticketPrice([])).to.throw('Invalid projection type.');
        });
        it('Should return the correct ptice when the type is premiere', ()=>{
            expect(cinema.ticketPrice('Premiere')).to.equal(12.00);
        });
        it('Should return the correct ptice when the type is Normal', ()=>{
            expect(cinema.ticketPrice('Normal')).to.equal(7.50);
        });
        it('Should return the correct ptice when the type is Discount', ()=>{
            expect(cinema.ticketPrice('Discount')).to.equal(5.50);
        });
    });

    describe('Swap seats in hall', () => {
        it('Should return successful change when the input is valid(1)', () =>  {
            expect(cinema.swapSeatsInHall(2,4)).to.equal("Successful change of seats in the hall.");
        })
        it('Should return successful change when the input is valid(2)', () =>  {
            expect(cinema.swapSeatsInHall(1,20)).to.equal("Successful change of seats in the hall.");
        })
        it('Should return successful change when the input is valid(3)', () =>  {
            expect(cinema.swapSeatsInHall(20,1)).to.equal("Successful change of seats in the hall.");
        })
        it('Should return error if the first input is not a number', () => {
            expect(cinema.swapSeatsInHall('now', 3)).to.equal("Unsuccessful change of seats in the hall.");
        });
        it('Should return error if the second input is not a number', () => {
            expect(cinema.swapSeatsInHall(2, 'now')).to.equal("Unsuccessful change of seats in the hall.");
        });
        it('Should return error if both inputs are not numbers', () => {
            expect(cinema.swapSeatsInHall('now', 'before')).to.equal("Unsuccessful change of seats in the hall.");
        });
        it('Should return error if first input is zero', () => {
            expect(cinema.swapSeatsInHall(0, 5)).to.equal("Unsuccessful change of seats in the hall.");
        });
        it('Should return error if second input is zero', () => {
            expect(cinema.swapSeatsInHall(5, 0)).to.equal("Unsuccessful change of seats in the hall.");
        });
        it('Should return error if both inputs are zeros', () => {
            expect(cinema.swapSeatsInHall(0, 0)).to.equal("Unsuccessful change of seats in the hall.");
        });
        it('Should return error if first input is below zero', () => {
            expect(cinema.swapSeatsInHall(-2, 5)).to.equal("Unsuccessful change of seats in the hall.");
        });
        it('Should return error if second input is below zero', () => {
            expect(cinema.swapSeatsInHall(-5, 5)).to.equal("Unsuccessful change of seats in the hall.");
        });
        it('Should return error if both inputs are below zero', () => {
            expect(cinema.swapSeatsInHall(-2, -3)).to.equal("Unsuccessful change of seats in the hall.");
        });
        it('Should return error if first input is over 20', () => {
            expect(cinema.swapSeatsInHall(21, 5)).to.equal("Unsuccessful change of seats in the hall.");
        });
        it('Should return error if second input is over 20', () => {
            expect(cinema.swapSeatsInHall(5, 25)).to.equal("Unsuccessful change of seats in the hall.");
        });
        it('Should return error if both inputs are over 20', () => {
            expect(cinema.swapSeatsInHall(21, 30)).to.equal("Unsuccessful change of seats in the hall.");
        });
        it('Should return error if inputs are valid but equal', () => {
            expect(cinema.swapSeatsInHall(5, 5)).to.equal("Unsuccessful change of seats in the hall.");
        });
    });
});