namespace Server.Components;

using Microsoft.AspNetCore.Components;
using Server.States;

public partial class HeaderNavigationContent
{
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Inject]
    private HeaderNavigationState HeaderNavigationState { get; set; }

    /// <inheritdoc />
    protected override void OnParametersSet()
    {
        this.HeaderNavigationState.Content = this.ChildContent;
        base.OnParametersSet();
    }
}