public class Solution {
    public bool DetectCapitalUse(string word) {
         return word == word.ToUpper() || 
               word == word.ToLower() || 
               (char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower());
    }
}