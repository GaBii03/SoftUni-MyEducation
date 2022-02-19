class Restaurant{

    constructor(budgetMoney){
        this.budgetMoney = budgetMoney;
        this.menu = {};
        this.stockProducts = {};
        this.history = []; 
    }

    loadProducts(products){
        let output = [];
        for (let index = 0; index < products.length; index++) {
            let currProduct = products[index].split(' ');
            let productName = currProduct[0];
            let productQuantity = Number(currProduct[1]);
            let productPrice = Number(currProduct[2]);

            if(productPrice>this.budgetMoney){
                output.push(`There was not enough money to load ${productQuantity} ${productName}`);
                continue;
            }

            if(!this.stockProducts[productName]){
                this.stockProducts[productName] = 0;
            }

            this.stockProducts[productName] += productQuantity;
            this.budgetMoney -= productPrice;
            output.push(`Successfully loaded ${productQuantity} ${productName}`);
            //output.push(`Total amount ${this.stockProducts[productName]}`)
        }
        return output.join('\n');
    }

    addToMenu(nameMeal, neededProducts, price){
        if(this.menu[nameMeal]){
            return `The ${nameMeal} is already in the our menu, try something different.`;
        }

        let mealObject = {
            products: neededProducts,
            price,
        }

        this.menu[nameMeal] = mealObject;
        if(Object.keys(this.menu).length == 1){
            return `Great idea! Now with the ${nameMeal} we have 1 meal in the menu, other ideas?`
        }else{
            return `Great idea! Now with the ${nameMeal} we have ${Object.keys(this.menu).length} meals in the menu, other ideas?`
        }
    }

    showTheMenu(){
        if(Object.keys(this.menu).length == 0){
            return "Our menu is not ready yet, please come later...";
        }

        let output = [];
        for (const key in this.menu) {
            output.push(`${key} - $ ${this.menu[key].price}`);
        }
        return output.join('\n');
    }

    makeTheOrder(mealName){
        let isInTheMenu = false;
        let mealObj = {};
        let output = '';
        for (const key in this.menu) {
            if(key == mealName){
                isInTheMenu = true;
                mealObj = this.menu[key];
                break;
            }
        }

        if(!isInTheMenu){
           return `There is not ${mealName} yet in our menu, do you want to order something else?`;
        }

        for (let index = 0; index < mealObj.products.length; index++) {
            let currProduct = mealObj.products[index].split(' ');
            let nameProduct = currProduct[0];
            let productQuantity = currProduct[1];
            let isEnough = false;

            for (const key in this.stockProducts) {
                if(key == nameProduct){
                    this.stockProducts[key] >= productQuantity;
                    isEnough = true;
                    this.stockProducts[key] -= productQuantity;
                    break;
                }
            }

            if(!isEnough){
                output = `For the time being, we cannot complete your order (${mealName}), we are very sorry...`;
                break;
            }
        }

        if(output == ''){
            this.budgetMoney+=this.menu[mealName].price;
            output = `Your order (${mealName}) will be completed in the next 30 minutes and will cost you ${this.menu[mealName].price}.`;
        }

        return output;

    }
}

// let kitchen = new Restaurant(1000);
// console.log(kitchen.loadProducts(['Banana 10 5', 'Banana 20 10', 'Strawberries 50 30', 'Yogurt 10 10', 'Yogurt 500 1500', 'Honey 5 50']));

// let kitchen = new Restaurant(1000);
// console.log(kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99));
// console.log(kitchen.addToMenu('Pizza', ['Flour 0.5', 'Oil 0.2', 'Yeast 0.5', 'Salt 0.1', 'Sugar 0.1', 'Tomato sauce 0.5', 'Pepperoni 1', 'Cheese 1.5'], 15.55));

// let kitchen = new Restaurant(1000);
// console.log(kitchen.loadProducts(['Banana 10 5', 'Banana 20 10', 'Strawberries 50 30', 'Yogurt 10 10', 'Yogurt 500 1500', 'Honey 5 50']));
// console.log(kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99));
// console.log(kitchen.addToMenu('Pizza', ['Flour 0.5', 'Oil 0.2', 'Yeast 0.5', 'Salt 0.1', 'Sugar 0.1', 'Tomato sauce 0.5', 'Pepperoni 1', 'Cheese 1.5'], 15.55));
// console.log(kitchen.showTheMenu());

let kitchen = new Restaurant(1000);
kitchen.loadProducts(['Yogurt 30 3', 'Honey 50 4', 'Strawberries 20 10', 'Banana 5 1']);
kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99);
console.log(kitchen.makeTheOrder('frozenYogurt'));