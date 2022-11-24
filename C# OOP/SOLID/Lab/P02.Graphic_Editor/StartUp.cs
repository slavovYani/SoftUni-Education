namespace P02.Graphic_Editor
{
    using Models;

    public class StartUp
    {
        static void Main()
        {
            GraphicEditor graphicEditor = new GraphicEditor();

            graphicEditor.DrawShape(new Square());
            graphicEditor.DrawShape(new Rectangle());
            graphicEditor.DrawShape(new Circle());
        }
    }
}