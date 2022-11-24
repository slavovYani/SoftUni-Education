namespace P02.Graphic_Editor.Models.Drawers
{
    using Contracts;

    public class RectangleDrawer : IDrawable
    {
        public string Draw(IDrawable shape) => "I'm Rectangle";
    }
}