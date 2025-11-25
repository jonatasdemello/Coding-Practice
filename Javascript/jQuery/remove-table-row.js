// Remove Table Row using jQuery
// Removing a table row is pretty simple. 
// All you need to do is attach the click event to every tr with only td, not th. 
// On click event remove the clicked row. Like this:

$(document).ready(function() {
  $("#tblData tr:has(td)").click(function() {
      $(this).remove();
  });

});

// You can also add some animation while removing the table rows for a better user experience. Like this:

$(document).ready(function() {
  $("#tblData tr:has(td)").click(function() {
    $(this).fadeOut(500, function() {
      $(this).remove();
    });
  });
});

// You will need to add the button in every table row. 
// To delete the row when the delete button is clicked simply attach a click event to all the delete buttons. 
// All the delete buttons will be assigned “delete” CSS class and we’ll use a class selector 
// to select them and then use the closest method to find the row and remove it. Like this:

$(document).ready(function() {
    $('#tblData').on('click', '.delete', function() {
      $(this).closest('tr').remove();
    });
  });
  
  // The closest method returns the first element that matches the selector. 
  // It starts the search from the current element and progresses up through the DOM tree until it finds a match. 
  // Here, an important thing to note is the way the click event is attached. 
  // The following jQuery code uses delegate event approach to attach the click event to all the delete buttons.
  
$('#tblData').on('click', '.delete', function() { });
  
//jQuery .on method has 2 ways to attach events: Direct and Delegate. 
// When a selector is passed, it is considered a delegate event. 
// In this case, the selector is '.delete'. Passing selector is optional. 
// If it’s not present, it is a direct event. 
// The difference between direct and delegate events is that the latter works for dynamically added elements. 
// Direct event only works for the element present on the page at the time of binding the event. 
// It is a best practice to use delegate events as in the future when elements are added dynamically, 
// you won’t have to modify the code. You can check out the code in action at the following link! 
// Remember: the above jQuery code only removes the row from the DOM. 
// You need to code to remove the deleted table row data from the database. 
    
 
// Remove table column using jQuery
  
//   To remove a column, it is not ideal to assign a delete button like we did for removing rows. 
//   Instead, the column will be removed when the column header is clicked. 
//   In the jQuery code, we need to attach a click event to the table header. 
//   First, take a look at the complete jQuery code.
  
$(document).ready(function () {
    $("#tblData tr:has(th)").mouseover(function (e) {
        $(this).css("cursor", "pointer");
    });
    $("#tblData th").click(function () {
        var iIndex = $(this).closest("th").prevAll("th").length;
        $(this).parents("#tblData").find("tr").each(function () {
            $(this).find("td:eq(" + iIndex + ")").remove();
            $(this).find("th:eq(" + iIndex + ")").remove();
        });
    });
});

// This jQuery code performs the following functions:
// • First, it attaches a mouseover event to all TD elements to change the mouse cursor to hand style. 
//     This tells users that the cell is clickable.
// • The code then attaches a click event to the table header columns. 
//     Before removing the column, we need to determine the index of the clicked header column. 
//     The code uses jQuery selectors closest() and prevAll() to determine the index. 
//     The .closest() begins with the current element and travels up the DOM tree until it finds a matching element and the jQuery selector 
//     .prevAll() searches all the predecessors of the current element in the DOM tree. 
//     Once we have the index value, we can run a loop for each table row to remove td and th based on the index value. 
//     Or, instead of removing it, we can hide the td and th by setting the CSS to "display: none".
  
  
  
  