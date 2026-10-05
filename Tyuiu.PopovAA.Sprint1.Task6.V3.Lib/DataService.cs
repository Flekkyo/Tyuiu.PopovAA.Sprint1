using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PopovAA.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string final_word = "";
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == ' ' && value[i - 1] != ' ')
                {
                    final_word += value[i - 1];
                }
            }

            if (value[value.Length - 1] != ' ')
            {
                final_word += value[value.Length - 1];
            }

            return final_word;
        }
    }
} 
