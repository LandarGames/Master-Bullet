using UnityEngine.UI;
using UnityEngine;

public class Dop_bullet_text : MonoBehaviour
{
    private Image im;
    private Text text;
    [SerializeField] private bool bull;
    private float time;

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
    }
}
