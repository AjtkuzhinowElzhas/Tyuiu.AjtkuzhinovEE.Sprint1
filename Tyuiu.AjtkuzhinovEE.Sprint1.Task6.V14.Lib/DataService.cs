using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AjtkuzhinovEE.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            bool flag = true;
            char[] russianLetters = new char[33];
            for (int i = 0; i < 32; i++)
            {
                russianLetters[i] = (char)('а' + i);
            }
            russianLetters[32] = ' ';
            foreach (char c in value)
            {
                if (!Array.Exists(russianLetters, element => element == c))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
