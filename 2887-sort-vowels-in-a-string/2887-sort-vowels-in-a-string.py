class Solution:
    def sortVowels(self, s: str) -> str:
        vowels = "aeiouAEIOU"
        vowel_positions = [i for i, char in enumerate(s) if char in vowels]
        sorted_vowels = sorted([s[i] for i in vowel_positions])
        t = list(s)
        
        for i, vowel in enumerate(sorted_vowels):
            t[vowel_positions[i]] = vowel
        
        return ''.join(t)