using UnityEngine;

public class Home_razm : MonoBehaviour
{
    private float local;
    private void Awake()
    {
        local = Random.Range(1f, 1.2f);
        transform.localScale = new Vector3(local, local, transform.localScale.z);
        
    }
}
