class Comment {
    constructor(content, children){
        this.content = content;
        this.children = children;
    }
    // Array Helpers (map & foreach) doesn't work inside iterators
    *[Symbol.iterator](){
        yield this.content;
        for (let child of this.children) {
            yield* child;
        }
    }
}

const children = [
    new Comment('good',[]),
    new Comment('bad',[]),
    new Comment('ugly',[])
];
const tree = new Comment('New Post!', children);
console.log(tree);

const values = [];
for(let value of tree){
    values.push(value);
}
console.log('values: ', values);