using System.Text;
using System.Text.Encodings.Web;

namespace RazorAnywhere;

public abstract class RazorPage<TModel> : Microsoft.AspNetCore.Mvc.Razor.RazorPage<TModel>, IRazorPage
{
    private readonly MemoryStream _output = new();

    public new required TModel Model { get; set; }

    protected RazorPage()
    {
        HtmlEncoder = HtmlEncoder.Default;

        ViewContext = new()
        {
            Writer = new StreamWriter(_output)
        };
    }

    public async Task<string> RenderAsync()
    {
        await ExecuteAsync();

        await Output.FlushAsync();

        _output.Seek(0, SeekOrigin.Begin);
        string text = Encoding.UTF8.GetString(_output.ToArray());
        return text;
    }
}
