using System.IO;
using System.Text.RegularExpressions;

namespace FileParser
{
    class FileParser
    {
        private string path;

        public FileParser WithPath(string path)
        {
            this.path = path;
            return this;
        }

        private string lineForSearch;

        public FileParser WithLineForSeach(string lineForSearch)
        {
            this.lineForSearch = lineForSearch;
            return this;
        }

        private string lineForReplace;

        public FileParser WithLineForReplace(string lineForReplace)
        {
            this.lineForReplace = lineForReplace;
            return this;
        }

        public int CountStr()
        {
            int amount;
            using (StreamReader readFile = new StreamReader(path))
            {
                string text = readFile.ReadToEnd();
                readFile.Close();
                amount = new Regex(lineForSearch).Matches(text).Count;
            }

            if (amount > 0)
            {
                return amount;
            }
            return 0;
        }
        public void ReplaceStr()
        {
            string text;

            using (StreamReader readFile = new StreamReader(path))
            {
                text = readFile.ReadToEnd();
                readFile.Close();

                text = Regex.Replace(text, lineForSearch, lineForReplace);
            }

            using (StreamWriter writeFile = new StreamWriter(path))
            {
                writeFile.Write(text);
                writeFile.Close();
            }
        }
    }
}
