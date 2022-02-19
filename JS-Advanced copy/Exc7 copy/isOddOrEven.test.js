const expect = require('chai').expect;
const isOddOrEven = require('./isOddOrEven');

describe('Is Odd Or Even', () => {
    it('Should check if the program return undefined with no string input(1)', () => {
        let input = 10;
        let actualOutput = isOddOrEven(input);
        expect(actualOutput).to.be.undefined;
    });

    it('Should check if the program return undefined with no string input(2)', () => {
        let input = {};
        let actualOutput = isOddOrEven(input);
        expect(actualOutput).to.be.undefined;
    });

    it('Should check if the program return undefined with no string input(3)', () => {
        let input = [1,2,3,4];
        let actualOutput = isOddOrEven(input);
        expect(actualOutput).to.be.undefined;
    });

    it('Should check if the program return undefined with no string input(4)', () => {
        let input = ['yes', 'no', 'maybe'];
        let actualOutput = isOddOrEven(input);
        expect(actualOutput).to.be.undefined;
    });

    it('Should work correct and return even when the input lenght is even(1)', () => {
        let input = 'book';
        let expectedOutput = 'even';
        let actualOutput = isOddOrEven(input);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should work correct and return even when the input lenght is even(2)', () => {
        let input = 'headphones';
        let expectedOutput = 'even';
        let actualOutput = isOddOrEven(input);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should work correct and return even when the input lenght is even(3)', () => {
        let input = 'easy';
        let expectedOutput = 'even';
        let actualOutput = isOddOrEven(input);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should work correct and return odd when the input lenght is odd(1)', () => {
        let input = 'isolation';
        let expectedOutput = 'odd';
        let actualOutput = isOddOrEven(input);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should work correct and return odd when the input lenght is odd(2)', () => {
        let input = 'bottles';
        let expectedOutput = 'odd';
        let actualOutput = isOddOrEven(input);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should work correct and return odd when the input lenght is odd(3)', () => {
        let input = 'macbook';
        let expectedOutput = 'odd';
        let actualOutput = isOddOrEven(input);
        expect(actualOutput).to.equal(expectedOutput);
    });
})