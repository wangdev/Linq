// 54. use toarray to imdediately evaluate a sequence into an array

public void Linq54() {

    double[] doubles = {1,7, 2.4, 1.9, 4.1, 2.9};

    var sortedDoubles =
        (from d in doubles
        orderby d descending
        select d).ToArray();
}

// 55. use ToList to imdediately evaluate a sequence into a List<t>

public void Linq55() {
    string[] words = {"cherry", "apple", "blueberray"};

    var sortedWords =
        (from w in words
         orderby w descending
         select w).ToList();
}

// 56. use ToDictionary to immediately evaluate a sequence and a related key
// expression into a dictionary

public void Linq56() {
    var socreRecords = new [] {
        new {Name = "Alice", Score = 50},
        new {Name = "Bob", Score = 40},
        new {Name = "Cathy", Score = 45}
    };

    var scoreRecordDict = scoreRecords.ToDictionary(sr => sr.Name);
}

// 57. use OfType to return only the elements of the array that are of type double

public void Linq57() {
    object[] numbers = {null, 1.0, "two", 3, "four", 5, "six", 7.0};
    var doubles = numbers.OfType<double>();
}
