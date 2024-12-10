using UnityEngine;

public class Bullets : MonoBehaviour
{
    
    void Update()
    {
        transform.Translate(Vector2.left * -30 * Time.deltaTime * Machine.time_freez);
    }
}
