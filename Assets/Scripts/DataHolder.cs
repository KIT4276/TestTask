using UnityEngine;

public class DataHolder : MonoBehaviour
{
    private Color _color;

    public void AddColor(Color color)
    {
        _color = color;
    }

    public Color GetColor()
        => _color;
}
