// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

// char [] aiChars = {'а','и','c','b'};
// int n = 3;


// int combinations(int alphLen, int maxWordLen)
// {
//     if (maxWordLen == 0) return 1;
//     else if (maxWordLen % 2 == 0) return combinations(alphLen * alphLen, maxWordLen / 2);
//     else return combinations(alphLen, maxWordLen - 1) * alphLen;
// }

// // Console.WriteLine(combinations(alphLen, 1));
// // Console.WriteLine(combinations(alphLen, 2));
// // Console.WriteLine(combinations(alphLen, 3));
// // Console.WriteLine(combinations(alphLen, 4));

// string[] allWords(char[] letters, int maxWordLength) //delimitered by ' '
// {
//     for (int i = 0; i <= maxWordLength; i++)
//     {

//     }
// // }


//с Интернетов =) https://stackoverflow.com/a/24757048    2014 год
IEnumerable<String> GenerateStrings (IEnumerable<char> characters, int length) {
    if(length > 0) {
        foreach(char c in characters) {
            foreach(String suffix in GenerateStrings(characters,length-1)) {
                yield return c+suffix;
            }
        }
    } else {
        yield return string.Empty;
    }
}

char[] aiLetters = { 'a', 'b', 'c', 'd' };
int maxWordLen = 3;
foreach(string aiword in GenerateStrings(aiLetters,maxWordLen))
{
    Console.WriteLine(aiword);
}


//с лекции Сергея
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet,word,length+1);
    }
}

FindWords("abcd", new char[3]);
