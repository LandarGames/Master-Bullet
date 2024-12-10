using UnityEngine.UI;
using UnityEngine;

public class UI_chence : MonoBehaviour
{
    [SerializeField] private GameObject _chence;
    [SerializeField] private GameObject _shop;

    public void Chenc()
    {
        Vibor_lobby.point = "Chance";
        _chence.SetActive(true);
        _shop.SetActive(false);
    }

    public void Shops()
    {
        Vibor_lobby.point = "Shop";
        _chence.SetActive(false);
        _shop.SetActive(true);
    }
}
