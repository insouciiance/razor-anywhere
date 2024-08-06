using RazorAnywhere;
using RazorAnywhere.Sample;

TestPageModel model = new()
{
    Snack = "Doritos",
    People = [("John", 42), ("J.", 41), ("Nick", 40)]
};

IRazorPage page = new TestPage()
{
    Model = model
};

string text = await page.RenderAsync();
Console.WriteLine(text);
