// 40. use group by to partition a list of numbers by their remainder when divided by 5.

public void Linq40() {

    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

    var numberGroups =
        from n in numbers
        group n by n % 5 into g
        select new {Remainder = g.Key, Numbers = g};
}

// 41. use group by to partition a list of words by their first letter.

public void Linq41() {

    string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

    var wordGroups =
        from w in words
        group w by w[0] into g
        select new {FirstLetter = g.Key, Words = g};
}

// 42. use group by to partition a list of products by Category

public void Linq42() {

    List<Product> products = GetProductList();

    var orderGroups =
        from p in products
        group p by p.Category into g
        select new {Category = g.Key, Products = g};
}

// 43. use group by to partition a list of each customer's orders, firt by year,
// and then by month

public void Linq43() {

    List<Customer> customers = GetCustomerList();

    var customerOrderGroups =
        from c in customers
        select new {
            c.CompanyName,
            YearGroups =
                from o in c.orders
                group o by o.OrderDate.Year into yg
                select new {
                    Year = yg.Key,
                    MonthGroups =
                        from o in yg
                        group o by o.OrderDate.Month into mg
                        select new {
                            Month = mg.Key, Orders = mg
                        }
                }
        }
}

// 44. use groupby to partition trimmed elements of an array using a custom
// comparer that matches words that are anagrams of each other.

public void Linq44() {

    string[] anagrams = { "from   ", " salt", " earn ", "  last   ", " near ",
        " form  " };

    var orderGroups = anagrams.GroupBy(w => w.Trim(), new AnagramEqualityComparer());
}
public class AnagramEqualityComparer : IEqualityComparer<string> {
    public bool Equals(string x, string y)
    {
        return getCanonicalString(x) == getCanonicalString(y);
    }

    public int GetHashCode(string obj)
    {
        return getCanonicalString(obj).GetHashCode();
    }

    private string getCanonicalString(string word)
    {
        char[] wordChars = word.ToCharArray();
        Array.Sort<char>(wordChars);
        return new string(wordChars);
    }
}
