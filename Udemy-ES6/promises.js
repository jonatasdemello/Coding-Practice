// Promise:
// - unresolved: waiting
// - resolved: finished, OK     => then
// - rejected: finished, bad    => catch

// promise = new Promise( (resolve, reject) => {
//     resolve();
//     reject();
// });

//promise.then(()=>{});
//promise.catch(()=>{});

ps1 = new Promise( (resolve, reject) => {
    console.log('inside');
    resolve();
});
ps1
    .then(() => {
    console.log('finished');
    })
    .then(()=>{
        console.log('run after');
    });

// or 
ps2 = new Promise( (resolve, reject) => {
    console.log('inside');
    reject();
});
ps2
    .then(() => console.log('finished'))
    .then(() => console.log('run after'))
    .catch(() => console.log('something wrong'));

//or
ps3 = new Promise( (resolve, reject) => {
    setTimeout(() => {
        resolve();
    }, 3000)
});
ps3
    .then(() => console.log('finished'))
    .catch(() => console.log('something wrong'));

// or
ps4 = new Promise((resolve, reject) => {
    var request = new XMLHttpRequest();
    request.onload = () => {
        resolve();
    };
});


console.log('------------- promises-fetch');

url = "https://jsonplaceholder.typicode.com/posts/";

//fetch(url).then(data => console.log(data));

fetch(url)
    .then(response => response.json())
    .then(data => console.log(data))
    .catch(error => console.log('Error: ', error));

// does not catch 300 errors