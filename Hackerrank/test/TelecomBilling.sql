/*
Telecom Billing Invoice
A telecom company charges its customers for both incoming and outgoing calls by the number of call units. 
A call unit is an internal representation of the amount that the company should charge its customers. 
It maintains the records of all the calls made on its network in table, call_record,  storing information such as incoming number, outgoing number, duration of the call and the date on which the call was made. 
Write a query for calculating the billing of all the customers for the month of May 2018. 
The order of output does not matter and should only include customers who have made or received any calls in the given period. The result should be in the following format: name phone_number call_units

 
The company calculates charges as follows:

For incoming calls,
	a standard charge of 1 call unit/second is levied. 
	Example: For an incoming call of 2 minutes 30 seconds, 150 call units will be charged = 120 + 20 = 150 sec

For outgoing calls, 
	a fixed charge of 500 call units is charged for the first 2 minutes of a call, 
	then 2 call units/second is levied against the remainder. 
	Example: For a call of 3 minutes, 620 call units will be charged (500 + 60*2). 3 min = 180s / 2min=120s: 500 +1m=60s * 2


Schema
There are 2 tables: customer_detail and call_record

customer_detail
Name	Type	Description
id

INTEGER	This is the customer's id. It is the primary key.
name

STRING	Customer's name
phone_number

STRING	Customer's phone number
 call_record
Name	Type	Description
id	INTEGER	This the record id.
incoming_number

STRING	Incoming number or the call recipient's number.
outgoing_number

STRING	Outgoing number or the call dialer's number.
duration	INTEGER	Call duration in seconds.
dialed_on

DATE	Call's date.
 Sample Data Tables
*/
customer_detail
id	name	phone_number
1	Geoffrey Chase	8052564516
2	Mollie McGuire	9997156377
3	Galvin Blair	9922536724
4	Elizabeth Vasquez	8068164832

 call_record
id	incoming_number	outgoing_number	duration	dialed_on
1	8068164832	9997156377	245	2018-08-21
2	8052564516	9997156377	264	2018-09-10
3	9997156377	8068164832	258	2018-08-07
4	8068164832	9922536724	172	2018-08-07
5	8068164832	8052564516	171	2018-08-09
6	8052564516	9997156377	99	2018-09-04
 Analyze the billing cycle for September 2018.

 

Sample Output

Geoffrey Chase 8052564516 363
Mollie Mcguire 9997156377 1288
 Explanation

Geoffrey Chase, with phone number 8052564516, has received 2 incoming calls of 264 and 99 seconds each. The billing for this is 363 call units (264 + 99).
Mollie McGuire, with phone number 9997156377, has made 2 outgoing calls of 264 and 99 seconds each. The billing for this is 1288 (500 + 144*2 + 500)
Draft saved 02:56 pm
View Code Diff
MySQL

123456
/*
Enter your query below.
Please append a semicolon ";" at the end of the query
*/

Line: 1 Col: 1
Submit code & ContinueRun Query
(You can submit any number of times)
About Privacy Policy Terms of Service

SET NOCOUNT ON;

/*
Enter your query below.
Please append a semicolon ";" at the end of the query
*/
-- incomin calls 
select * 
from [call_record] c
    inner join [customer_detail] d on d.phone_number = c.incoming_number
where Month(dialed_on) = 5;

-- [name], [phone_number], [call_units]
go


/*
Enter your query below.
Please append a semicolon ";" at the end of the query
*/
-- incoming calls 
select cd.[name], cd.phone_number, cr.duration, cr.duration as billing
--into #income
from [call_record] cr
    inner join [customer_detail] cd on cd.phone_number = cr.incoming_number
where Month(dialed_on) = 5;

-- outgoing calls
select cd.[name], cd.phone_number, cr.duration, 
    case when cr.duration < 180 then 500 end
    when cr.duration >=180 then 500 + (cr.duration - 500) * 2 end    
    as billing
--into #outcome
from [call_record] cr
    inner join [customer_detail] cd on cd.phone_number = cr.outgoing_number
where Month(dialed_on) = 5;

-- [name], [phone_number], [call_units]
go



/*
Enter your query below.
Please append a semicolon ";" at the end of the query
*/
-- incoming calls 
select cd.[name], cd.phone_number, cr.duration, cr.duration as billing
into #income
from [call_record] cr
    inner join [customer_detail] cd on cd.phone_number = cr.incoming_number
where Month(dialed_on) = 5 and Year(dialed_on) = 2018;

-- outgoing calls
insert into #income ([name], phone_number, duration, billing)
select cd.[name], cd.phone_number, cr.duration, 
    case when cr.duration <= 120 then 500 
        when cr.duration > 120 then 500 + (cr.duration - 120) * 2 end
    as billing
from [call_record] cr
    inner join [customer_detail] cd on cd.phone_number = cr.outgoing_number
where Month(dialed_on) = 5 and Year(dialed_on) = 2018;

select [name], [phone_number], sum(billing) as [call_units] from #income group by [name], [phone_number]

drop table #income
go

