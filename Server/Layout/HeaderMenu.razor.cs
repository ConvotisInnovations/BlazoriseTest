namespace Server.Layout;

using Microsoft.AspNetCore.Components;
using Server.States;

/// <summary>
/// Component, which is used to display the toggler and the current header navigation text.
/// </summary>
public partial class HeaderMenu : ComponentBase, IDisposable
{
    [Inject]
    private HeaderMenuState HeaderMenuState { get; set; }

    [Inject]
    private HeaderNavigationState HeaderNavigationState { get; set; }

    /// <inheritdoc />
    public void Dispose()
    {
        this.HeaderNavigationState.ContentChanged -= this.OnChange;
        this.HeaderMenuState.ContentChanged -= this.OnChange;
    }

    /// <inheritdoc />
    protected override void OnInitialized()
    {
        this.HeaderNavigationState.ContentChanged += this.OnChange;
        this.HeaderMenuState.ContentChanged += this.OnChange;
    }

    private async void OnChange(object sender, EventArgs e)
    {
        await this.InvokeAsync(this.StateHasChanged);
    }
}