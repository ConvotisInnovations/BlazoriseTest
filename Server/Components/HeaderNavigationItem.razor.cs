namespace Server.Components;

using Microsoft.AspNetCore.Components;
using Server.States;

public partial class HeaderNavigationItem
{
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string Link { get; set; } = "#";

    [Parameter]
    public bool IsActive { get; set; }
}