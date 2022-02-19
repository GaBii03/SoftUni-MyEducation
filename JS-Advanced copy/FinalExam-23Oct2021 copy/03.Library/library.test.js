const expect = require('chai').expect;
const {library} = require('./library')

describe('Library', () => {

    describe('Calculate Price Of A Book function tests', () =>{

        it('Should calculate the price when the data is valid and the book year is after 1980', ()=>{
            let outputFromFunction = library.calcPriceOfBook('MyBook', 2003)
            let expectedOutput = 'Price of MyBook is 20.00';
            expect(expectedOutput).to.equal(outputFromFunction);
        }) 

        it('Should calculate the price when the data is valid and the book year is 1980', ()=>{
            let outputFromFunction = library.calcPriceOfBook('MyBook', 1980)
            let expectedOutput = 'Price of MyBook is 10.00';
            expect(expectedOutput).to.equal(outputFromFunction);
        })

        it('Should calculate the price when the data is valid and the book year before 1980', ()=>{
            let outputFromFunction = library.calcPriceOfBook('MyBook', 1970)
            let expectedOutput = 'Price of MyBook is 10.00';
            expect(outputFromFunction).to.equal(expectedOutput);
        })

        it('Should throw error when the name is not a string', () => {
            
            expect(() => {library.calcPriceOfBook(1111, 1970)}).to.throw('Invalid input');
        })

        it('Should throw error when the year is not a number', () => {
            
            expect(() => {library.calcPriceOfBook('1111', '1970')}).to.throw('Invalid input');
        })

        it('Should throw error when both the name the year are not valid', () => {
            
            expect(() => {library.calcPriceOfBook(11, '1970')}).to.throw('Invalid input');
        })

        it('Should throw error when the year is not valid', () => {
            
            expect(() => {library.calcPriceOfBook('qq', 11.11)}).to.throw('Invalid input');
        })

    });

    describe('Find Book function tests', () =>{

        it('Should Throw error if the array length is zero', ()=>{
            expect(() => {library.findBook([], 'MyBook')}).to.throw('No books currently available');
        })
        it('Should return the book when is there and the data is valid', ()=>{
            expect(library.findBook(['Suasan','Nigeria','Another','MyBook','Last'], 'MyBook')).to.equal('We found the book you want.');
        })
        it('Should return the book when is there and the data is valid', ()=>{
            expect(library.findBook(['Suasan','Nigeria2','Another','MyBook','Last'], 'Nigeria2')).to.equal('We found the book you want.');
        })
        it('Should return that the book is not there when the data is valid', ()=>{
            expect(library.findBook(['Suas1an','Nigeria1','Another1','MyBoo1k','Las1t'], 'MyBook4')).to.equal('The book you are looking for is not here!');
        })
    });

    describe('Arrange The Books function tests', () =>{

        it('Throw error if the input is not a number',()=>{
            expect(() => {library.arrangeTheBooks('a')}).to.throw('Invalid input');
        })
        it('Throw error if the input is not a number(2)',()=>{
            expect(() => {library.arrangeTheBooks(undefined)}).to.throw('Invalid input');
        })
        it('Throw error if the input is not a number(3)',()=>{
            expect(() => {library.arrangeTheBooks(null)}).to.throw('Invalid input');
        })
        it('Should return a propriate output when the books are less than 40(1)',()=>{
            expect(library.arrangeTheBooks(32)).to.equal('Great job, the books are arranged.');
        })

        it('Should return a propriate output when the books are less than 40(2)',()=>{
            expect(library.arrangeTheBooks(10)).to.equal('Great job, the books are arranged.');
        })

        it('Should return a propriate output when the books are 40',()=>{
            expect(library.arrangeTheBooks(40)).to.equal('Great job, the books are arranged.');
        })
        
        it('Should return a propriate output when the books are more than 40(1)',()=>{
            expect(library.arrangeTheBooks(41)).to.equal('Insufficient space, more shelves need to be purchased.');
        })

        it('Should return a propriate output when the books are more than 40(2)',()=>{
            expect(library.arrangeTheBooks(50)).to.equal('Insufficient space, more shelves need to be purchased.');
        })
    });

});