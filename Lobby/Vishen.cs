using UnityEngine;

public class Vishen : MonoBehaviour
{
    [SerializeField] private GameObject viz;
    [SerializeField] private string txt;
    [SerializeField] private bool iscl;
    void Update()
    {
        if (iscl == false)
        {
            if (txt == Vibor_lobby.point)
            {
                viz.SetActive(true);
            }
            else if (txt != Vibor_lobby.point)
            {
                viz.SetActive(false);
            }
        }
        if (iscl == true)
        {
            if (txt == Vibor_lobby.point)
            {
                viz.SetActive(false);
            }
            else if (txt != Vibor_lobby.point)
            {
                viz.SetActive(true);
            }
        }
    }
}
