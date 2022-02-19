class ChristmasDinner {
    constructor(budget) {
        if (this.budget < 0) {
            throw new Error("The budget cannot be a negative number");
        }
        this.budget = budget;
        this.dishes = [];
        this.products = [];
        this.guests = {};
    }

    shopping(arrayProduct) {
        let typeProduct = arrayProduct[0];
        let priceProduct = Number(arrayProduct[1]);

        if (this.budget < priceProduct) {
            throw new Error("Not enough money to buy this product");
        } else {
            this.products.push(typeProduct);
            this.budget -= priceProduct;
            return `You have successfully bought ${typeProduct}!`;
        }
    }

    recipes(recipeObject) {
        let areAvailable = true;
        let recipeName = recipeObject.recipeName;
        let recipeIngredients = recipeObject.productsList;

        for (let index = 0; index < recipeIngredients.length; index++) {
            if (!this.products.includes(recipeIngredients[index])) {
                areAvailable = false;
                break;
            }
        }

        if (areAvailable) {
            this.dishes.push(recipeObject);
            return `${recipeName} has been successfully cooked!`;
        } else {
            throw new Error("We do not have this product");
        }

    }

    inviteGuests(guestName, dish) {

        if (this.guests[guestName]) {
            throw new Error("This guest has already been invited");
        }
        if (!this.dishes.some(x => x.recipeName == dish)) {
            throw new Error("We do not have this dish");
        }

        this.guests[guestName] = dish;
        return `You have successfully invited ${guestName}!`;
    }

    showAttendance() {
       
        let output = [];
        let products = [];
        for (const key in this.guests) {

            let dishName = this.guests[key];

            for (const dish of this.dishes) {
                 if(dish.recipeName == dishName){
                     products = dish.productsList;
                 }
            }

            output.push(`${key} will eat ${dishName}, which consists of ${products.join(', ')}`);
        }


        return output.join('\n');
    }
}

let dinner = new ChristmasDinner(300);

dinner.shopping(['Salt', 1]);
dinner.shopping(['Beans', 3]);
dinner.shopping(['Cabbage', 4]);
dinner.shopping(['Rice', 2]);
dinner.shopping(['Savory', 1]);
dinner.shopping(['Peppers', 1]);
dinner.shopping(['Fruits', 40]);
dinner.shopping(['Honey', 10]);

dinner.recipes({
    recipeName: 'Oshav',
    productsList: ['Fruits', 'Honey']
});
dinner.recipes({
    recipeName: 'Folded cabbage leaves filled with rice',
    productsList: ['Cabbage', 'Rice', 'Salt', 'Savory']
});
dinner.recipes({
    recipeName: 'Peppers filled with beans',
    productsList: ['Beans', 'Peppers', 'Salt']
});

dinner.inviteGuests('Ivan', 'Oshav');
dinner.inviteGuests('Petar', 'Folded cabbage leaves filled with rice');
dinner.inviteGuests('Georgi', 'Peppers filled with beans');

console.log(dinner.showAttendance());