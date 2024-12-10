using UnityEngine.UI;
using UnityEngine;

public class Text_on : MonoBehaviour
{
    private Text tx;
    [SerializeField] private bool HP;

    private void Awake()
    {
        tx = GetComponent<Text>();
    }
    void Update()
    {
        if (HP == true)
        {
            tx.text = Cel.HP.ToString();
        }
        else if (HP == false)
        {
            if (Cel.HP_Bronishelet == 0)
            {
                gameObject.SetActive(false);
            }
            tx.text = Cel.HP_Bronishelet.ToString();
        }
    }
}
