const expect = require('chai').expect;
const lookupChar = require('./charLookUp');

describe('Look Up Char', () => {
    it('Should return undefined if string input is not a string', () =>{
        let stringInput = 24;
        let index = 3;
        let actualOutput = lookupChar(stringInput, index);
        expect(actualOutput).to.be.undefined;
    });

    it('Should return undefined if index input is not a number', () =>{
        let stringInput = 'astronaut';
        let index = 'yes';
        let actualOutput = lookupChar(stringInput, index);
        expect(actualOutput).to.be.undefined;
    });

    it('Should return undefined if index input is a floation-point number', () =>{
        let stringInput = 'astronaut';
        let index = 2.3;
        let actualOutput = lookupChar(stringInput, index);
        expect(actualOutput).to.be.undefined;
    });

    it('Should return undefined if  string input is not a string and index input is not a number', () =>{
        let stringInput = 24;
        let index = 'hello';
        let actualOutput = lookupChar(stringInput, index);
        expect(actualOutput).to.be.undefined;
    });

    it('Should return /Incorrect index/ if  string input is shorter than the index(1)', () =>{
        let stringInput = 'astronaut';
        let index = 9;
        let expectedOutput = 'Incorrect index'
        let actualOutput = lookupChar(stringInput, index);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should return /Incorrect index/ if  string input is shorter than the index(2)', () =>{
        let stringInput = 'book';
        let index = 5;
        let expectedOutput = 'Incorrect index'
        let actualOutput = lookupChar(stringInput, index);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should return /Incorrect index/ if index is below zero', () =>{
        let stringInput = 'book';
        let index = -1;
        let expectedOutput = 'Incorrect index'
        let actualOutput = lookupChar(stringInput, index);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should return correct char if the data is valid(1)', () =>{
        let stringInput = 'book';
        let index = 2;
        let expectedOutput = 'o'
        let actualOutput = lookupChar(stringInput, index);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should return correct char if the data is valid(2)', () =>{
        let stringInput = 'week';
        let index = 0;
        let expectedOutput = 'w'
        let actualOutput = lookupChar(stringInput, index);
        expect(actualOutput).to.equal(expectedOutput);
    });
})