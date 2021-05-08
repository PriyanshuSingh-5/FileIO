using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO");
            // FileExist();
            //ReadAlllines();
            // ReadAtOnce();
            // CopyData();
            //DeleteFile();
            WriteLines();
            Console.ReadLine();
        }


        public static bool FileExist() //method to check if file exist or not
        {
            try
            {
                string path = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\sample.txt";
                if (File.Exists(path))
                {
                    Console.WriteLine("File exists");
                    return true;
                }
                else
                {
                    Console.WriteLine("File not exist");
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static void ReadAlllines() //method to read all lines in the file
        {
            try
            {
                string path = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\sample.txt";
                if (File.Exists(path))
                {
                    string[] result = File.ReadAllLines(path);
                    foreach (string line in result)
                    {
                        Console.WriteLine(line);
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void ReadAtOnce() //method to read all the text at once
        {
            try
            {
                string path = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\sample.txt";

                if (File.Exists(path))
                {
                    string result = File.ReadAllText(path);
                    Console.WriteLine(result);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void CopyData() //method to copy data from one to another
        {
            try
            {
                string source = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\sample.txt";
                string destination = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\target.txt";

                if (File.Exists(source))
                {
                    File.Copy(source, destination);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void DeleteFile() //method to delete the file
        {
            try
            {
                // string source = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\sample.txt";
                string destination = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\target.txt";

                if (File.Exists(destination))
                {
                    File.Delete(destination);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void WriteLines() //method to delete the file
        {
            try
            {
                string source = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\sample.txt";
                //string destination = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\target.txt";

                if (File.Exists(source))
                {
                    string content = "Adding extra information";
                    File.WriteAllLines(source, content);
                    ReadAtOnce();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void ReadingDataStreamer() //method to read using streamer using stream close to close file
        {
            try
            {
                string path = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\sample.txt";


                if (File.Exists(path))
                {
                    string line = "";
                    StreamReader sr = File.OpenText(path);
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    sr.Close();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void ReadingDataStreamerUsingKeyword() //method to read using streamer by using keyword
        {
            try
            {

                string path = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\sample.txt";

                if (File.Exists(path))
                {
                    string line = "";
                    using (StreamReader sr = File.OpenText(path)) 
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    //sr.Close();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void WriteDataStreamer() //method to read using streamer by using keyword
        {
            try
            {

                string path = @"C:\Users\K.R.DHASHNIGA\source\repos\FileIO\FileIO\sample.txt";

                if (File.Exists(path))
                {
                   
                    using(StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Adding data from writer");
                    }
                    //sr.Close();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }

}