/// <summary>
/// Thrown if a file can't be read.
/// </summary>
class CouldNotReadGDCMFileException : System.Exception
{
    public CouldNotReadGDCMFileException(string filename) : base("could not read file " + filename) { }
}