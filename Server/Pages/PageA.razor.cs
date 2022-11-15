namespace Server.Pages;

public partial class PageA
{ 
    private int CurrentElementA { get; set; }

    private int CurrentElementB { get; set; }

    private DateTime CurrentDate { get; set; }

    /// <inheritdoc />
    protected override async Task OnParametersSetAsync()
    {
        this.CurrentElementA = 0;
        this.CurrentElementB = 1;
        this.CurrentDate = DateTime.Today;

        // DB Access
        await base.OnParametersSetAsync();
    }

    private async Task OnSelectedElementAChanged(int value)
    {
        this.CurrentElementA = value;
        // DB Access
    }

    private async Task OnSelectedElementBChanged(int value)
    {
        this.CurrentElementB = value;
        // DB Access
    }

    private async Task OnSelectedDateChanged(DateTime date)
    {
        this.CurrentDate = date;
        // DB Access
    }
}