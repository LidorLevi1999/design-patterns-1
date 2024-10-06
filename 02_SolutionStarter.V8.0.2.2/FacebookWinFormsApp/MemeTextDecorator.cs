using System.Drawing;

public class MemeTextDecorator : IMemeText
{
    protected IMemeText memeText;

    public MemeTextDecorator(IMemeText i_MemeText)
    {
        this.memeText = i_MemeText;
    }

    public void Draw(Graphics i_Graphics, string i_Text, Font i_Font, Color i_Color, Size i_ImageSize, bool i_IsTopText)
    {
        memeText.Draw(i_Graphics, i_Text, i_Font, i_Color, i_ImageSize, i_IsTopText);
    }
}
