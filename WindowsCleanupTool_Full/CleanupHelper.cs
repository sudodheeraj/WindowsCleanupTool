using System;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsCleanupTool
{
    public static class CleanupHelper
    {
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        private static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, uint dwFlags);

        public static void DeleteFolder(string path, StreamWriter log)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    foreach (string file in Directory.GetFiles(path))
                    {
                        try
                        {
                            File.Delete(file);
                            log.WriteLine($"Deleted file: {file}");
                        }
                        catch (Exception ex)
                        {
                            log.WriteLine($"Failed to delete file: {file} - {ex.Message}");
                        }
                    }

                    foreach (string dir in Directory.GetDirectories(path))
                    {
                        try
                        {
                            Directory.Delete(dir, true);
                            log.WriteLine($"Deleted folder: {dir}");
                        }
                        catch (Exception ex)
                        {
                            log.WriteLine($"Failed to delete folder: {dir} - {ex.Message}");
                        }
                    }
                }
                else
                {
                    log.WriteLine($"Folder not found: {path}");
                }
            }
            catch (Exception ex)
            {
                log.WriteLine($"Error accessing {path} - {ex.Message}");
            }
        }

        public static void EmptyRecycleBin(StreamWriter log)
        {
            try
            {
                SHEmptyRecycleBin(IntPtr.Zero, null, 0);
                log.WriteLine("Recycle Bin emptied successfully.");
            }
            catch (Exception ex)
            {
                log.WriteLine($"Failed to empty Recycle Bin - {ex.Message}");
            }
        }
    }
}
