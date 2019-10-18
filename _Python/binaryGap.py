def solution(N):
    cnt = 0
    result = 0
    found_one = False
    i = N
    while i:
        if i & 1 == 1:
            if (found_one == False):
                found_one = True
            else:
                result = max(result, cnt)
            cnt = 0
        else:
            cnt += 1
        i >>= 1
    return result


def solution(N) :
	return len(max(format(N, 'b').strip('0').split('1')))

Steps explained:
- format(N, 'b') - convert int to binary as suggested in Python documentation
- .strip('0') - strip zeros(rstrip can be also used)
- .split('1') - split at 1 (returns list consisting string of zeros and empty strings)
- max() - find maximum value(as list of string and '00' > '0' is True it returns string with largest number of zeros)
- len() - lenght of string with max zeros



def solution(N):
    binary = "{0:b}".format(N).rstrip('0')
    return len(max(binary.split("1"),key=len))


def solution(N):
    s= str(bin(N)).strip("0b")
    sl= len(s)
    bg=0
    temp=0
    for i in range(sl) :
        if s[i]=="0":
            bg +=1
        if s[i]=="1":
            if temp<bg:
                temp =bg
            bg=0
    return temp

def solution(N):
    binaryNumber = format(N, 'b')
    maximum = 0
    binaryNumberList = binaryNumber.strip('0').split('1')
    for x in binaryNumberList:
        if not x:
            continue
        if len(x) > maximum:
            maximum = len(x)
    return maximum


def solution(N) :
    max_gap = 0
    current_gap = 0
    # Skip the tailing zero(s)
    while N > 0 and N%2 == 0:
        N //= 2
    while N > 0:
        remainder = N%2
        if remainder == 0:
            # Inside a gap
            current_gap += 1
        else:
            # Gap ends
            if current_gap != 0:
                max_gap = max(current_gap, max_gap)
                current_gap = 0
        N //= 2
    return max_gap