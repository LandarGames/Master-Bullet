using UnityEngine.UI;
using UnityEngine;

public class Lvl_otob : MonoBehaviour
{
    private Image im;

    private void Awake()
    {
        im = GetComponent<Image>();
    }

    private void Update()
    {
        im.fillAmount = Progress.Exp / Lvl.bar_exp;
    }
}
