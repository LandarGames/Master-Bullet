using UnityEngine.UI;
using UnityEngine;

public class HP_otob : MonoBehaviour
{
    private Image hp;
    [SerializeField] private bool HP;
    private float max;

    private void Awake()
    {
        hp = GetComponent<Image>();
    }
    void Update()
    {
        if (Machine.time <= 1)
        {
            if (HP == true)
            {
                max = Cel.HP;
            }
            else if (HP == false)
            {
                max = Cel.HP_Bronishelet;
                if (Cel.HP_Bronishelet == 0)
                {
                    gameObject.SetActive(false);
                }
            }
        }
        if (HP == true)
        {
            hp.fillAmount = Cel.HP / max;
        }
        else if (HP == false)
        {
            hp.fillAmount = Cel.HP_Bronishelet / max;
        }
    }
}
