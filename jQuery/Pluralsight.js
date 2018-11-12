// jQuery

$(document).ready(function () {
    console.log("ready!");
});


// $() is shorthand for $(document).ready()
$(function () {
    console.log("ready!");
});

// You can also pass a named function to $(document).ready() instead of passing an anonymous function.
// Passing a named function instead of an anonymous function.

function readyFn(jQuery) {
    // Code to run when the document is ready.
}
$(document).ready(readyFn);
// or:
$(window).on("load", readyFn);

//There are multiple +1 buttons, and we only want the current button to change when a user's mouse enters and leaves.
//Change the .btn callback functions so only the current button is impacted by mouse enter and mouse leave events.

$('.btn')
    .on('mouseover', event => {
        $(event.currentTarget).addClass('btn-hover');
    })
    .on('mouseleave', event => {
        $(event.currentTarget).removeClass('btn-hover');
    });


$('div').each(function () {
    alert($(this).html());
});

$('div[title="Title"]');

// The .closest() method will travel up the DOM tree to find a specified selector closest to it. Its syntax looks like:
// $('.example-class-one').closest('.another-class');
// In the example above:
// The .closest() method is called on '.example-class' elements.
// The method then targets the element selected by the .closest() method with a class of '.another-class'.
// <div class='.another-class'>
//   <p class='.example-class-one'>1</p>
// </div>
// <div class='.another-class'>
//   <p class='.example-class-two'>2</p>
// </div>

//Given this HTML, the jQuery above would select the <div> element that wraps the paragraph with a value of 1, because it is the closest element, up the DOM tree, with the class .another-class.

// Review: Traversing the DOM
// Understanding how elements relate to each other in the DOM makes it easy to efficiently select elements. We have covered several methods in this lesson including:

// .children() to target an element's child elements.
// .siblings() to target elements adjacent to an element.
// .parent() to target an element's parent.
// .closest() travels up the DOM tree from the current element to target the closest element with a given selector.
// .next() to target the element immediately following the selected element.
// .prev() to target the element that is immediately preceding the selected element.
// .find() to target descendant elements by some selector, ie- class, id, tag etc.

// In addition to these methods, there are even more, including .prevUntil(), .nextUntil() and others. To get an idea, check out Mozilla Developer Network reference for jQuery Traversing.

// $('div[title="Title"]')
// $('div:eq(0)')		=> first div
// $('div:contais("plural")') 	<div>expert plural</div> Case sensitive

// $('tr:odd') - impar 1,3,5,7
// $('td:even') -  par 0,2,4,6

// $('span:first-child')

// $('input[value^="events"]') starts with
// $('input[value$="events"]') ends with
// $('input[value*="events"]') contains

// p	tag
// #	id
// .	class
// ^	start
// $	end
// *	contains

//    http://codylindley.com/jqueryselectors/
//
//
//    jQuery Selectors
//    https://www.w3schools.com/jquery/trysel.asp
//
//    Selector	Example	Selects
//    *	$("*")	All elements
//    #id	$("#lastname")	The element with id="lastname"
//    .class	$(".intro")	All elements with class="intro"
//    .class,.class	$(".intro,.demo")	All elements with the class "intro" or "demo"
//    element	$("p")	All <p> elements
//    el1,el2,el3	$("h1,div,p")	All <h1>, <div> and <p> elements
//        
//    :first	$("p:first")	The first <p> element
//    :last	$("p:last")	The last <p> element
//    :even	$("tr:even")	All even <tr> elements
//    :odd	$("tr:odd")	All odd <tr> elements
//        
//    :first-child	$("p:first-child")	All <p> elements that are the first child of their parent
//    :first-of-type	$("p:first-of-type")	All <p> elements that are the first <p> element of their parent
//    :last-child	$("p:last-child")	All <p> elements that are the last child of their parent
//    :last-of-type	$("p:last-of-type")	All <p> elements that are the last <p> element of their parent
//    :nth-child(n)	$("p:nth-child(2)")	All <p> elements that are the 2nd child of their parent
//    :nth-last-child(n)	$("p:nth-last-child(2)")	All <p> elements that are the 2nd child of their parent, counting from the last child
//    :nth-of-type(n)	$("p:nth-of-type(2)")	All <p> elements that are the 2nd <p> element of their parent
//    :nth-last-of-type(n)	$("p:nth-last-of-type(2)")	All <p> elements that are the 2nd <p> element of their parent, counting from the last child
//    :only-child	$("p:only-child")	All <p> elements that are the only child of their parent
//    :only-of-type	$("p:only-of-type")	All <p> elements that are the only child, of its type, of their parent
//        
//    parent > child	$("div > p")	All <p> elements that are a direct child of a <div> element
//    parent descendant	$("div p")	All <p> elements that are descendants of a <div> element
//    element + next	$("div + p")	The <p> element that are next to each <div> elements
//    element ~ siblings	$("div ~ p")	All <p> elements that are siblings of a <div> element
//        
//    :eq(index)	$("ul li:eq(3)")	The fourth element in a list (index starts at 0)
//    :gt(no)	$("ul li:gt(3)")	List elements with an index greater than 3
//    :lt(no)	$("ul li:lt(3)")	List elements with an index less than 3
//    :not(selector)	$("input:not(:empty)")	All input elements that are not empty
//        
//    :header	$(":header")	All header elements <h1>, <h2> ...
//    :animated	$(":animated")	All animated elements
//    :focus	$(":focus")	The element that currently has focus
//    :contains(text)	$(":contains('Hello')")	All elements which contains the text "Hello"
//    :has(selector)	$("div:has(p)")	All <div> elements that have a <p> element
//    :empty	$(":empty")	All elements that are empty
//    :parent	$(":parent")	All elements that are a parent of another element
//    :hidden	$("p:hidden")	All hidden <p> elements
//    :visible	$("table:visible")	All visible tables
//    :root	$(":root")	The document's root element
//    :lang(language)	$("p:lang(de)")	All <p> elements with a lang attribute value starting with "de"
//        
//    [attribute]	$("[href]")	All elements with a href attribute
//    [attribute=value]	$("[href='default.htm']")	All elements with a href attribute value equal to "default.htm"
//    [attribute!=value]	$("[href!='default.htm']")	All elements with a href attribute value not equal to "default.htm"
//    [attribute$=value]	$("[href$='.jpg']")	All elements with a href attribute value ending with ".jpg"
//    [attribute|=value]	$("[title|='Tomorrow']")	All elements with a title attribute value equal to 'Tomorrow', or starting with 'Tomorrow' followed by a hyphen
//    [attribute^=value]	$("[title^='Tom']")	All elements with a title attribute value starting with "Tom"
//    [attribute~=value]	$("[title~='hello']")	All elements with a title attribute value containing the specific word "hello"
//    [attribute*=value]	$("[title*='hello']")	All elements with a title attribute value containing the word "hello"
//        
//    :input	$(":input")	All input elements
//    :text	$(":text")	All input elements with type="text"
//    :password	$(":password")	All input elements with type="password"
//    :radio	$(":radio")	All input elements with type="radio"
//    :checkbox	$(":checkbox")	All input elements with type="checkbox"
//    :submit	$(":submit")	All input elements with type="submit"
//    :reset	$(":reset")	All input elements with type="reset"
//    :button	$(":button")	All input elements with type="button"
//    :image	$(":image")	All input elements with type="image"
//    :file	$(":file")	All input elements with type="file"
//    :enabled	$(":enabled")	All enabled input elements
//    :disabled	$(":disabled")	All disabled input elements
//    :selected	$(":selected")	All selected input elements
//    :checked	$(":checked")	All checked input elements


/* 
	https://app.pluralsight.com/library/courses/jquery-fundamentals/table-of-contents
*/

// Three simple, but useful, jQuery methods for DOM manipulation are:
// 	text() - Sets or returns the text content of selected elements
// 	html() - Sets or returns the content of selected elements (including HTML markup)
// 	val() - Sets or returns the value of form fields
// 	attr() method is also used to set/change attribute values.

$("#test").text();
$("#test").html();
$("#test").val();
$("#test").attr("val")

$("#btn1").click(function () {
    $("#test1").text("Hello world!");
});
$("#btn2").click(function () {
    $("#test2").html("<b>Hello world!</b>");
});
$("#btn3").click(function () {
    $("#test3").val("Dolly Duck");
});
$("button").click(function () {
    $("#w3s").attr("href", "https://www.w3schools.com/jquery/");
});

// $('div').each(function(index, Element){});

$('div').each(function (index) {
    alert(index + '=' + $(this).text()); // $(this) references the current element (jQuery Object)
    this.title = "Index " + index; // this works with raw DOM properties (raw DOM Object)
});

$('div').each(function (index) {
    $(this).attr('title', 'Index'); // (jQuery Object)
    this.title = "Index " + index; // (raw DOM Object)
});

$('div').each(function (index, elem) {
    alert(index + '=' + $(elem).text());
});

var val = $('#Customer').attr('title'); // (jQuery Object)

$('img').attr('title', 'My title'); // => update
$('img').attr('font-size', '20pt');

// using an Object map
$('img').attr({
    title: 'My title',
    style: 'border: 2px solid black;'
});

$('div.Blue').attr('title', 'My title');
$('div.Blue').attr({
    'title': 'My title'
});
$('div.Blue').attr({
    'title': 'My title',
    'style': 'background-color: yellow'
});

// Set CSS
$("p").css("background-color", "yellow");
// or
$("p").css({
    "background-color": "yellow",
    "font-size": "200%"
});

// Working with Classes:
// *********************
    // .addClass()
    // .hasClass()
    // .removeClass()
    // .toggleClass()

$('p').addClass('myClass');
if($('p').hasClass('myClass')){
    dostuff();
};
$('p').removeClass('myClass');
$('p').addClass(); // remove all classes

$('p').toggleClass('myClass');

// Insert Nodes:
// 	.append()
// 	.appendTo()
// 	.prepend()
// 	.prependTo()

// Remove Nodes:
// 	.remove()

$('<span>office</span>').appendTo('.officePhone');
$('.officePhone').append('<span>office</span>');

$('<span>Phone:</span>').prependTo('.officePhone');
$('.officePhone').prepend('<span>Phone:</span>');


//<div class="state">Arizona</div>
$('.state').wrap('<div class="US_State" />');
// or
$('.state').wrap('<div class="US_State"></div>');
// will produce:
// <div class="US_State"><div class="state">Arizona</div><div>

// remove element from DOM:
$('.phone').remove();


// Handling Events:
// *****************

myButton.addEventListener('click', function(){}, false);
myButton.attachEvent('onclick', function(){}); // IE

// Mouse Events
//     click()
//     dblclick()
//     mouseenter()
//     mouseleave()

// Keyboard Events
//     keypress()
//     keydown()
//     keyup()

// Form Events
//     submit()
//     change()
//     focus()
//     blur()

// Document/Window Events
//     load()
//     resize()
//     scroll()
//     unload()

$('#btn').click(function(){
    alert("test");
})

$(document).mousemove(function(event){ 
    $("span").text("X: " + event.pageX + ", Y: " + event.pageY); 
});

// .on(eventType, handler(eventObject))
$("p").on("click", function(){
    alert("The paragraph was clicked.");
});

// .off(event) remove handler
$('#test').click(handler);
$('#test').off();   // remove all
$('#test').off('click'); // only click


// live() / die() delegate() on()
// allow children to be added to a container without explicitly attaching an event handler to each child
// .on() replaces: bind(), delegate(), live()

$("#myTable tbody").on('click', 'td', function(event){
    alert($(this).text());
});

$("#myTable tbody").on({
    mouseenter: function(){
        $(this).addClass('over');
    },
    mouseleave: function(){
        $(this).removeClass('out');
    }
});

// $(selector).hover(handlerIn, handlerOut)
$('#target').hover(
    function(){
        $(this).css('background-color','red');
    },
    function(){
        $(this).css('background-color','white');
    }
);

$('#target').hover(function(){
    $(this).toggleClass('over');
});


// Working with Ajax
// ******************

// $(selector).load(): loads HTML from server
// $.get() and $.post(): get raw data from server
// $.getJSON(): get/post and return JSON
// $.ajax(): core funcionality

// $(selector).load(url, data, callback)

$('#myDiv').load("page.html #MainTOC");

$('#myDiv').load("getCustomers.aspx", {pageSize: 25});

$('#myDiv').load("getCustomers.aspx", {pageSize: 25}, function(response, status, xhr){
    if(status == "error"){
        alert(xht.statusText);
    }
});

$.get(url, data, callback, datatype);
$.getJSON(url, data, callback);
$.post(url, data, callback, datatype);


// using Fiddler:
// instead of http://localhost:2708 use http://localhost.:2708  (dot in localhost)