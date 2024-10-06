using System.Drawing;

public interface IMemeText
{
    void Draw(Graphics i_Graphics, string i_Text, Font i_Font, Color i_Color, Size i_ImageSize, bool i_IsTopText);
}
