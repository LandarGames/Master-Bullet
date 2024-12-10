using UnityEngine.UI;
using UnityEngine;

public class Otob : MonoBehaviour
{
    public static bool potr;
    [SerializeField] private GameObject[] buy;
    [SerializeField] private GameObject[] take;

    void Update()
    {
        if (potr == false)
        {
            for (int i = 0; i < take.Length; i++)
            {
                take[i].SetActive(true);
            }
            for (int i = 0; i < buy.Length; i++)
            {
                buy[i].SetActive(false);
            }
        }
        if (potr == true)
        {
            for (int i = 0; i < take.Length; i++)
            {
                take[i].SetActive(false);
            }
            for (int i = 0; i < buy.Length; i++)
            {
                buy[i].SetActive(true);
            }       
        }
    }
}
