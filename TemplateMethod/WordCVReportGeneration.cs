namespace DesignPatterns.TemplateMethod;

public class WordCVReportGeneration : CVReportGeneration
{
   protected override Data ExtractData(File file)
   {
      Console.WriteLine("extracting data from word");
      return new Data();
   }
}

