using UnityEngine;

public class Shots_fire : MonoBehaviour
{
    private ParticleSystem PS;
    public static bool activaishen_effect = false;

    private void Awake()
    {
        PS = GetComponent<ParticleSystem>();
        PS.Stop();
    }
    void LateUpdate()
    {
        if (activaishen_effect == true && Menu.menush == false && Menu.Pauses == false)
        {
            PS.Play();
            activaishen_effect = false;
        }
    }
}
