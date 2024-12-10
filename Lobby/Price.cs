using UnityEngine.UI;
using UnityEngine;

public class Price : MonoBehaviour
{
    public static int cena;
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }
    private void Update()
    {
        text.text = cena.ToString();
    }
}
