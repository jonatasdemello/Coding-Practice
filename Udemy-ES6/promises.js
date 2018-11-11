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

