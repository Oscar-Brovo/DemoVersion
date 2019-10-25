using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows;

namespace OBDemoProgram
{
    public class FileHandler
    {
        private string filePath;
        private FileStream stream;
        private StreamReader reader;
        private StreamWriter writer;

        public FileHandler(string filePathParam = "Problem.txt")
        {
            this.filePath = filePathParam;
        }

        public bool WriteDataToTXT(List<string> dataToWrite)
        {

            bool flag = true;

            try
            {
                if (File.Exists(this.filePath))
                {
                    stream = new FileStream(this.filePath, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    stream = new FileStream(this.filePath, FileMode.Create, FileAccess.Write);
                }

                writer = new StreamWriter(stream);

                foreach (string itemToWrite in dataToWrite)
                {
                    
                    writer.WriteLine(itemToWrite);

                    writer.Flush();
                }
            }
            catch (System.Exception)
            {

                flag = false;
            }
            finally
            {
                writer.Close();
                stream.Close();
            }
            return flag;

        }

        public bool RewriteDataToTXT(List<string> dataToWrite)
        {
            bool flag = true;
            try
            {
               
                stream = new FileStream(this.filePath, FileMode.Create, FileAccess.Write);
                

                writer = new StreamWriter(stream);

                foreach (string itemToWrite in dataToWrite)
                {

                    writer.WriteLine(itemToWrite);

                    writer.Flush();
                }
            }
            catch (System.Exception)
            {

                flag =  false;
            }
            finally
            {
                writer.Close();
                stream.Close();
            }

            return flag;



        }

        public List<string> ReadDataFromTXT()
        {
            List<string> dataRaw = new List<string>();
            try
            {
                if (File.Exists(this.filePath))
                {
                    stream = new FileStream(this.filePath, FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(stream);

                    while (!reader.EndOfStream)
                    {
                        dataRaw.Add(reader.ReadLine());
                    }

                    
                }
                else
                {
                    stream = new FileStream(this.filePath, FileMode.Create, FileAccess.Write);
                    reader = new StreamReader(stream);

                }
            }
            catch (System.Exception)
            {
                return null;
            }
            finally
            {
                try
                {
                    stream.Close();
                    reader.Close();
                    
                }
                catch (System.Exception)
                {

                    
                }
            }

            return dataRaw;
        }
    }
}
