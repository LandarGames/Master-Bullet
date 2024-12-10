using UnityEngine;

public class Gen_home : MonoBehaviour
{
    [SerializeField] private Transform tochka;
    [SerializeField] private GameObject home;
    [SerializeField] private float trig;
    private float trigger;

    void Update()
    {
        if (transform.position.x <= 80)
        {
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
            trigger += 1;
            if (trigger >= trig)
            {
                Instantiate(home, tochka.position, transform.rotation);
                trigger = 0;
            }  
        }
    }
}
