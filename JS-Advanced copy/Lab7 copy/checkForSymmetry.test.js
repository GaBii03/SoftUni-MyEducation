const expect = require('chai').expect;
const isSymmetric = require('./checkForSymmetry');

describe('Is Symmetric', () => {
    it('Should test if the program work properly with symmetric numeric array', () => {
        let array = [1, 2, 3, 4, 5, 4, 3, 2, 1];
        let expectedOutput = true;
        let actualOutput = isSymmetric(array);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with symmetric string array', () => {
        let array = ['yes', 'no', 'maybe', 'no', 'yes'];
        let expectedOutput = true;
        let actualOutput = isSymmetric(array);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with non symmetric string array', () => {
        let array = ['yes', 'no', 'maybe', 'yes', 'yes'];
        let expectedOutput = false;
        let actualOutput = isSymmetric(array);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with non symmetric numeric array', () => {
        let array = [1, 2, 3, 4, 5, 4, 14, 2, 1];
        let expectedOutput = false;
        let actualOutput = isSymmetric(array);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with non symmetric mixed array', () => {
        let array = [1, 2, 3, 4, 5, 4, '3', 2, 1];
        let expectedOutput = false;
        let actualOutput = isSymmetric(array);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with no array input(string)', () => {
        let array = 'heyyy';
        let expectedOutput = false;
        let actualOutput = isSymmetric(array);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with no array input(object)', () => {
        let array = {};
        let expectedOutput = false;
        let actualOutput = isSymmetric(array);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with one element in the array', () => {
        let array = [100];
        let expectedOutput = true;
        let actualOutput = isSymmetric(array);
        expect(actualOutput).to.equal(expectedOutput);
    });

    
})