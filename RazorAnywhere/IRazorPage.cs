namespace RazorAnywhere;

public interface IRazorPage
{
    Task<string> RenderAsync();
}
