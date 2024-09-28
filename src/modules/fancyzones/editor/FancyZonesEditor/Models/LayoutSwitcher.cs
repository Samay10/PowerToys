public class LayoutSwitcher
{
    private bool _isDragging = false;
    private bool _isSidebarVisible = false;
    private List<LayoutModel> _layouts;
    private Timer _hoverTimer;

    public void OnMouseDown() { /* ... */ }
    public void OnMouseMove(Point currentMousePosition) { /* ... */ }
    public void OnMouseUp() { /* ... */ }
    private void ShowSidebar() { /* ... */ }
    private void OnHoverTimerElapsed(object sender, ElapsedEventArgs e) { /* ... */ }
    public void OnMouseHover(LayoutModel layout) { /* ... */ }
    public void OnLayoutSelected(LayoutModel layout) { /* ... */ }
}
