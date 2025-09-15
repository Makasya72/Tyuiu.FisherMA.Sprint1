using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FisherMA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLastLetterToStart(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            string[] words = value.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 1)
                {
                    string word = words[i];
                    char last = word[word.Length - 1];
                    words[i] = last + word.Substring(0, word.Length - 1);
                }
            }
            return string.Join(" ", words);
        }

        public string MoveLetterToStart(string value)
        {
            throw new NotImplementedException();
        }
    }
}
