const expect = require('chai').expect;
const {createCalculator} = require('./addSubtract');

describe('Add Subtract function', () =>{
    it('Test if add work correctly', () => {
        let calculator = createCalculator();
        calculator.add(5);
        calculator.add(10);
        let expectedOutput = 15;
        let actualOutput = calculator.get();
        expect(actualOutput).to.equal(expectedOutput);
    })

    it('Test if add work correctly if input is number as string', () => {
        let calculator = createCalculator();
        calculator.add('5');
        calculator.add('10');
        let expectedOutput = 15;
        let actualOutput = calculator.get();
        expect(actualOutput).to.equal(expectedOutput);
    })

    it('Test if add and subtract work correctly', () => {
        let calculator = createCalculator();
        calculator.add(5);
        calculator.add(10);
        calculator.subtract(6);
        calculator.subtract(2);
        let expectedOutput = 7;
        let actualOutput = calculator.get();
        expect(actualOutput).to.equal(expectedOutput);
    })

    it('Test if add and subtract work correctly when input is number as string', () => {
        let calculator = createCalculator();
        calculator.add('5');
        calculator.add('10');
        calculator.subtract('6');
        calculator.subtract('2');
        let expectedOutput = 7;
        let actualOutput = calculator.get();
        expect(actualOutput).to.equal(expectedOutput);
    })
})