using System.Drawing;

public class ShadowMemeText : MemeTextDecorator
{
    public ShadowMemeText(IMemeText i_MemeText) : base(i_MemeText) { }

    public override void Draw(Graphics i_Graphics, string i_Text, Font i_Font, Color i_Color, Size i_ImageSize, bool i_IsTopText)
    {
        using (Brush shadowBrush = new SolidBrush(Color.Gray))
        {
            SizeF textSize = i_Graphics.MeasureString(i_Text, i_Font);
            float xAxis = (i_ImageSize.Width - textSize.Width) / 2 - 30 + 2;
            float yAxis = i_IsTopText ? 20 + 2 : 340 + 2; 
            i_Graphics.DrawString(i_Text, i_Font, shadowBrush, new PointF(xAxis, yAxis));
        }

        base.Draw(i_Graphics, i_Text, i_Font, i_Color, i_ImageSize, i_IsTopText);
    }
}
