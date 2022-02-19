const expect = require('chai').expect;
const sum = require('./sumNumbers');

describe('Sum Of Numbers', () => {
    it('Should test if the program work properly with possitive numbers', () => {
        let numbers = [1, 2, 3, 4, 5];
        let expectedSum = 15;
        let actualSum = sum(numbers);
        expect(actualSum).to.equal(expectedSum);
    });

    it('Should test if the program work properly with negative numbers', () => {
        let numbers = [-1, -2, -3, -4, -5];
        let expectedSum = -15;
        let actualSum = sum(numbers);
        expect(actualSum).to.equal(expectedSum);
    });

    it('Should test if the program work properly with string numbers', () => {
        let numbers = ['-1', '-2', '-3', '-4', '-5'];
        let expectedSum = -15;
        let actualSum = sum(numbers);
        expect(actualSum).to.equal(expectedSum);
    });

    
})