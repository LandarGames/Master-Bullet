using UnityEngine.UI;
using UnityEngine;
using System.Runtime.CompilerServices;

public class Otob_cher : MonoBehaviour
{
    private Text text;
    [SerializeField] private bool boolet;
    [SerializeField] private bool krit;
    [SerializeField] private bool money;
    private string har_boolet;
    private string har_krit;
    private string har_money;

    private void Awake()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        har_boolet = (Progress.Dop_b * 100) + "%";
        har_krit = (Progress.Dop_k * 100) + "%";
        har_money = (Progress.Dop_n * 100) + "%";
        if (money == true)
        {
            text.text = har_money.ToString();
        }
        if (krit == true)
        {
            text.text = har_krit.ToString();
        }
        if (boolet == true)
        {
            text.text = har_boolet.ToString();
        }
    }
}
