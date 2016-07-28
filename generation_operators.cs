// 64. use Range to generatoe a sequence of numbers from 100 to 149 that is used
// to find which numbers in that range are odd and even.

public void Linq65() {
    var numbers =
        from n in Enumerable.Range(100, 50)
        select new {Number = n, OddEven = n % 2 == 1 ? "Odd" : "Even"};
}

// 65. use Repeat to generate a sequence that contains the number 7 ten times.

public void Linq66() {
    var numbers = Enumerable.Repeat(7, 10);
}
