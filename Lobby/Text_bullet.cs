using UnityEngine.UI;
using UnityEngine;

public class Text_bullet : MonoBehaviour
{
    private Text text;
    [SerializeField] private bool antibron;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        if (antibron == true)
        {
            text.text = Progress.Hbul.ToString();
        }
        else if (antibron == false)
        {
            text.text = Progress.Vbul.ToString();
        }
    }
}
