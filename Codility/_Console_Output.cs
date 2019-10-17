// Output string[]
int[] array = new int[] { 1, 2, 3 };
Console.WriteLine(string.Join(",", array));

int[] array = new int[] { 1, 2, 3 };
foreach(var item in array)
{
    Console.WriteLine(item.ToString());
}

using System.Diagnostics;
Debug.WriteLine("test debug");	// write to Output window
Trace.WriteLine("test trace");	// The Release Solution Configuration project ignores any Debug class method invocations.
TestContext.WriteLine("test context");
Console.WriteLine("test console");

//Console.WriteLine("bin:{0}", bin);
//Debug.WriteLine("bin: " + bin); // write to Output window
//Trace.WriteLine("trace bin: "+ bin);
//TestContext.WriteLine("trace bin:{0}", bin);


// For vs ForEach

static void IterateForeachOnList(List<int> list) {
  foreach(int i in list) 
	{ int j = i; }
}
static void IterateForOnListWithoutCountOptimization(List<int> list) {
  for(int i=0; i < list.Count; i++) 
	{ int j = list [ i ] ; }
}
static void IterateForOnListWithCountOptimization(List<int> list) {
  int count = list.Count;
  for (int i = 0; i < count; i++) 
	{ int j = list [ i ] ; }
}
static void IterateForeachOnArray(int[] array) {
  foreach (int i in array) 
	{ int j = i; }
}
static void IterateForOnArrayWithoutCountOptimization(int[] array) {
  for (int i = 0; i < array.Length; i++) 
	{ int j = array [ i ] ; }
}
static void IterateForOnArrayWithCountOptimization(int[] array) {
  int length = array.Length;
  for (int i = 0; i < length; i++) 
	{ int j = array [ i ] ; }
}
   
