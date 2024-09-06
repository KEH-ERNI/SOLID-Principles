using SingleResponsibilityPrinciple.Reports;
class Program
{
    static void Main(string[] args)
    {
        Report report = new Report();
        FileManager fileManager = new FileManager();
        Formatter formatter = new Formatter();

        report.GenerateReport("This is some of Khyla's content.");
        report.SetContent(formatter.FormatReport(report.GetContent()));

        string directory = @"C:\Users\Boot Camp\Desktop\bootcamp\KhylaEhzaHondrade\SingleResponsibilityPrinciple\SingleResponsibilityPrinciple"; // please change this file path
        string filename = "report.txt";
        string fullPath = Path.Combine(directory, filename);

        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        fileManager.SaveToFile(fullPath, report.GetContent());
        report.SetContent(fileManager.LoadFromFile(fullPath));

        Console.WriteLine("Loaded Content: " + report.GetContent());
    }
}

