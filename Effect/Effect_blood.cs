using UnityEngine;

public class Effect_blood : MonoBehaviour
{
    private ParticleSystem PS;
    private bool blood_effect = false;

    private void Awake()
    {
        PS = GetComponent<ParticleSystem>();
        PS.Stop();
    }
    void Update()
    {
        if (blood_effect == true)
        {
            PS.Play();
            blood_effect = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            blood_effect = true;
        }
    }
}
