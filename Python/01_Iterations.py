print("range(0, 4)")
for i in range(0, 4):
    print i

print("range(5)")
for i in range(5):
    print i

n = 5
for i in range(1, n+1):
    for j in range(i):
        print '*',
    print

print("range(start, stop, step)")
n = 4 
# print each row
for i in range(n, 0, -1):
    # print identation
    for j in range(n - i):
        print ' ',
    # print *
    for j in range(2 * i - 1):
        print "*",
    print

# Given a positive integer n, how can we count the number of digits in its decimal representation
n = 123456
res = 0
while n > 0:
    n = n // 10 # floor division discards the fractional part
    res += 1

print res

days = ['Monday', 'Tuesday', 'Wednesday', 'Thursday','Friday', 'Saturday', 'Sunday']
for d in days:
    print d

# If you loop over a set of values, the body of the loop is executed exactly once for every
# value in the set; however, the order in which the values are processed is arbitrary.
print(' -- using set --')
days1 = set(['Monday', 'Tuesday', 'Wednesday', 'Thursday','Friday', 'Saturday', 'Sunday'])
for d in days1:
    print d

# Looping over a dictionary means looping over its set of keys. Again, the order in which
# the keys are processed is arbitrary.
print(' -- using dictionary --')
days2=  {'mon': 'Monday', 'tue': 'Tuesday', 'wed': 'Wednesday', 'thu': 'Thursday', 'fri': 'Friday', 'sat': 'Saturday','sun': 'Sunday'}
for d in days2:
    print d, 'stands for', days2[d]
    
