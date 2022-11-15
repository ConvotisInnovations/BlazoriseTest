namespace Server.Components;

using Microsoft.AspNetCore.Components;

/// <summary>
/// Component, which is used to display a styled button to add an element.
/// </summary>
public partial class AddButton
{
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public EventCallback OnClick { get; set; }
}