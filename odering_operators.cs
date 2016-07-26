// 28. use orderby to sort a list of words alphabetically

public void Linq28() {

    string[] words = {"cherry", "apple", "blueberry"};

    var sortedWords =
        from w in words
        orderby w
        select w;
}

// 29. use orderby to sort a list of words by length.

public void Linq29() {

    string[] words = {"cherry", "apple", "blueberry"};

    var sortedWords =
        from w in words
        orderby w.Length
        select w;
}

// 30. use orderby to sort a list of products by name

public void Linq30() {

    List<Product> products = GetProductList();

    var sortedProducts =
        from p in products
        orderby p.ProductName
        select p;
}

// 31. use orderby clause with a custom comparer to do a case-indensitive sort
// of the words in an array

public void Linq31() {

    string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr",
        "cHeRry" };

    var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());
}

public class CaseInsensitiveComparer : IComparer<string> {
    public int Compare(string x, string y) {
        return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}

// 32. use orderby and descending to sort a list of doubles from highest to
// lowest.

public void Linq32() {

    double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

    var sortedDoubles =
        from d in doubles
        orderby d descending
        select d;
}

// 33. use orderby to sort a list of products by units in stock from highest to
// lowest

public void Linq33() {

    List<Product> products = GetProductList();

    var sortedProducts =
        from p in products
        orderby p.UnitsInStock descending
        select p;

    ObjectDumper.Write(sortedProducts);
}

// 34. use an orderby clause with a custom comparer to do a case-insensitive
// descending sort of the words in an array

public void Linq34() {

    string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr",
        "cHeRry" };

    var sortedWords = words.OrderByDescending(a => a, new CaseInsensitiveComparer());
}
public class CaseInsensitiveComparer : IComparer<string> {
    public int Compare(string x, string y) {
        return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}

// 35. use a compound orderby to sort a list of digits, first by length of their
// name, and then alphabetically by the name itself

public void Linq35() {

    string[] digits = { "zero", "one", "two", "three", "four", "five", "six",
        "seven", "eight", "nine" };
    var sortedWords = digits.Orderby(a => a.Length).ThenBy(b => b);
}

// 36. use an orderby and a ThenBy clause with a custom comparer to sort first
// by word length and then by a case-insensitive sort of the words in an array.

public void Linq36() {

    string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr",
        "cHeRry" };

    var sortedWords = words.OrderBy(a => a.Length).ThenBy(b => b,
        new CaseInsensitiveComparer());
}
public class CaseInsensitiveComparer : IComparer<string> {
    public int Compare(string x, string y) {
        return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}

// 37. use a compound orderby to sort a list of products, first by category, and
// then by unit price, from highest to lowest.

public void Linq37() {

    List<Product> products = GetProductList();

    var sortedProducts =
        from p in products
        orderby p.Category, p.UnitPrice descending
        select p;
}

// 38. use an orderby and a thenby clause with a custom comparer to sort first
// by word length and then by a case-insensitive descending sort of the words
// in an array.

public void Linq38() {

    string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

    var sortedWords =
        words.OrderBy(a => a.Length)
             .ThenByDescending(a => a, new CaseInsensitiveComparer());

    ObjectDumper.Write(sortedWords);
}
public class CaseInsensitiveComparer : IComparer<string> {
    public int Compare(string x, string y) {
        return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}

// 39. use reverse to create a list of all digits in the array whose second letter is 'i'
// that is reversed from the order in the original array

public void Linq39() {
    string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    var reversedDigits =
        (from d in digits
        where d[1] = 'i'
        select d).Reverse();
}
