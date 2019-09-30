#Powershell

https://blog.netwrix.com/2018/10/04/powershell-variables-and-arrays/

Write-Host
Write-Output
Write-Debug
Write-Warning
Write-Error/Throw
Write-Verbose
Write-Progress

Get-Variable
Get-Variable | Out-String
Get-Variable | Select Name,Value | Select-String "search term"
Get-Variable | Where {$_.Value -like "*search term*"}
Get-Variable | Where Value -like "*search term*"

$var5 = "Hello World!"
$var5 | Out-File C:\scripts\Hello_World.txt

$var6 = Get-Process
$var6 | SELECT Name, Path | Export-Csv -Path C:\scripts\processes.csv

$var6 = Get-Process
$var6 | ConvertTo-Html -Property Name, Path > C:\scripts\processes.html

Get-Content C:\scripts\processes.csv

# Clear variable
# To clear the contents of a variable, use the Clear-Variable cmdlet:
Clear-Variable -name var6 #without $

# Remove variable
# To completely remove a variable, use the Remove-Variable cmdlet:
Remove-Variable -name var6 #without $


$AutomaticVariables = Get-Variable
function cmpv {
    Compare-Object (Get-Variable) $AutomaticVariables -Property Name -PassThru | Where -Property Name -ne "AutomaticVariables"
}

[string]$var1 = "Netwrix"
or
$var1 = "Netwrix"
$var1.GetType().FullName



Set-Location Env:

$Env:path += ";c:\temp\CAMS3.Web;C:\Workspace\CC.Common\CDN.Deploy"

List variables
Get-Item -Path Env:
Get-ChildItem -Path Env:

function Get-Sum($a, $b)
{
    $a + $b
}

function Get-Sum
{
   [CmdletBinding()]
    param (
        [int] $a,
        [int] $b
    )
 
    $a + $b
}

function Get-Sum
{
   [CmdletBinding()]
    param (
        [int] $a,
        [int] $b
    )
 
    Write-Verbose ("About to add [{0}] and [{1}]" -f $a, $b)
    $a + $b
}

Write-Host "This is yellow text on red background!" -BackgroundColor Red -ForegroundColor Yellow

[int] $i = 0
foreach($i in @(1..100)){
    Write-Host '.' -NoNewline
}

Write-Output
# This cmdlet is used to write output to the pipeline. 
# If it is part of a pipeline, the output is passed down to the receiving command. 
# The values written this way can be captured into a variable. 
# It gets written to the console if it is not passed down the pipeline or assigned to a variable. 

Write-Output “My return value” | Out-GridView
$myString = Write-Output "My return value"
$myString


#Usage: Get-Sum -a 9 -b 5
function Get-Sum($a, $b)
{
   $a + $b
}
Get-Sum -a 9 -b 5
14

#Returning values “intact”
function Get-DataTable()
{
   #Some logic...followed by return value
   #The comma prefix will write to pipeline with value intact!
   ,$myDataTable
}

#Discard any ouput
Write-Output "Send text the console?" | Out-Null


https://ss64.com/ps/syntax-f-operator.html
-f Format operator
		Format a string expression.
		Syntax:
			   "String with placeholders" -f "Array of values to place into the placeholders"
			   'Filename: {0} Created: {1}' -f $_.fullname,$_.creationtime
			   "{I,A:FS} {I,A:FS} {I,A:FS}.." -f "string0", "string1", "string2"...
		Place {0} {1} etc. into the string as placemarkers where you want the variables to appear, immediately follow the string with the -f operator and then lastly, a list of comma separated variables/objects which will be used to populate the placemarkers.
		Key:
		   I   Index of the item to display, 0,1,2 etc.
		   A   Alignment. 
			   A positive number will right align n characters. 
			   A negative number will left align n characters. 
				so {2,-25} will allocate 25 characters of horizontal space on the line, even if the string is only 1 character long. 
		   FS  An optional Format String that acts on the item depending on its type (not case sensitive).
			Valid format strings:
			:c	Currency format (for the current culture)
			:d	Padded. (:dP precision=number of digits); if needed, leading zeros are added to the beginning of the (whole) number.
			:e	Scientific (exp) notation
			:f	Fixed point
			:f5 = fix to 5 places
			:g	Most compact format, fixed or sci
			:g5 = 5 significant digits
			:n	Number (:nP precision=number of decimal places), includes culture separator for thousands 1,000.00
			:p	Percentage
			:r	Reversible Precision
			:x	Hex format
			:hh :mm :ss	Convert a DateTime to a 2 digit Hour/minute/second  "{0:hh}:{0:mm}"
			:HH	Hour in 24 Hour format
			:dd	Day of Month
			:ddd	Convert a DateTime to Day of the Week
			:dddd	Full name of Day of Week
			:yyyy	Full year
			#	Digit Place Holder

		Display a number to 3 decimal places:
		PS C:\> "{0:n3}" -f 123.45678
		123.457

		Right align the first number only:
		PS C:\>"{0,10}" -f 4,5,6
				 4

		Left and right align text:
		PS C:\> "|{0,-10}| |{1,10}|" -f "hello", "world"
		|hello     ||     world|
		
		Display an integer with 3 digits:
		PS C:\> "{0:n3}" -f [int32]12
		012

		Separate a number with dashes (# digit place holder):
		PS C:\> "{0:###-##-##}" -f 1234567
		123-45-67

		Create a list of 100 names with a padded suffix no. (Name001 → Name100):
		1..100 | % { 'Name{0:d3}' -f $_ }

		Convert a number to Hex:
		PS C:\> "{1,10} {0,10} {2,10:x}" -f "First", "Second", 255
			Second     First        FF

		Display filenames and creation time:
		PS C:\> Get-ChildItem c:\docs | ForEach-Object {'Filename: {0} Created: {1}' -f $_.fullname,$_.creationtime}
		
		Display only the Year from a date time value:
		PS C:\> "{0:yyyy}" -f (Get-Date)
		2018

		Display the hours and minutes from a date time value:
		PS C:\> "{0:hh}:{0:mm}" -f (Get-Date)
		17:52

		Reverse the order of display:
		PS C:\> "{2} {1,-10} {0:n3}" -f [math]::pi, "world", "hello"
		hello world 3.142

		Display a number as a percentage:
		PS C:\> "{0:p0}" -f 0.5
		50%

		Display a whole number padded to 5 digits:
		PS C:\> "{0:d5}" -f 123
		00123 

