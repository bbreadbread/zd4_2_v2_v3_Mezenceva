using ClassLibrary1;
class Program
{
    static void Main(string[] args)
    {
        string answer;
        string[] str;
        using (var reader = new StreamReader("input.txt"))
        {
            str = reader.ReadToEnd().Split(new[] { '\n', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            answer = ClassLibraryVotes.Elections(str);
            File.WriteAllText("output.txt", answer);
        }
    }
}