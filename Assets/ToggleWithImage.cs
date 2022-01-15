using UnityEngine;
using UnityEngine.UI;

public class ToggleWithImage : MonoBehaviour
{
    [SerializeField] Image image;

    public void SetSprite(Sprite sprite)
    {
        image.sprite = sprite;
    }
}
