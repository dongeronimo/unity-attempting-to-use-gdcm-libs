/// <summary>
/// Thrown if a directory can't be scanned for dicom files.
/// </summary>
class FileScanException : System.Exception
{
    public FileScanException(string path) : base("could not scan path " + path) { }
}
