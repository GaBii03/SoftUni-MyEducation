const expect = require('chai').expect;
const {testNumbers} = require('./testNumbers');

describe('Test Numbers', () => {

    describe('Sum numbers tests', () => {
        it('Should return undefined when first num is not Number', () =>{
            expect(testNumbers.sumNumbers('a', 3)).to.be.undefined;
        });
        it('Should return undefined when second num is not Number', () =>{
            expect(testNumbers.sumNumbers(3, '3')).to.be.undefined;
        });
        it('Should return undefined when both first and second nums are not Numbers', () =>{
            expect(testNumbers.sumNumbers('a', 'r')).to.be.undefined;
        });
        it('Should return the sum fixed to secod decimal point(1)', () => {
            let expectOutput = 0.00;
            expect(testNumbers.sumNumbers(0,0)).to.equal(expectOutput.toFixed(2));
        });
        it('Should return the sum fixed to secod decimal point(2)', () => {
            let expectOutput = 10.00;
            expect(testNumbers.sumNumbers(5,5)).to.equal(expectOutput.toFixed(2));
        });
        it('Should return the sum fixed to secod decimal point(3)', () => {
            let expectOutput = 11.50;
            expect(testNumbers.sumNumbers(10.5,1)).to.equal(expectOutput.toFixed(2));
        });
        it('Should return the sum fixed to secod decimal point(4)', () => {
            let expectOutput = 12.00;
            expect(testNumbers.sumNumbers(10.5,1.5)).to.equal(expectOutput.toFixed(2));
        });
    });

    describe('Number checker tests',() =>{
        it('Should throw error if the input is not a number(string with text)', () =>{
            expect(() =>{testNumbers.numberChecker('hey')}).to.throw('The input is not a number!');
        });
        it('Should throw error if the input is not a number(array)', () =>{
            expect(() =>{testNumbers.numberChecker(['hey'])}).to.throw('The input is not a number!');
        });
        it('Should throw error if the input is not a number(object)', () =>{
            expect(() =>{testNumbers.numberChecker({name: 'hey'})}).to.throw('The input is not a number!');
        });
        it('Should return even(string with even number)', () =>{
            expect(testNumbers.numberChecker('2')).to.equal('The number is even!')
        });
        it('Should return odd(string with odd number)', () =>{
            expect(testNumbers.numberChecker('3')).to.equal('The number is odd!')
        });
        it('Should return even(even number)', () =>{
            expect(testNumbers.numberChecker(2)).to.equal('The number is even!')
        });
        it('Should return odd(odd number)', () =>{
            expect(testNumbers.numberChecker(3)).to.equal('The number is odd!')
        });

    });

    describe('Average sum array tests', () =>{
        it('Should return the avarage sum of the nubers in the array(1)',() =>{
            expect(testNumbers.averageSumArray([2,2,2,2,2,2])).to.equal(2);
        });
        it('Should return the avarage sum of the nubers in the array(2)',() =>{
            expect(testNumbers.averageSumArray([2,4,6,8,2,2])).to.equal(4);
        });
        it('Should return the avarage sum of the nubers in the array(3)',() =>{
            expect(testNumbers.averageSumArray([2.2, 2.2, 2.2])).to.equal(2.2);
        });
        it('Should return the avarage sum of the nubers in the array(4)',() =>{
            expect(testNumbers.averageSumArray([2.2,3.3, 2.2, 2.2])).to.equal(2.475);
        });
    })
});