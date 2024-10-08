using System.Drawing;

public class CoreMemeText : IMemeText
{
    public void Draw(Graphics i_Graphics, string i_Text, Font i_Font, Color i_Color, Size i_ImageSize, bool i_IsTopText)
    {
        using (Brush brush = new SolidBrush(i_Color))
        {
            SizeF textSize = i_Graphics.MeasureString(i_Text, i_Font);
            float xAxis = (i_ImageSize.Width - textSize.Width) / 2 - 30;
            float yAxis = i_IsTopText ? 20 : 340;
            i_Graphics.DrawString(i_Text, i_Font, brush, new PointF(xAxis, yAxis));
        }
    }
}
