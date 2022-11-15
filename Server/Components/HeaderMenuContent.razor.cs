namespace Server.Components;

using Microsoft.AspNetCore.Components;
using Server.States;

public partial class HeaderMenuContent
{
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Inject]
    private HeaderMenuState HeaderMenuState { get; set; }

    /// <inheritdoc />
    protected override void OnParametersSet()
    {
        this.HeaderMenuState.Content = this.ChildContent;
        base.OnParametersSet();
    }
}