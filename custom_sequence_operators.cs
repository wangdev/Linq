// 98. calculates the dot pruduct of two integer vectors.

public void Linq98() {
    int[] vectorA = {0, 2, 4, 5, 6};
    int[] vectorB = {1, 3, 5, 7, 9};

    int dotProduct = vectorA.Combine(vectorB, (a, b) => a * b).Sum();j
}

//
