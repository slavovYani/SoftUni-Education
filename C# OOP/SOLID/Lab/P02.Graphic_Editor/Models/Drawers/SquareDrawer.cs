namespace P02.Graphic_Editor.Models.Drawers
{
    using Contracts;

    public class SquareDrawer : IDrawable
    {
        public string Draw(IDrawable shape) => "I'm Square";
    }
}