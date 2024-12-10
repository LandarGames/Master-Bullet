using UnityEngine;

public class Icon : MonoBehaviour
{
    void Update()
    {
        if (Cel.HP_Bronishelet == 0 && Machine.time <= 1)
        {
            gameObject.SetActive(false);
        }
    }
}
