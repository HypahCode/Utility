using Hypah.Utility.FileSystem;

namespace Hypah.Utility.Execution
{
    public static class Explorer
    {
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
