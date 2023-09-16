string inputFile = "C:\\Users\\jyf00\\Desktop\\oop\\Documents\\theMachineStops.txt";
string directoryPath = Path.GetDirectoryName(Path.GetFullPath(inputFile));

Directory.SetCurrentDirectory(directoryPath);

string inputText;

inputText = File.ReadAllText(inputFile);

string modifiedText = inputText.Replace(".", " STOP");

string outputFile = "TelegramCopy.txt";

File.WriteAllText(outputFile, modifiedText);

