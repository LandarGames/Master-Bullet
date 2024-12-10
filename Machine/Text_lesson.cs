using UnityEngine.UI;
using UnityEngine;

public class Text_lesson : MonoBehaviour
{
    [SerializeField] private GameObject strel;
    [SerializeField] private GameObject strelMob;
    [SerializeField] private GameObject upravl;
    [SerializeField] private GameObject upravlMob;

    private void Update()
    {
        if (Machine.worked == false && Menu.Pauses == false && Machine.cel >= 1)
        {
            if (MobileInputManager.mob == true)
            {
                strelMob.SetActive(true);
                upravl.SetActive(false);
                upravlMob.SetActive(false);
            }
            else
            {
                strel.SetActive(true);
                upravl.SetActive(false);
                upravlMob.SetActive(false); 
            }
        }
        else if (Machine.worked == true)
        {
            strel.SetActive(false);
            strelMob.SetActive(false);
            if (Input.GetKey(KeyCode.W) == false || Input.GetKey(KeyCode.S) == false || Input.GetMouseButtonDown(0) == false && Machine.cel >= 1)
            {
                if (MobileInputManager.mob)
                {
                    upravlMob.SetActive(true);
                }
                else
                {
                    upravl.SetActive(true);
                }
            }
        }
        if (Machine.cel <= 0)
        {
            strel.SetActive(false);
            strelMob.SetActive(false);
            upravl.SetActive(false);
            upravlMob.SetActive(false);
        }
    }
}
