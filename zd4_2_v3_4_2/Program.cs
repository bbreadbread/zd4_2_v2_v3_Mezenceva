using ClassLibrary1;
class Program
{
    static void Main(string[] args)
    {
        string[] str;
        using (var reader = new StreamReader("input.txt"))
        {
            str = reader.ReadToEnd().Split(new[] { '\n', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            if (ClassLibraryFlowerbad.Check(str) == true)
            {
                int areaBoys = ClassLibraryFlowerbad.RectangleArea("boys");
                int areaGirls = ClassLibraryFlowerbad.RectangleArea("girls");

                int totalArea = areaBoys + areaGirls - ClassLibraryFlowerbad.IntersectionArea();
                File.WriteAllText("output.txt", totalArea.ToString());
            }
            else Console.WriteLine("Операция не может быть выполнена.");
        }
    }
}
