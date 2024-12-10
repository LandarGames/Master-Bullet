using UnityEngine.UI;
using UnityEngine;

public class Srav_skin : MonoBehaviour
{
    private Image im;

    private void Awake()
    {
        im = GetComponent<Image>();
    }

    private void Update()
    {
        if (Lobby_machine.index_skins == Skin.Osn_index)
        {
            im.color = new Color(im.color.r, im.color.g, im.color.b, 0.9f);
        }
        else if (Lobby_machine.index_skins != Skin.Osn_index)
        {
            im.color = new Color(im.color.r, im.color.g, im.color.b, 255);
        }
    }
}
