namespace P02.Graphic_Editor.Models
{
    using System;

    using Contracts;

    public class GraphicEditor
    {
        public void DrawShape(IDrawable shape)
            => Console.WriteLine(shape.Draw(shape));
    }
}