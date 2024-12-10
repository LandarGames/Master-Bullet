using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Spaw : MonoBehaviour
{
    [SerializeField] private GameObject[] cel;
    private bool ha = false;
    private void Update()
    {
        if (Generaishonhome.start == true && ha == false)
        {
            Instantiate(cel[Random.Range(0, cel.Length)], Spawn.spawn_toch[Random.Range(0, Spawn.spawn_toch.Count)].position, Quaternion.identity);
            ha = true;
        }
        else if (Generaishonhome.start == true && Machine.cel <= 0 && Machine.time <= 1)
        {
            ha = false;
        }
    }
}
