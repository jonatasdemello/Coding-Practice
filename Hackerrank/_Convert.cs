
// Convert string[] to List<string>

	string[] arr = { "Alpha", "Beta", "Gamma" };
	List<string> list = new List<string>(arr);

	var myArray = new[] { "abc", "123", "zyx" };
	List<string> myList = myArray.ToList();


	string [] array = { "hi","welcome", "to", "forget code"};
	List<string> list = array.ToList();
	foreach (string item in list)
	{
		Console.WriteLine(item);
	}
			
// Convert string to List<int>

	string sNumbers = "1,2,3,4,5";
	var numbers = sNumbers.Split(',').Select(Int32.Parse).ToList();toC

	// no Linq
	List<int> numbers = new List<int>( Array.ConvertAll(sNumbers.Split(','), int.Parse) );

	// Uses Linq
	var numbers = Array.ConvertAll(sNumbers.Split(','), int.Parse).ToList();

	int[] numbers = sNumbers.Split(',').Select(Int32.Parse).ToArray();


// Convert CSV string to List<string>
	
	var names = "Brian,Joe,Chris";
	List<string> result = names.Split(new char[] { ',' }).ToList();
	List<string> result = names.Split(',').ToList();
	

// Convert List<char> to string

	var allowedString = String.Concat(
		inputString.Where(c => allowedChars.Contains(c))
	);

	// new string
	return new string(charSequence.ToArray());

	// Concat
	return string.Concat(charSequence)

	// StringBuilder
	var sb = new StringBuilder();
	foreach (var c in charSequence)
	{
		sb.Append(c);
	}
	return sb.ToString();


// Split string into char[]

	char[] characters = "this is a test".ToCharArray();
	
	var res = test.Select(x => new string(x, 1)).ToArray();
	
