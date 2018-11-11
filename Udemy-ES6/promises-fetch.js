url = "https://jsonplaceholder.typicode.com/posts/";

//fetch(url).then(data => console.log(data));

fetch(url)
    .then(response => response.json())
    .then(data => console.log(data))
    .catch(error => console.log('Error: ', error));

// does not catch 300 errors