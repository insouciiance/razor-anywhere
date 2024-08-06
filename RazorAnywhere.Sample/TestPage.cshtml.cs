namespace RazorAnywhere.Sample;

public class TestPageModel
{
    public string Snack { get; set; }

    public (string Name, int Age)[] People { get; set; }
}
