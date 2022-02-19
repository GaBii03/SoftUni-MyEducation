const expect = require('chai').expect;
const {mathEnforcer} = require('./mathEnforcer');

describe('Math Enforcer', () => {
    describe('Add Five function', () => {
        it('Should return undefined if input is not a number(string)', () => {
            let input = 'yes';
            let actualOutput = mathEnforcer.addFive(input);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return undefined if input is not a number(array)', () => {
            let input = [];
            let actualOutput = mathEnforcer.addFive(input);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return undefined if input is not a number(object)', () => {
            let input = {};
            let actualOutput = mathEnforcer.addFive(input);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return undefined if input is not a number(boolean)', () => {
            let input = true;
            let actualOutput = mathEnforcer.addFive(input);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return correct output when input is a number', () => {
            let input = 5;
            let expectedOutput = 10;
            let actualOutput = mathEnforcer.addFive(input);
            expect(actualOutput).to.equal(expectedOutput);
        })

        it('Should return correct output when input is a negative number', () => {
            let input = -5;
            let expectedOutput = 0;
            let actualOutput = mathEnforcer.addFive(input);
            expect(actualOutput).to.equal(expectedOutput);
        })

        it('Should return correct output when input is a floating-point number', () => {
            let input = 5.5;
            let expectedOutput = 10.5;
            let actualOutput = mathEnforcer.addFive(input);
            expect(actualOutput).to.be.closeTo(expectedOutput, 0.01);
        })

        it('Should return correct output when input is a floating-point negative number', () => {
            let input = -5.5;
            let expectedOutput = -0.5;
            let actualOutput = mathEnforcer.addFive(input);
            expect(actualOutput).to.be.closeTo(expectedOutput, 0.01);
        })
    })

    describe('Subtract Ten function', () => {
        it('Should return undefined if input is not a number(string)', () => {
            let input = 'yes';
            let actualOutput = mathEnforcer.subtractTen(input);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return undefined if input is not a number(array)', () => {
            let input = [];
            let actualOutput = mathEnforcer.subtractTen(input);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return undefined if input is not a number(object)', () => {
            let input = {};
            let actualOutput = mathEnforcer.subtractTen(input);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return undefined if input is not a number(boolean)', () => {
            let input = true;
            let actualOutput = mathEnforcer.subtractTen(input);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return correct output when input is a number', () => {
            let input = 20;
            let expectedOutput = 10;
            let actualOutput = mathEnforcer.subtractTen(input);
            expect(actualOutput).to.equal(expectedOutput);
        })

        it('Should return correct output when input is a negative number', () => {
            let input = -10;
            let expectedOutput = -20;
            let actualOutput = mathEnforcer.subtractTen(input);
            expect(actualOutput).to.equal(expectedOutput);
        })

        it('Should return correct output when input is a floating-point number', () => {
            let input = 10.5;
            let expectedOutput = 0.5;
            let actualOutput = mathEnforcer.subtractTen(input);
            expect(actualOutput).to.be.closeTo(expectedOutput, 0.01);
        })

        it('Should return correct output when input is a floating-point negative number', () => {
            let input = -10.5;
            let expectedOutput = -20.5;
            let actualOutput = mathEnforcer.subtractTen(input);
            expect(actualOutput).to.be.closeTo(expectedOutput, 0.01);
        })
    })

    describe('Sum function', () => {
        it('Should return undefined if both inputs are not  numbers(string)', () => {
            let input1 = 'yes';
            let input2 = 'yes';
            let actualOutput = mathEnforcer.sum(input1, input2);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return undefined if both inputs are not  numbers(array)', () => {
            let input1 = [];
            let input2 = [];
            let actualOutput = mathEnforcer.sum(input1,input2);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return undefined if both inputs are not numbers(object)', () => {
            let input1 = {};
            let input2 = {};
            let actualOutput = mathEnforcer.sum(input1, input2);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return undefined if both inputs are not numbers(boolean)', () => {
            let input1 = true;
            let input2 = true;
            let actualOutput = mathEnforcer.sum(input1,input2);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return undefined if on of the inputs is not a number(boolean)', () => {
            let input1 = true;
            let input2 = 3;
            let actualOutput = mathEnforcer.sum(input1,input2);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return undefined if on of the inputs is not a number(string)', () => {
            let input1 = 5;
            let input2 = 'yes';
            let actualOutput = mathEnforcer.sum(input1, input2);
            expect(actualOutput).to.be.undefined;
        })

        it('Should return correct output when inputs are numbers', () => {
            let input1 = 20;
            let input2 = 10;
            let expectedOutput = 30;
            let actualOutput = mathEnforcer.sum(input1,input2);
            expect(actualOutput).to.equal(expectedOutput);
        })

        it('Should return correct output when one of the inputs is negative number', () => {
            let input1 = -10;
            let input2 = 10;
            let expectedOutput = 0;
            let actualOutput = mathEnforcer.sum(input1,input2);
            expect(actualOutput).to.equal(expectedOutput);
        })

        it('Should return correct output when inputs are negative numbers', () => {
            let input1 = -10;
            let input2 = -10;
            let expectedOutput = -20;
            let actualOutput = mathEnforcer.sum(input1,input2);
            expect(actualOutput).to.equal(expectedOutput);
        })

        it('Should return correct output when inputs are floating-point numbers', () => {
            let input1 = 10.5;
            let input2 = 5.5;
            let expectedOutput = 16;
            let actualOutput = mathEnforcer.sum(input1,input2);
            expect(actualOutput).to.be.closeTo(expectedOutput, 0.01);
        })

        it('Should return correct output when one of the inputs is a floating-point negative numbers', () => {
            let input1 = -10.5;
            let input2 = 5.5;
            let expectedOutput = -5;
            let actualOutput = mathEnforcer.sum(input1,input2);
            expect(actualOutput).to.be.closeTo(expectedOutput, 0.01);
        })

        it('Should return correct output when inputs are floating-point negative numbers', () => {
            let input1 = -10.5;
            let input2 = -5.5;
            let expectedOutput = -16;
            let actualOutput = mathEnforcer.sum(input1,input2);
            expect(actualOutput).to.be.closeTo(expectedOutput, 0.01);
        })
    })
})