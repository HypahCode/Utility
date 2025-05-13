using Hypah.Utility.FileSystem;

namespace Hypah.Utility.Execution
{
    public static class Explorer
    {
        /// <summary>
        /// Opens explorer with a specified file name highlighted
        /// </summary>
        /// <param name="path"></param>
        /// <exception cref="FileNotFoundException"></exception>
        public static void OpenFileLocation(FilePath path)
        {
            if (path.Exists)
            {
                var process = Execute.Process("explorer.exe")
                    .WithArguments("/e,", "/select", path.ToString())
                    .WithShellExecute(true)
                    .Start();
            }
            else
            {
                throw new FileNotFoundException($"File not found: {path}");
            }
        }
    }
}
