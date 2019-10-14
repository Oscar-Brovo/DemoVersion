using System.Collections.Generic;
using System.IO;

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

        public void WriteDataToTXT(List<string> dataToWrite)
        {

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

                throw;
            }
            finally
            {
                writer.Close();
                stream.Close();
            }

        }

        public void RewriteDataToTXT(List<string> dataToWrite)
        {

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

                throw;
            }
            finally
            {
                writer.Close();
                stream.Close();
            }





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
                   // stream = new FileStream(this.filePath, FileMode.Create, FileAccess.Write);
                    // stream = new FileStream("Problem.txt", FileMode.Open, FileAccess.Read);
                    //reader = new StreamReader(stream);
                    //return null;

                }
            }
            catch (System.Exception)
            {

                return null;
            }
            finally
            {
                reader.Close();
                stream.Close();
            }

            return dataRaw;
        }
    }
}
