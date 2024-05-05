using LeetCode.Core;

public class ReversePrefixOfWord : ITask
{
    public string Description => "Given a 0-indexed string word and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing";

    public string Name => "Reverse prefix of word";

    public Dificulty Dificulty => Dificulty.Easy;

    public (string,char) GetInput()
    {
        Console.Write("Please write a word:");
        var word = Console.ReadLine();
        Console.Write("Please write a character:");
        var ch = (char)Console.Read();

        return (word, ch);
    }

    public void Calculate()
    {
        var (word, ch) = GetInput();
        var indexOfCharacter = word.IndexOf(ch);
        string result = string.Empty;
        if(indexOfCharacter == -1){
            result = word;
        }
        else {
            var charArray = word.Substring(0, indexOfCharacter+1).ToCharArray();
            Array.Reverse(charArray);
            result = new string(charArray) + word.Substring(indexOfCharacter+1);
        }
        System.Console.WriteLine(result);
    }

    // public void Calculate()
    // {
    //     var (word, ch) = GetInput();
    //     var charArray = new char[word.Length];
    //     for(int i = 0; i < word.Length; i++){
    //         if(word[i]==ch){
    //             for(int charArrayIndex = 0, wordIndex = i; wordIndex >= 0; wordIndex-- , charArrayIndex++)
    //             {
    //                 charArray[charArrayIndex] = word[wordIndex];
    //             }
    //             for(int index = i+1; index < word.Length; index++)
    //             {
    //                 charArray[index] = word[index];
    //             }
    //             break;
    //         }
    //         else if(i == word.Length - 1){
    //             charArray = word.ToArray();
    //         }
    //     }
    //     System.Console.WriteLine(new string(charArray));
    // }
}