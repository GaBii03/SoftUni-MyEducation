const expect = require('chai').expect;
const {flowerShop} = require('./flowerShop')

describe('Flower Shop', () => {

    describe('Calculate Price Of Flower', () => {
        it('Shoud throw error if first input is not string(1)', () => {
            expect(() => {flowerShop.calcPriceOfFlowers(['hay'], 2, 4)}).to.throw('Invalid input!');
        });
        it('Shoud throw error if first input is not string(2)', () => {
            expect(() => {flowerShop.calcPriceOfFlowers(3, 2, 4)}).to.throw('Invalid input!');
        });
        it('Shoud throw error if first input is not string(3)', () => {
            expect(() => {flowerShop.calcPriceOfFlowers({}, 2, 4)}).to.throw('Invalid input!');
        });
        it('Shoud throw error if second input is not number(1)', () => {
            expect(() => {flowerShop.calcPriceOfFlowers( 'Rose', {}, 4)}).to.throw('Invalid input!');
        });
        it('Shoud throw error if second input is not number(2)', () => {
            expect(() => {flowerShop.calcPriceOfFlowers('Rose', [], 4)}).to.throw('Invalid input!');
        });
        it('Shoud throw error if second input is not number(3)', () => {
            expect(() => {flowerShop.calcPriceOfFlowers('Rose', '', 4)}).to.throw('Invalid input!');
        });
        it('Shoud throw error if third input is not number(1)', () => {
            expect(() => {flowerShop.calcPriceOfFlowers( 'Rose', 2, [])}).to.throw('Invalid input!');
        });
        it('Shoud throw error if third input is not number(2)', () => {
            expect(() => {flowerShop.calcPriceOfFlowers('Rose', 4, {})}).to.throw('Invalid input!');
        });
        it('Shoud throw error if third input is not number(3)', () => {
            expect(() => {flowerShop.calcPriceOfFlowers('Rose', 8, '')}).to.throw('Invalid input!');
        });
        it('Should return price * quantity(1)', () => {
            expect(flowerShop.calcPriceOfFlowers('Rose', 3, 4)).to.equal('You need $12.00 to buy Rose!');
        });
        it('Should return price * quantity(2)', () => {
            expect(flowerShop.calcPriceOfFlowers('Rose', 0, 4)).to.equal('You need $0.00 to buy Rose!');
        });
        it('Should return price * quantity(3)', () => {
            expect(flowerShop.calcPriceOfFlowers('Rose', 0, 0)).to.equal('You need $0.00 to buy Rose!');
        });
        it('Should return price * quantity(4)', () => {
            expect(flowerShop.calcPriceOfFlowers('Rose', 2, 0)).to.equal('You need $0.00 to buy Rose!');
        });
        
    });

    describe('Check if flowers are available', () => {
        it('Should return that the flower is available(1)', () => {
            expect(flowerShop.checkFlowersAvailable('rose', ['asd', 'www', 'a', 'roses', 'rose'])).to.equal('The rose are available!')
        });
        it('Should return that the flower is available(2)', () => {
            expect(flowerShop.checkFlowersAvailable('rose', ['rose'])).to.equal('The rose are available!')
        });
        it('Should return that the flower is not available(1)', () =>{
            expect(flowerShop.checkFlowersAvailable('rose', ['asd', 'www', 'a', 'roses', 'Rose'])).to.equal('The rose are sold! You need to purchase more!');
        });
        it('Should return that the flower is not available(2)', () =>{
            expect(flowerShop.checkFlowersAvailable('rose', ['asd', 'www', 'a', 'roses'])).to.equal('The rose are sold! You need to purchase more!');
        });
        it('Should return that the flower is not available(3)', () =>{
            expect(flowerShop.checkFlowersAvailable('rose', [])).to.equal('The rose are sold! You need to purchase more!');
        });
    });

    describe('Sell Flowers tests', () => {
        it('Should return error if the first input is not an array', () => {
            expect(() => {flowerShop.sellFlowers({}, 3)}).to.throw('Invalid input!');
        });
        it('Should return error if the second input is not a number', () => {
            expect(() => {flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], '')}).to.throw('Invalid input!');
        });
        it('Should return error if the second input is below 0', () => {
            expect(() => {flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], -1)}).to.throw('Invalid input!');
        });
        it('Should return error if the second input is as the array legth', () => {
            expect(() => {flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 3)}).to.throw('Invalid input!');
        });
        it('Should return error if the second input is biggest than the array legth', () => {
            expect(() => {flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 5)}).to.throw('Invalid input!');
        });
        it('Should return the shop array', () => {
            expect(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 2)).to.equal('Rose / Lily')
        })
        it('Should return the shop array(2)', () => {
            expect(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 0)).to.equal('Lily / Orchid')
        })
    });

});

