using UnityEngine;
using UnityEngine.UI;

public class Effect_hatsot : MonoBehaviour
{
    private Image image;
    public static bool star_ef = false;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        if (star_ef == false)
        {
            image.color -= new Color(0f, 0f, 0f, 5 * Time.deltaTime);
        }
        if (star_ef == true)
        {
            star_ef = false;
            image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
        }
    }


}
