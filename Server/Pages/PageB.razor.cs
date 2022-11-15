namespace Server.Pages;

public partial class PageB
{
    private int CurrentElementA { get; set; }

    private string SearchString { get; set; }

    /// <inheritdoc />
    protected override async Task OnParametersSetAsync()
    {
        this.CurrentElementA = 0;
        this.SearchString = string.Empty;

        // DB Access
        await base.OnParametersSetAsync();
    }

    private async Task OnSelectedElementAChanged(int value)
    {
        this.CurrentElementA = value;
        // DB Access
    }

    private async Task OnSearchStringChanged(string value)
    {
        this.SearchString = value;
        // DB Access
    }
}