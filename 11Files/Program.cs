using System;
using System.IO;

namespace LearningCsharp
{
    class Files
    {
        static void Main(string[] args)
        {
            #region FileStream Class
            /*
            FileStream F = new FileStream(@"..\..\Resources\test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            */
            #endregion

            #region StreamReader Class
            /*
            // Read every line in the file.
            using (StreamReader reader = new StreamReader(@"..\..\Resources\data.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Do something with the line.
                    Console.WriteLine(line);
                }
            }
            */
            #endregion

            #region StreamWriter Class
            /*
            // Create or open file and write line to it.
            // ... If file exists, it contents are erased before writing.
            using (var writer = new StreamWriter(@"..\..\Resources\example.txt"))
            {
                writer.WriteLine("HELLO");
                writer.Write("World!");
                writer.Write("\t Good To See You!");
            }
            */
            #endregion

            #region File.ReadAllText File.AppendText methods
            /*
            // the easiest way to put file into string
            string file = File.ReadAllText(@"..\..\Resources\data.txt");
            Console.WriteLine(file);

            // the easiest way to append text to a file
            var writer = File.AppendText(@"..\..\resources\data.txt");
            writer.WriteLine("we are thrilled \n by c# code!");
            writer.Close();
            */
            #endregion

            #region File.ReadAllLines method
            /*
            // Read in every line in specified file.
            // ... This will store all lines in an array in memory.
            string[] lines = File.ReadAllLines(@"..\..\Resources\data.txt");  // (.Length) to count lines
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            */
            #endregion

            #region Directories operations
            /*
            string path = @"..\..\Resources\example.txt";

            string extension = Path.GetExtension(path);
            string filename = Path.GetFileName(path);
            string filenameNoExtension = Path.GetFileNameWithoutExtension(path);
            string root = Path.GetPathRoot(path);
            string directory = Path.GetDirectoryName(path);
            string fullPath = Path.GetFullPath(path);
            Console.WriteLine("Path string separator in windows variables is: {0}", Path.PathSeparator);
            Console.WriteLine("Directory separator in windows variables is: {0}", Path.DirectorySeparatorChar);
            Console.WriteLine("\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}", extension, filename, filenameNoExtension, root, directory, fullPath);
            
            Directory.CreateDirectory("");
            Directory.Delete("", true); // deletes recursively folder and sub folders and files
            Directory.GetFileSystemEntries(""); // returns files and subfolders
            */

            #endregion

            #region File Info methods
            /*
            FileInfo info = new FileInfo(@"..\..\Resources\example.txt");
            Console.WriteLine(info.Length + " (bytes)");

            //Actions.We copy, delete, rename or get time information about files. These actions are available through the File type and the FileInfo type.
            File.CreateText("");
            File.Copy("","");
            File.Delete("");
            File.Exists("");
            File.GetLastWriteTimeUtc("");
            */
            #endregion

            Console.ReadLine();
        }
    }
}
