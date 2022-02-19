const expect = require('chai').expect;
const rgbToHexColor = require('./rgb-to-hex');


describe('RGB to Hex', () => {

    it('Should test if the program work properly with correct input(first)', () => {
        let red = 20;
        let green = 35;
        let blue = 29;
        let expectedOutput = '#14231D';
        let actualOutput = rgbToHexColor(red, green, blue);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with correct input(second)', () => {
        let red = 200;
        let green = 0;
        let blue = 255;
        let expectedOutput = '#C800FF';
        let actualOutput = rgbToHexColor(red, green, blue);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with incorrect input(red1)', () => {
        let red = 'a';
        let green = 0;
        let blue = 255;
        let expectedOutput = undefined;
        let actualOutput = rgbToHexColor(red, green, blue);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with incorrect input(red2)', () => {
        let red = -1;
        let green = 0;
        let blue = 255;
        let expectedOutput = undefined;
        let actualOutput = rgbToHexColor(red, green, blue);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with incorrect input(red3)', () => {
        let red = 260;
        let green = 0;
        let blue = 255;
        let expectedOutput = undefined;
        let actualOutput = rgbToHexColor(red, green, blue);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with incorrect input(green1)', () => {
        let red = 2;
        let green = 'a';
        let blue = 255;
        let expectedOutput = undefined;
        let actualOutput = rgbToHexColor(red, green, blue);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with incorrect input(green2)', () => {
        let red = 2;
        let green = -3;
        let blue = 255;
        let expectedOutput = undefined;
        let actualOutput = rgbToHexColor(red, green, blue);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with incorrect input(green3)', () => {
        let red = 2;
        let green = 300;
        let blue = 255;
        let expectedOutput = undefined;
        let actualOutput = rgbToHexColor(red, green, blue);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with incorrect input(blue1)', () => {
        let red = 2;
        let green = 100;
        let blue = 'a';
        let expectedOutput = undefined;
        let actualOutput = rgbToHexColor(red, green, blue);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with incorrect input(blue2)', () => {
        let red = 2;
        let green = 5;
        let blue = -90;
        let expectedOutput = undefined;
        let actualOutput = rgbToHexColor(red, green, blue);
        expect(actualOutput).to.equal(expectedOutput);
    });

    it('Should test if the program work properly with incorrect input(blue3)', () => {
        let red = 2;
        let green = 300;
        let blue = 3000;
        let expectedOutput = undefined;
        let actualOutput = rgbToHexColor(red, green, blue);
        expect(actualOutput).to.equal(expectedOutput);
    });

});