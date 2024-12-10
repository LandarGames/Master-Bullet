using UnityEngine;

public class Mus_het : MonoBehaviour
{
    private AudioSource AS;
    public static bool heat = false;
    [SerializeField] private AudioClip[] ad;

    private void Awake()
    {
        AS = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (heat == true)
        {
            AS.clip = ad[Random.Range(0, ad.Length)];
            AS.Play();
            heat = false;
        }
    }
}
