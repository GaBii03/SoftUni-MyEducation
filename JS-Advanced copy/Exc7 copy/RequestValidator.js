//const { version } = require("chai");
function result(objectInput) {

    //method check
    if (objectInput.method != 'GET' && objectInput.method != 'POST' && objectInput.method != 'DELETE' && objectInput.method != 'CONNECT') {
        throw new Error('Invalid request header: Invalid Method');
    }

    //uri check

    //version check
    if (objectInput.version != 'HTTP/0.9' && objectInput.version != 'HTTP/1.0' && objectInput.version != 'HTTP/1.1' && objectInput.version != 'HTTP/2.0') {
        throw new Error('Invalid request header: Invalid Version');
    }

    //message check <, , \, &, ', "

    // if(objectInput.message == ''){
    //     throw new Error('Invalid request header: Invalid Message');
    // }

    var format = /^[&'"\\<>]*$/;

    for (let index = 0; index < objectInput.message.length; index++) {
        if (objectInput.message[index].match(format)) {
            throw new Error('Invalid request header: Invalid Message');
        }
    }
    
    //if is valid return the object
    return objectInput;
}

let obj = result({
    method: 'GET',
    uri: 'svn.public.catalog',
    version: 'HTTP/1.1',
    message: 'as<'
});

console.log(obj);