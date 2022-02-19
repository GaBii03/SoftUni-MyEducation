const expect = require('chai').expect;
const {numberOperations} = require('./NumberOperations')

describe('Number Oprations tests', () => {

    describe('Pow number tests', () => {
        it('Should return the power of a number(1)', () => {
            expect(numberOperations.powNumber(0)).to.equal(0);
        });
        it('Should return the power of a number(2)', () => {
            expect(numberOperations.powNumber(1)).to.equal(1);
        });
        it('Should return the power of a number(3)', () => {
            expect(numberOperations.powNumber(2)).to.equal(4);
        });
        it('Should return the power of a number(4)', () => {
            expect(numberOperations.powNumber(10)).to.equal(100);
        });
        it('Should return the power of a number(5)', () => {
            expect(numberOperations.powNumber(1.1)).to.equal(1.2100000000000002);
        });
    });

    describe('Number checker tests', () => {
        it('Should return NaN if the input is not a number ot string-number(array)', () => {
            expect( () => {numberOperations.numberChecker([11,11])}).to.throw('The input is not a number!');
        });
        it('Should return NaN if the input is not a number ot string-number(object)', () => {
            expect( () => {numberOperations.numberChecker({name: 'Gabi'})}).to.throw('The input is not a number!');
        });
        it('Should return NaN if the input is not a number ot string-number(string)', () => {
            expect( () => {numberOperations.numberChecker('hey')}).to.throw('The input is not a number!');
        });
        it('Should return that the number is below 100 if is.(1)', () => {
            expect(numberOperations.numberChecker(21)).to.equal('The number is lower than 100!');
        });
        it('Should return that the number is below 100 if is.(2)', () => {
            expect(numberOperations.numberChecker(-100)).to.equal('The number is lower than 100!');
        });
        it('Should return that the number is below 100 if is.(3)', () => {
            expect(numberOperations.numberChecker(0)).to.equal('The number is lower than 100!');
        });
        it('Should return that the number is below 100 if is.(4)', () => {
            expect(numberOperations.numberChecker(99.9)).to.equal('The number is lower than 100!');
        });
        it('Should return that the number is equal or over 100(1)', () => {
            expect(numberOperations.numberChecker(100)).to.equal('The number is greater or equal to 100!');
        });
        it('Should return that the number is equal or over 100(2)', () => {
            expect(numberOperations.numberChecker(100.1)).to.equal('The number is greater or equal to 100!');
        });
        it('Should return that the number is equal or over 100(3)', () => {
            expect(numberOperations.numberChecker(10000)).to.equal('The number is greater or equal to 100!');
        });
        it('Should return that the number is equal or over 100(4)', () => {
            expect(numberOperations.numberChecker(342)).to.equal('The number is greater or equal to 100!');
        });
    });

    describe('Sum arrays tests', () => {
        it('Should return sum of arrays when the length is equal(1)', () => {
            expect(numberOperations.sumArrays([1,1,1,1,1],[2,2,2,2,2])).to.deep.equal([3,3,3,3,3]);
        });
        it('Should return sum of arrays when the length is equal(2)', () => {
            expect(numberOperations.sumArrays([1,2,1,1,3],[2,2,2,2,2])).to.deep.equal([3,4,3,3,5]);
        });
        it('Should return sum of arrays when the length is equal(3)', () => {
            expect(numberOperations.sumArrays([1],[2])).to.deep.equal([3]);
        });
        it('Should return sum of arrays when the first array is longer(1)', () => {
            expect(numberOperations.sumArrays([1,1,1,1,1,1,1],[2,2,2,2,2])).to.deep.equal([3,3,3,3,3,1,1]);
        });
        it('Should return sum of arrays when the first array is longer(2)', () => {
            expect(numberOperations.sumArrays([2,1,2,1,1,1,1],[2,2,2,2,2])).to.deep.equal([4,3,4,3,3,1,1]);
        });
        it('Should return sum of arrays when the first array is longer(3)', () => {
            expect(numberOperations.sumArrays([1,0],[22])).to.deep.equal([23,0]);
        });
        it('Should return sum of arrays when the second array is longer(1)', () => {
            expect(numberOperations.sumArrays([1,1,1],[2,2,2,2,2])).to.deep.equal([3,3,3,2,2]);
        });
        it('Should return sum of arrays when the second array is longer(2)', () => {
            expect(numberOperations.sumArrays([2],[2,2,2,2,2])).to.deep.equal([4,2,2,2,2]);
        });
        it('Should return sum of arrays when the second array is longer(3)', () => {
            expect(numberOperations.sumArrays([0],[22.5,4])).to.deep.equal([22.5,4]);
        });
    });
});