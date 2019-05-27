using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStoreManagement.Common
{
    public class HandleFile
    {
        public List<string> ReadFile(string fileName)
        {
            List<string> result = new List<string>(); //file text co nhieu dong nen tao list chua tat ca cac dong
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(fileName);

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    result.Add(line);// them 1 line trong file vao list
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return result;
        }
        public void WriteFile(string fileName, List<string> listVal)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw;

                if (!File.Exists(fileName))
                {
                    sw = new StreamWriter(fileName);
                }
                else
                {
                    sw = File.AppendText(fileName);
                }

                foreach (string s in listVal)
                {
                    sw.WriteLine(s);
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
