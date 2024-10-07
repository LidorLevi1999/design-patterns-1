using System.Drawing;

public class MemeTextDecorator : IMemeText
{
    protected IMemeText m_MemeText;

    public MemeTextDecorator(IMemeText i_MemeText)
    {
        this.m_MemeText = i_MemeText;
    }

    public void Draw(Graphics i_Graphics, string i_Text, Font i_Font, Color i_Color, Size i_ImageSize, bool i_IsTopText)
    {
        m_MemeText.Draw(i_Graphics, i_Text, i_Font, i_Color, i_ImageSize, i_IsTopText);
    }
}
