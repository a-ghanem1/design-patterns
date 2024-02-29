namespace DesignPatterns.TemplateMethod;

public abstract class CVReportGeneration
{
    public GeneratedReport GenerateCVReport(string filePath)
    {
        var file = ReadFile(filePath);
        var extractedData = ExtractData(file);
        var analyzedData = AnalyzeData(extractedData);
        return GenerateReportOf(analyzedData);
    }

    protected abstract Data ExtractData(File file);

    private AnalyzedData AnalyzeData(Data data)
    {
        Console.WriteLine("analyzing data");
        return new AnalyzedData();
    }

    private File ReadFile(string filePath)
    {
        Console.WriteLine("reading file");
        return new File();
    }

    private GeneratedReport GenerateReportOf(AnalyzedData analyzedData)
    {
        return new GeneratedReport(true);
    }
}