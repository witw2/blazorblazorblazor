using MyBlazorApp.Models;

public class TodoResponse
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public bool HasNext { get; set; }
    public bool HasPrevious { get; set; }
    public List<DataItem> TodoTitles { get; set; } = new();
}
