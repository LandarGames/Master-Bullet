using UnityEngine;

public class Generaishonhome : MonoBehaviour
{
    [SerializeField] private Transform tochka;
    [SerializeField] private GameObject home;
    [SerializeField] private GameObject[] player_home;
    [SerializeField] private float trig;
    private float trigger;
    private float spavn = 0;
    public static bool start = false;
    private float x;
    private float y = 5;

    private void Awake()
    {
        x = 0;
    }
    void Update()
    {
        if (transform.position.x <= 80)
        {
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
            trigger += 1;
            if (trigger >= trig && x < y)
            {
                Instantiate(home, tochka.position, transform.rotation);
                trigger = 0;
                y -= 1;
                x = Random.Range(1, 10);
            }
            if (spavn == 0 && x >= y && trigger >= trig)
            {
                spavn += 1;
                Instantiate(player_home[Random.Range(0,player_home.Length)], tochka.position, transform.rotation);
                trigger = 0;
                y = 100;
            }
        }
        if (transform.position.x >= 79 && spavn == 1)
        {
            start = true;
        }
    }
}
