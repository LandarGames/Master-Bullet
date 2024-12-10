using UnityEngine.UI;
using UnityEngine;

public class Miss : MonoBehaviour
{
    public static bool repeat = false;
    private Image im;
    private Text text;
    [SerializeField] private bool bull;
    public static float time;

    private void Awake()
    {
        im = GetComponent<Image>();
        text = GetComponent<Text>();
        time = 0;
    }
    private void Update()
    {
        time += Time.deltaTime;
        if (bull == true && time >= 0.5f)
        {
            im.color -= new Color(0, 0, 0, 1 * Time.deltaTime);
        }
        else if (bull == false && time >= 0.5f)
        {
            text.color -= new Color(0, 0, 0, 1 * Time.deltaTime);
        }
        if (repeat == true)
        {
            if (time >= 1)
            {
                time = 0;
            }
            if (bull == true)
            {
                im.color = new Color(168f / 255f, 168f / 255f, 168f / 255f, 1);
            }
            if (bull == false)
            {
                text.color = new Color(168f / 255f, 168f / 255f, 168f / 255f, 1);
            }
        }
        if (time >= 0.2)
        {
            repeat = false;
        }
    }
}
