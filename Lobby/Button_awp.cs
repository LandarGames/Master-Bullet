using Unity.VisualScripting;
using UnityEngine;

public class Button_awp : MonoBehaviour
{
    public GameObject[] icon;
    [SerializeField] private GameObject osn;
    [SerializeField] private GameObject weapons;
    [SerializeField] private int price;
    [SerializeField] private int index;

    private void Awake()
    {
        osn.SetActive(false);
    }

    private void Update()
    {
        if (index == Lobby_machine.index_what)
        {
            osn.SetActive(true);
        }
    }
    public void Grafic()
    {
        Character.index_int = index;
        foreach (GameObject objects in icon)
        {
            objects.SetActive(false);
        }
        foreach (int a in Progress.gun)
        {
            if (index == a)
            {
                Otob.potr = false;
                break;
            }
            else if (index != a)
            {
                Otob.potr = true;
            }
        }
        Lobby_machine.weapons_what = weapons;
        Lobby_machine.index_what = index;
        osn.SetActive(true);
        Price.cena = price;
    }

}
