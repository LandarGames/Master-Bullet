using UnityEngine;
using UnityEngine.UI;

public class Sravn : MonoBehaviour
{
    private Image im;

    private void Awake()
    {
        im = GetComponent<Image>();
    }

    private void Update()
    {
        if (Spavn_gun.gun == Lobby_machine.weapons_what)
        {
            im.color = new Color(im.color.r, im.color.g, im.color.b, 0.9f);
        }
        else if (Spavn_gun.gun  != Lobby_machine.weapons_what)
        {
            im.color = new Color(im.color.r, im.color.g, im.color.b, 255);
        }
    }
}
