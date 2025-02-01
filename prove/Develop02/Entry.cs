using System.IO;
class Entry
{
    public void Save(string filename, List<string> entries)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
}