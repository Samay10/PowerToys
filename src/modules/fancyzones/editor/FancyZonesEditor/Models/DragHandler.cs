using System.Windows; // or the appropriate namespace for your UI framework

namespace FancyZonesEditor
{
    public class DragHandler
    {
        private LayoutSwitcher _layoutSwitcher;

        public DragHandler(List<LayoutModel> layouts)
        {
            _layoutSwitcher = new LayoutSwitcher(layouts);
        }

        public void OnMouseDown(Point position)
        {
            _layoutSwitcher.OnMouseDown();
        }

        public void OnMouseMove(Point position)
        {
            _layoutSwitcher.OnMouseMove(position);
        }

        public void OnMouseUp()
        {
            _layoutSwitcher.OnMouseUp();
        }
    }
}
