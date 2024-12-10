using UnityEngine.UI;
using UnityEngine;

public class Shet_kill : MonoBehaviour
{
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        text.text = Shop.hets.ToString();
        if (Shop.hets <= 0)
        {
            Shop.hets = 0;
        }
    }
}
