namespace CoverletTestTools;

public class FileSystem
{
    // public IEnumerable<FileInfo> GetFileInfosInDirectory(string pathToFiles, SearchOption searchOption = SearchOption.AllDirectories, string searchWildcard = "*")
    public IEnumerable<FileInfo> GetFileInfosInDirectory(string pathToFiles, SearchOption searchOption, string searchWildcard = "*")
    {
        return new DirectoryInfo(pathToFiles).GetFiles(searchWildcard, searchOption);
    }
}
