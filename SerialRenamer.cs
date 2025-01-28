using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_Renamer
{
    public class SerialRenamer
    {
        private List<string> originalFileNames = new List<string>();
        private List<string> renamedFiles = new List<string>();

        private string beforeName;
        private string afterName;
        private int startNumber;
        private string folderPath;

        public SerialRenamer(string beforeName, string afterName, int startNumber, string folderPath)
        {
            this.beforeName = beforeName;
            this.afterName = afterName;
            this.startNumber = startNumber;
            this.folderPath = folderPath;
        }

        public List<string> StartRename(List<string> files)
        {
            originalFileNames.Clear();
            renamedFiles.Clear();

            int currentNumber = startNumber;
            foreach (string file in files)
            {
                originalFileNames.Add(file);
                string extension = Path.GetExtension(file);
                string newName = $"{beforeName}{currentNumber:00} {afterName}{extension}";
                string newPath = Path.Combine(folderPath, newName);
                string oldPath = Path.Combine(folderPath, file);

                File.Move(oldPath, newPath);

                renamedFiles.Add(newName);
                currentNumber++;
            }

            return renamedFiles;
        }

        public void RedoRename(List<string> _orginal_list, List<string> renamed_list)
        {
            for (int i = 0; i < renamed_list.Count; i++)
            {
                string oldPath = Path.Combine(folderPath, renamed_list[i]);
                string newPath = Path.Combine(folderPath, _orginal_list[i]);

                File.Move(oldPath, newPath);
            }
        }
    }
}
