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

jQuery-UI
	$('#myDiv').button();
	$('#mySel').buttonset();
	
	$('#draggables').draggable();
	$('#draggables').children.draggable();
	
	$('#d1').draggable({ axis: "x" });
	$('#d2').draggable({ axis: "y" });
	$('#d3').draggable({ containment: "#draggables" });
	
	$('#d1, #d2, #d3').draggable("option", "stack", ".ui-draggable");
	
	$('#d1').draggable({
		revert: "invalid";
	});
	
	$("#trash").droppable();
	$("#trash").droppable({	
		accept: "#d3",
		drop: funcion(event, ui) {
			ui.draggable.remove();
		}
	});
	
	$("#sortable").sortable();
	$("#sortable").sortable({ placeholder: "placeholder" });
	
	$("#d3").resizable();
	
	
Plugins
	http://plugins.jquery.com/
	http://jquery-plugins.net/
	
	
	maxlength 
	typeahead
	listnav
	
	
https://app.pluralsight.com/profile/author/elijah-manor
https://app.pluralsight.com/profile/author/dan-wahlin


makeArray	=> Convert an array-like object into a true JavaScript array.
inArray	=> check if item exists in array
unique	=> unique items in array
merge	=> join 2 arrays
map		=> apply a function in each item and return a new array. Translate all items in an array or object to new array of items.
grep	=> Finds the elements of an array which satisfy a filter function. The original array is not affected.


	<script type="text/javascript">
	
		var myArray = [1,2,3,3,4,4,5];
		var myArray2 = [6,7,8];
		
		if($.inArray(4, myArray) != -1)
			console.log("4 is in the array");
	
		if($.inArray(44, myArray) != -1)
			console.log("44 is in the array");
			
		$.unique(myArray);
		console.log(myArray);
		
		$.merge(myArray, myArray2);
		console.log(myArray);
		
		var newArray = $.map(myArray, function(item, idx) {
			return item * 2;
		});
		console.log(newArray);
		
		var greppedArray = $.grep(myArray, function(item) {
			return item%2 == 0;
		});
		console.log(greppedArray);
		
			
	$(function() {
		console.log($.makeArray($("div")));
		
	});
		
	</script>
	
	<div id="out1">1</div>
	<div id="out2">2</div>
	<div id="out3">3</div>
	<div id="out4">4</div>
	<div id="out5">5</div>
	<div id="out6">6</div>
	<div id="out7">7</div>
	
	
var q = $('form').serialize();
var a = $('form').serializeArray();
$.each(a, function(i, field) {
	console.log(field.name +', '+ field.value);
});

$('form').submit(function (event) {
	alert('submitting!');
	event.preventDefault();
});

Fuel UX
http://getfuelux.com/

TypeAhead.js
Hogan template


