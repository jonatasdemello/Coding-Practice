
<%= Html.DropDownList("AlbumId", Model.Albums)%>
<%= Html.TextBox("Title", Model.Title) %>
<%= Html.TextBox("TrackNumber", Model.TrackNumber) %>

The Html.DropDownList helper method likes to work with SelectListItem objects, so a view model you can pair with this view looks like the following:

public class EditSongViewModel
{        
    public string Title { get; set; }                
    public int TrackNumber { get; set; }
    public IEnumerable<SelectListItem> Albums { get; set; }
}

Creating SelectListItems using an extension method

public static IEnumerable<SelectListItem> ToSelectListItems(this IEnumerable<Album> albums, int selectedId)
{
    return albums
			.OrderBy(album => album.Name)
			.Select(album => new SelectListItem
                  {
                    Selected = (album.ID == selectedId),
                    Text = album.Name,
                    Value = album.ID.ToString()
                   });
}

You can use the method like this:

model.Albums = _repository.FindAllAlbums().ToSelectItems(selectedId);


A SelectList object is essentially a collection of SelectListItem objects. 
A SelectListItem has these properties:

Text – intended to hold the visible text for the item (e.g. “Computer Keyboard”)
Value – holds the programmatic value for the item (e.g. “123”)
Selected – a boolean (true/false), holds the selection state of the item


public ActionResult SelectCategory() {
     List<SelectListItem> items = new List<SelectListItem>();
     items.Add(new SelectListItem { Text = "Action", Value = "0"});
     items.Add(new SelectListItem { Text = "Drama", Value = "1" });
     items.Add(new SelectListItem { Text = "Comedy", Value = "2", Selected = true });
     items.Add(new SelectListItem { Text = "Science Fiction", Value = "3" });
     ViewBag.MovieType = items;
     return View();
 }
 
The DropDownList helper used to create an HTML select list requires a IEnumerable<SelectListItem >


https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/working-with-the-dropdownlist-box-and-jquery/using-the-dropdownlist-helper-with-aspnet-mvc
https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/views/using-the-tagbuilder-class-to-build-html-helpers-cs
http://stephenwalther.com/archive/2009/03/03/chapter-6-understanding-html-helpers



	
class Person {
    public int age;
	
	public Person(int initialAge) {
        // Add some more code to run some checks on initialAge
		if(initialAge > 0)
			age = initialAge;
		else{
			age = 0;
			Console.WriteLine("Age is not valid, setting age to 0.");
		}
     }
     public void amIOld() {
        // Do some computations in here and print out the correct statement to the console 
		if(age < 13)
			Console.WriteLine("You are young.");
		else if(age >= 13 && age <18)
			Console.WriteLine("You are a teenager.");
		else
			Console.WriteLine("You are old.");
     }

     public void yearPasses() {
        // Increment the age of the person in here
		age++;
     }
}

for(int i=0; i<10; i++)
{
	Console.WriteLine("{0} x {1} = {2}",n,i, n*i);
}

int n = Convert.ToInt32(Console.ReadLine());

string S = Console.ReadLine();

char strOdd = "";
char strEven = "";

char[] input = S.ToCharArray();
for(int i=0; i < input.Length; i++)
{
	if(i % 2 == 0)
		strOdd = strOdd + input[i];
	else
		strEven = strEven + input[i];
	
}

Console.WriteLine("{0} x {1} = {2}",n,i, n*i);


// Multiply 'n' by 'k' using addition:
private static int nTimesK(int n, int k) {
    System.out.println("n: " + n);
    // Recursive Case
    if(n > 1) { 
        return k + nTimesK(n - 1, k);
    }
    // Base Case n = 1
    else { 
        return k;
    }
}
public static void main(String[] args) {
    int result = nTimesK(4, 4);
    System.out.println("Result: " + result);
}

Binary to Decimal:
(1011)2 => 1 x 2^3 + 0 x 2^2 + 1 x 2^1 + 1 x 2^0 = 8 + 0 + 2 + 1 = (11)10

Decimal to Binary:
(4)10 => 
	4 / 2 = 2 remainder 0 
	2 / 2 = 1 remainder 0
	1 / 2 = 0 remainder 1
	=> (4)10 = (100)2
	

while(n > 0):
    remainder = n%2;
    n = n/2;
    Insert remainder to front of a list or push onto a stack

Print list or stack


