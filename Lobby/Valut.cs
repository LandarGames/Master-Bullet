using UnityEngine;
using UnityEngine.UI;
using YG;

public class Valut : MonoBehaviour
{
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    private void LateUpdate()
    {       
        text.text = Progress.Money.ToString();
        if (Progress.Money < 0)
        {
            Progress.Money = 0;
        }
    }

}
