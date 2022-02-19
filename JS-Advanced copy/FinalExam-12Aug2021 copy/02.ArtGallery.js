// class ArtGallery{
//     constructor(creator){
//         this.creator = creator;
//         this.possibleArticles = { "picture": 200 ,"photo": 50 ,"item": 250 };
//         this.listOfArticles = [];
//         this.guests = [];
//     }

//     addArticle( articleModel, articleName, quantity ){
//         articleModel = articleModel.toLowerCase();
//         if(!this.possibleArticles[articleModel]){
//             throw new Error("This article model is not included in this gallery!");
//         }

//         if(this.listOfArticles.some(x => x.articleName == articleName && x.articleModel == articleModel)){
//             let currArticle = {};
//             for (const key in this.listOfArticles) {
//                 if(this.listOfArticles[key].articleName == articleName && this.listOfArticles[key].articleModel == articleModel){
//                     currArticle = this.listOfArticles[key];
//                     break;
//                 }
//             }
//             //find(x => x.articleName == articleName && x.articleModel == articleModel);
//             currArticle.quantity = Number(currArticle.quantity) + Number(quantity);
            
//         }else{
//             let newArticle = {articleModel, articleName, quantity};
//             this.listOfArticles.push(newArticle);
//         }

//         return `Successfully added article ${articleName} with a new quantity- ${quantity}.`;
//     }

//     inviteGuest ( guestName, personality){
//         if(this.guests.some(x => x.guestName == guestName)){
//             throw new Error(`${guestName} has already been invited.`);
//         }

//         let points = 0;
//         if(personality == 'Vip'){
//             points = 500;
//         }else if(personality == 'Middle'){
//             points = 250;
//         }else{
//             points = 50;
//         }

//         let newGuest = {guestName, points, purchaseArticle:0};
//         this.guests.push(newGuest);
//         return `You have successfully invited ${guestName}!`;
//     }

//     buyArticle ( articleModel, articleName, guestName){

//         let currentArticle = {};
//             for (const key in this.listOfArticles) {
//                 if(this.listOfArticles[key].articleName == articleName && this.listOfArticles[key].articleModel == articleModel){
//                     currentArticle = this.listOfArticles[key];
//                     break;
//                 }
//             }
//         let guest = {};
//         for (const key in this.guests) {
//             if(this.guests[key].guestName == guestName){
//                 guest = this.guests[key];
//                 break;
//             }
//         }
//         //this.guests.find(x => x.guestName == guestName);
        
//         if(!currentArticle){
//             throw new Error("This article is not found.");
//         }
        
//         if(currentArticle.quantity = 0){
//             return `The ${articleName} is not available.`;
//         }

//         if(!guest){
//             return "This guest is not invited.";
//         }

//         if(guest.points < this.possibleArticles[currentArticle.articleModel]){
//             return "You need to more points to purchase the article.";
//         }else{
//             guest.points-=this.possibleArticles[currentArticle.articleModel];
//             currentArticle.quantity = Number(currentArticle.quantity) - 1;
//             guest.purchaseArticle+=1;

//            return `${guestName} successfully purchased the article worth ${this.possibleArticles[currentArticle.articleModel]} points.`;
//         }
//     }

//     showGalleryInfo (criteria){
//         let output = [];
//         if(criteria == 'article'){
//             output.push("Articles information:");
//             this.listOfArticles.forEach(article => output.push(`${article.articleModel} - ${article.articleName} - ${article.quantity}`));
//         }else if(criteria == 'guest'){
//             output.push("Guests information:");
//             this.guests.forEach(guest => output.push(`${guest.guestName} - ${guest.purchaseArticle}`));
//         }

//         return output.join('\n');
//     }
// }

class ArtGallery {
    constructor(creator) {
        this.creator = creator,
        this.possibleArticles = { "picture": 200, "photo": 50, "item": 250 },
        this.listOfArticles = [],
        this.guests = []
    }
 
    addArticle(articleModel, articleName, quantity) {
 
        let articleModelLowerCase = articleModel.toLowerCase();
 
        let quantityNumb = Number(quantity);
        let isExist = false;
 
        for (const key of Object.keys(this.possibleArticles)) {
            if (key === articleModelLowerCase) {
                isExist = true;
                break;
            }
        }
 
        if (!isExist) {
            throw new Error("This article model is not included in this gallery!");
        }
 
        let obj = this.listOfArticles.find(o => o.articleName === articleName);
 
        if (obj) {
 
            obj.quantity += quantityNumb;
 
        } else {
 
            this.listOfArticles.push({ articleModel: articleModelLowerCase, articleName, quantity : quantityNumb});
        }
 
        return `Successfully added article ${articleName} with a new quantity- ${quantity}.`
    }
 
    inviteGuest ( guestName, personality){
        let obj = this.guests.find(o => o.guestName === guestName);
 
        if (obj) {
            return `${guestName} has already been invited.`;
        }
 
        if (personality==='Vip') {
 
            this.guests.push({guestName, points:500, purchaseArticle: 0});
 
        }else if(personality === 'Middle'){
 
            this.guests.push({guestName, points:250, purchaseArticle: 0});
 
        }else{
            this.guests.push({guestName, points:50, purchaseArticle: 0});
        }
 
        return `You have successfully invited ${guestName}!`
    }
 
    buyArticle ( articleModel, articleName, guestName){
 
        let isExist = false;
 
        for (const key of Object.keys(this.possibleArticles)) {
            if (key === articleModel) {
                isExist = true;
                break;
            }
        }
 
        let article = this.listOfArticles.find(o => o.articleName === articleName && o.articleModel === articleModel);
 
        if (!isExist || !article) {
            throw new Error("This article is not found.");
        }
 
        if (article.quantity == 0) {
            return `The ${articleName} is not available.`;
        }
 
        let guest = this.guests.find(o => o.guestName === guestName);
 
        if (!guest) {
 
            return `This guest is not invited.`;
        }
 
        let neededPoints = this.possibleArticles[articleModel];
 
        if (guest.points - neededPoints < 0  ) {
 
            return `You need to more points to purchase the article.`;
 
        }else{
            guest.points-= neededPoints;
            guest.purchaseArticle+=1;
            article.quantity-=1;
        }
 
        return `${guestName} successfully purchased the article worth ${neededPoints} points.`
 
    }
 
    showGalleryInfo (criteria){
 
        let result = '';
 
        if (criteria === 'article') {
 
            result+=  'Articles information:'+ '\n';
 
            for (const key of Object.values(this.listOfArticles) ) {
 
               result += `${key.articleModel} - ${key.articleName} - ${key.quantity}`+ '\n';
            }
        }else{
            result += 'Guests information:'+ '\n';
 
            for (const key of Object.values(this.guests) ) {
                result += `${key.guestName} - ${key.purchaseArticle}`+ '\n';
            }
        }
 
        return result.trim();
    }
}


// const artGallery = new ArtGallery('Curtis Mayfield');
// console.log(artGallery.addArticle('picture', 'Mona Liza', 3));
// console.log(artGallery.addArticle('Item', 'Ancient vase', 2));
// console.log(artGallery.addArticle('PICTURE', 'Mona Liza', 1));

// const artGallery = new ArtGallery('Curtis Mayfield');
// console.log(artGallery.inviteGuest('John', 'Vip'));
// console.log(artGallery.inviteGuest('Peter', 'Middle'));
// console.log(artGallery.inviteGuest('John', 'Middle'));

// const artGallery = new ArtGallery('Curtis Mayfield');
// artGallery.addArticle('picture', 'Mona Liza', 3);
// artGallery.addArticle('Item', 'Ancient vase', 2);
// artGallery.addArticle('picture', 'Mona Liza', 1);
// artGallery.inviteGuest('John', 'Vip');
// artGallery.inviteGuest('Peter', 'Middle');
// console.log(artGallery.buyArticle('picture', 'Mona Liza', 'John'));
// console.log(artGallery.buyArticle('item', 'Ancient vase', 'Peter'));
// console.log(artGallery.buyArticle('item', 'Mona Liza', 'John'));

const artGallery = new ArtGallery('Curtis Mayfield'); 
console.log(artGallery.addArticle('picture', 'Mona Liza', 3));
console.log(artGallery.addArticle('Item', 'Ancient vase', 2));
console.log(artGallery.addArticle('picture', 'Mona Liza', 1));
console.log(artGallery.inviteGuest('John', 'Vip'));
console.log(artGallery.inviteGuest('Peter', 'Middle'));
console.log(artGallery.buyArticle('picture', 'Mona Liza', 'John'));
console.log(artGallery.buyArticle('item', 'Ancient vase', 'Peter'));
console.log(artGallery.showGalleryInfo('article'));
console.log(artGallery.showGalleryInfo('guest'));