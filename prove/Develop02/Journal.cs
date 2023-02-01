
public class Journal 
{
    public string _displayFile = "noSaveJournal.txt";
    string [] _partsLoad;
    string _partsSave;
    // I create a methot to crete the file type .txt and print my entry
    // This was the way I could print it 
    public void CreateFile()
    {
        if (!File.Exists(_displayFile))
        {
            File.CreateText(_displayFile);
        }
    }
    public void DisplayNoSavefile()
    {
        string _noSaveEntries = File.ReadAllText(_displayFile);
        Console.WriteLine(_noSaveEntries);
    }
    // because the .txt file save data, so the requirement say to save in .cvs file
    // I did this because I do not to display my entries because is save in the .cvs file
    public void ClearNoSaveFile()
    {
        File.WriteAllText(_displayFile, "");
    }
    
    // I share the data from .cvs file to the .txt file to display it
    public void DisplayLoad() 
    {
        Console.WriteLine("What is the filename? \nExample: (myFile.cvs)\n");
        string _filename = Console.ReadLine();
        string[] _lines = File.ReadAllLines(_filename);
        foreach (string _line in _lines) 
        {
            _partsLoad = _line.Split(",");
        }
        File.AppendAllLines(_displayFile, _partsLoad);
    }
    // and when I load I save it .cvs file and overwrite because the data
    // still in the file so I reapete the data, streamWriter help to do that
    public void SaveWrite() 
    {
        Console.WriteLine("What is the file name: \nExample: (myFile.cvs)\n");
        string _userInputFile = Console.ReadLine();
        string _sArr = ",";
        string[] _lines = File.ReadAllLines(_displayFile);
        foreach (string _line in _lines)
        {
            _partsSave = String.Join(_sArr, _lines);
        }

        using (StreamWriter _outputFile = new StreamWriter(_userInputFile))
        {
            //outputFile.WriteLine("This will be the first line in the file.");
            _outputFile.WriteLine(_partsSave);
        }
    }           
}
