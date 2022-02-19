class LibraryCollection {

    constructor(capacity) {
        this.capacity = capacity;
        this.books = [];
    }

    addBook(bookName, bookAuthor) {
        if (this.books.length == this.capacity) {
            throw new Error("Not enough space in the collection.");
        }

        let bookObj = {
            bookName,
            bookAuthor,
            payed: false,
        }

        this.books.push(bookObj);
        return `The ${bookName}, with an author ${bookAuthor}, collect.`;
    }

    payBook(bookName) {

        let isFound = false;
        let book = {};

        for (let index = 0; index < this.books.length; index++) {

            book = this.books[index];
            if (book.bookName == bookName) {
                isFound = true;
                break;
            }

        }

        if (!isFound) {
            throw new Error(`${bookName} is not in the collection.`);
        }

        if (book.payed == true) {
            throw new Error(`${bookName} has already been paid.`)
        }

        let theBook = this.books.find(x => x.bookName == bookName);
        theBook.payed = true;
        
        return `${bookName} has been successfully paid.`
    }

    removeBook(bookName) {
        if (!this.books.some(x => x.bookName == bookName)) {
            throw new Error("The book, you're looking for, is not found.");
        }

        if (this.books.find(x => x.bookName == bookName).payed == false) {
            throw new Error(`${bookName} need to be paid before removing from the collection.`)
        }

        this.books = this.books.filter(x => x.bookName != bookName);
        return `${bookName} remove from the collection.`;
    }

    getStatistics(bookAuthor) {

        if (bookAuthor != undefined) {

            let book = this.books.find(x => x.bookAuthor == bookAuthor)
            if (!book) {
                throw new Error(`${bookAuthor} is not in the collection.`);
            }

            let stringPayed = '';
            if (book.payed == false) {
                stringPayed = 'Not Paid';
            } else {
                stringPayed = 'Has Paid';
            }
            return `${book.bookName} == ${book.bookAuthor} - ${stringPayed}.`;

        } else {

            let output = [];
            output.push(`The book collection has ${this.capacity - this.books.length} empty spots left.`)
            this.books.sort((a, b) => a.bookName - b.bookName);
            for (const book of this.books) {
                let stringPayed = '';
                if (book.payed == false) {
                    stringPayed = 'Not Paid';
                } else {
                    stringPayed = 'Has Paid';
                }
                output.push(`${book.bookName} == ${book.bookAuthor} - ${stringPayed}.`);
            }

            return output.join('\n');
        }
    }
}


const library = new LibraryCollection(2)
library.addBook('In Search of Lost Time', 'Marcel Proust');
library.addBook('Don Quixote', 'Miguel de Cervantes');
library.payBook('Don Quixote');
console.log(library.removeBook('Don Quixote'));
console.log(library.removeBook('In Search of Lost Time'));
