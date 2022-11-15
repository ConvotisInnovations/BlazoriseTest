namespace Server.States;

using Microsoft.AspNetCore.Components;

public class HeaderNavigationState
{
    private RenderFragment content;

    public event EventHandler ContentChanged;

    public RenderFragment Content
    {
        get => this.content;
        set
        {
            this.content = value;
            this.ContentChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}