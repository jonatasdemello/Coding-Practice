function solution(N)
{
    // write your code in JavaScript (Node.js 4.0.0)
    // https://codility.com/demo/results/trainingT4YUUR-XKN/
    var tx = N.toString(2), l = tx.length, b = 0, t = 0, i = 0;
    while (i < l)
    {
        if (tx[i] === "0")
        {
            b++;
        }
        if (tx[i] == "1")
        {
            if (t < b)
            {
                t = b;
            }
            b = 0;
        }
        i++;
    }
    return t;
}