using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public static int index_int;
    [SerializeField] private int indx;
    [SerializeField] private float cherecter;
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        if (index_int == indx)
        {
            text.text = cherecter.ToString();
        }    
    }
}
