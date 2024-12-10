using UnityEngine;

public class Help_eff : MonoBehaviour
{
    private float time;
    private void Awake()
    {
        time = 0;
        Camera_work.Bullet = gameObject;
    }

    public void Update()
    {
        Camera_work.Bullet = gameObject;
        time += Time.deltaTime;
        if (time > 1.5f)
        {
            Destroy(gameObject);
        }
    }
}
