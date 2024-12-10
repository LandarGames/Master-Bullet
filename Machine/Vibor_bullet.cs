using UnityEngine;

public class Vibor_bullet : MonoBehaviour
{
    [SerializeField] private int numbs;
    public GameObject[] icon;
    [SerializeField] private GameObject osn;
    [SerializeField] private AudioClip[] AS;
    private AudioSource PS;

    private void Awake()
    {
        PS = GetComponent<AudioSource>();
        PS.Stop();
        if (numbs != 0)
        {
            osn.gameObject.SetActive(false);
        }
    }
    public void Izmen()
    {
        if (numbs == 0)
        {
            Weapon.num_bullet = numbs;
            foreach (GameObject objects in icon)
            {
                objects.SetActive(false);
            }
            osn.gameObject.SetActive(true);
            PS.clip = AS[0];
            PS.Play();
        }
        if (numbs == 1 && Progress.Hbul > 0)
        {
            Weapon.num_bullet = numbs;
            foreach (GameObject objects in icon)
            {
                objects.SetActive(false);
            }
            osn.gameObject.SetActive(true);
            PS.clip = AS[0];
            PS.Play();
        }
        else if (numbs == 1 && Progress.Hbul <= 0)
        {
            PS.clip = AS[1];
            PS.Play();
        }
        if (numbs == 2 && Progress.Vbul > 0)
        {
            Weapon.num_bullet = numbs;
            foreach (GameObject objects in icon)
            {
                objects.SetActive(false);
            }
            osn.gameObject.SetActive(true);
            PS.clip = AS[0];
            PS.Play();
        }
        else if (numbs == 2 && Progress.Vbul <= 0)
        {
            PS.clip = AS[1];
            PS.Play();
        }


    }
}
