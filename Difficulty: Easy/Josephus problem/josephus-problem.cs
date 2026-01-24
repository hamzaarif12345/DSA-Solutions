class Solution {
    public int josephus(int n, int k) {
        // Edge case: no people
        if (n <= 0) return -1;  // or throw exception — depends on problem
        
        // Special case: k=1 means last person survives
        if (k == 1) return n;
        
        // Create circle with people numbered 1 to n
        List<int> people = new List<int>();
        for (int i = 1; i <= n; i++) {
            people.Add(i);
        }
        
        // Start counting from position 0 (person 1)
        int currentIndex = 0;
        
        // Continue until only one person remains
        while (people.Count > 1) {
            // Move (k-1) steps forward from current position
            // (because we start counting from the current person as 1)
            currentIndex = (currentIndex + (k - 1)) % people.Count;
            
            // Eliminate the person at this position
            // Console.WriteLine($"Eliminating {people[currentIndex]}");
            people.RemoveAt(currentIndex);
            
            // IMPORTANT: Do NOT increment currentIndex manually here
            // After removal:
            // - If removed from middle/end-1 → next person is already at currentIndex
            // - If removed the last person → next loop's % operation will wrap to 0
        }
        
        // The last remaining person
        return people[0];
    }
}