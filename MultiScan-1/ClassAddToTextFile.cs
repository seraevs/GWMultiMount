using System.IO;

namespace MultiScan_1
{
    class ClassAddToTextFile
    {
        public void WriteToTextFile(string filePath, string data)
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter outputFile = File.CreateText(filePath))
                {
                    outputFile.WriteLine(data);
                    outputFile.Close();
                }
            }
            else
            {
                using (StreamWriter outputFile = File.AppendText(filePath))
                {
                    outputFile.WriteLine(data);
                    outputFile.Close();
                }
            }
        }
    }
}
