
function Fn_object_literal_1(){

    const inventory = [ 
        {title: 'Javascript', price: 20},
        {title: 'C#', price: 15},
        {title: 'Java', price: 10}
    ];
    function createBookShop(inventory){
        return {
            inventory: inventory,
            inventoryValue: function(){
                return this.inventory.reduce( (total, book) => total + book.price, 0);
            },
            priceForTitle: function(title){
                return this.inventory.find( book => book.title === title).price;
            }
        };
    }
    const bookShop = createBookShop(inventory);
    console.log(bookShop.inventoryValue());
    console.log(bookShop.priceForTitle('Java'));
}
function Fn_object_literal_2(){

    const inventory = [ 
        {title: 'Javascript', price: 200},
        {title: 'C#', price: 150},
        {title: 'Java', price: 100}
    ];
    function createBookShop(inventory){
        return {
            inventory,
            inventoryValue(){
                return this.inventory.reduce( (total, book) => total + book.price, 0);
            },
            priceForTitle(title){
                return this.inventory.find( book => book.title === title).price;
            }
        };
    }
    const bookShop = createBookShop(inventory);
    console.log(bookShop.inventoryValue());
    console.log(bookShop.priceForTitle('Javascript'));
}
function Fn_object3(){
    const red = '#ff0000';
    const blue = '#0000ff';
    const COLORS = { red, blue };

    const canvasDimensions = function(width, initialHeight) {
        const height = initialHeight * 9 /16;
        return { 
            width, 
            height 
        };
    };
    const color = 'red';

    const Car = {
        color,
        drive() {
            return 'Vroom!';
        },
        getColor() {
            return this.color;
        }
    };

}
