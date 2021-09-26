using System.IO;

namespace ConsoleApp2
{
    class classFile : classPath
    {
        public static void pasteFile(object number)
        {
            string path = Directory.GetCurrentDirectory() + pathFiles_test[0];
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }

            File.AppendAllText(path, number + "\n");
        }

        private static void pasteFile_testMethods(string[] name, double numbers, byte variant)
        {
            foreach (string kol in name)
            {
                string path = Directory.GetCurrentDirectory() + kol;
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }
            }
        }
    }
}