using UnityEngine.UI;
using UnityEngine;

public class Lvl_num : MonoBehaviour
{
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = Progress.Lvl.ToString();
    }
}
