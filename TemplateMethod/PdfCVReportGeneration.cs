namespace DesignPatterns.TemplateMethod;

public class PdfCVReportGeneration : CVReportGeneration
{
   protected override Data ExtractData(File file)
   {
      Console.WriteLine("extracting data from pdf");
      return new Data();
   }
}

