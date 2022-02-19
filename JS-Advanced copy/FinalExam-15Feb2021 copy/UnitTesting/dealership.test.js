const expect = require('chai').expect;
const {dealership} = require('./03.Dealership')

describe('Dealership tests', () => {

    describe('New Car Cost tests', () => {
        it('Shoul return the new price with the discount(1)', () => {
            expect(dealership.newCarCost('Audi A4 B8', 30000)).to.equal(15000);
        });
        it('Shoul return the new price with the discount(2)', () => {
            expect(dealership.newCarCost('Audi A6 4K', 30000)).to.equal(10000);
        });
        it('Shoul return the new price with the discount(3)', () => {
            expect(dealership.newCarCost('Audi A8 D5', 30000)).to.equal(5000);
        });
        it('Shoul return the new price with the discount(4)', () => {
            expect(dealership.newCarCost('Audi TT 8J', 30000)).to.equal(16000);
        });
        it('Should return the new price(1)', () =>{
            expect(dealership.newCarCost('Audi A7', 30000)).to.equal(30000);
        });
        it('Should return the new price(2)', () =>{
            expect(dealership.newCarCost('Audi A8', 30000)).to.equal(30000);
        });

    });

    describe('Car Equipment tests', () => {

        it('Shoul return array with the selected equipment(1)', () =>{
            expect(dealership.carEquipment(['heated seats', 'sliding roof', 'sport rims', 'navigation'],[0,1])).to.deep.equal(['heated seats', 'sliding roof']);
        });

        it('Shoul return array with the selected equipment(2)', () =>{
            expect(dealership.carEquipment(['heated seats', 'sliding roof', 'sport rims', 'navigation'],[0])).to.deep.equal(['heated seats']);
        });

        it('Shoul return array with the selected equipment(3)', () =>{
            expect(dealership.carEquipment(['heated seats', 'sliding roof', 'sport rims', 'navigation'],[2])).to.deep.equal(['sport rims']);
        });
    });

    describe('Euro Category tests', () => {
        it('Should return that there is no discount if the category is under 4(1)', () => {
            expect(dealership.euroCategory(1)).to.equal('Your euro category is low, so there is no discount from the final price!');
        });
        it('Should return that there is no discount if the category is under 4(2)', () => {
            expect(dealership.euroCategory(2)).to.equal('Your euro category is low, so there is no discount from the final price!');
        });
        it('Should return that there is no discount if the category is under 4(3)', () => {
            expect(dealership.euroCategory(3)).to.equal('Your euro category is low, so there is no discount from the final price!');
        });
        it('Shoul return the price with the discount if the category is 4 or more than 4(4)', () => {
            expect(dealership.euroCategory(4)).to.equal(`We have added 5% discount to the final price: 14250.`);
        });
        it('Shoul return the price with the discount if the category is 4 or more than 4(5)', () => {
            expect(dealership.euroCategory(5)).to.equal(`We have added 5% discount to the final price: 14250.`);
        });
        it('Shoul return the price with the discount if the category is 4 or more than 4(8)', () => {
            expect(dealership.euroCategory(8)).to.equal(`We have added 5% discount to the final price: 14250.`);
        });
    });
    
});