using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirMaker.model
{

    class FolderMaker
    {
        private string inputFilePath;
        private string outputFolderPath;

        public FolderMaker(string inputFilePath, string outputFolderPath)
        {
            this.inputFilePath = inputFilePath;
            this.outputFolderPath = outputFolderPath;
        }

        public bool goProcedure() {

            string alltext = null;
            try
            {
                alltext = File.ReadAllText(inputFilePath);
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
                
            string[] folders = alltext.Split('\n');

            foreach (string item in folders)
            {
                try { 
                    Directory.CreateDirectory(outputFolderPath + "\\" + item);
                } catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            return true;
        }

    }
}
