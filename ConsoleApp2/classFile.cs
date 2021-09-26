using System.IO;

namespace ConsoleApp2
{
    class classFile : classPath
    {
        public static void pasteFiles(double[] nums, double answers, byte variantMethod, byte[] kol)
        {
            string path;
            if (variantMethod == 1)
            {
                path = Directory.GetCurrentDirectory() + pathFiles_test[0];
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }
                for (byte i = 0; i < kol.Length; i++)
                {
                    File.AppendAllText(path, nums[i] + "\t");
                }
                File.AppendAllText(path, "\nSum => " + answers + "\n");
            }
            if (variantMethod == 2)
            {
                path = Directory.GetCurrentDirectory() + pathFiles_test[1];
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }

                for (byte i = 0; i < kol.Length; i++)
                {
                    File.AppendAllText(path, nums[i] + "\t");
                }
                File.AppendAllText(path, "\nMul => " + answers + "\n");
            }
            if (variantMethod == 3)
            {
                path = Directory.GetCurrentDirectory() + pathFiles_test[2];
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }

                for (byte i = 0; i < kol.Length; i++)
                {
                    File.AppendAllText(path, nums[i] + "\t");
                }
                File.AppendAllText(path, "\nAverage => " + answers + "\n");
            }
            if (variantMethod == 4)
            {
                path = Directory.GetCurrentDirectory() + pathFiles_test[3];
                if (!File.Exists(path))
                {
                    var file = File.Create(path);
                    file.Close();
                }

                for (byte i = 0; i < kol.Length; i++)
                {
                    File.AppendAllText(path, nums[i] + "\t");
                }
                File.AppendAllText(path, "\nGeomAverage => " + answers + "\n");
            }
        }
    }
}