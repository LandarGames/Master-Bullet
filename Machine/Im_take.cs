using UnityEngine;

public class Im_take : MonoBehaviour
{
    public static int sum;
    public static int mus_kill;
    private bool took = false;

    private void Awake()
    {
        took = false;
    }
    void Update()
    {
        if (Machine.Col_bullet <= 0 && Machine.cel >= 1 && took == true)
        {
            if (Random.Range(0f,1f) <= Progress.Dop_n)
            {
                sum += mus_kill;
                Progress.Money += sum * 2;
                sum = 0;
                mus_kill = 0;
            }
            else if (Random.Range(0f, 1f) > Progress.Dop_n)
            {
                sum += mus_kill;
                Progress.Money += sum;
                sum = 0;
                mus_kill = 0;
            }
            Progress.Exp += 25;
            took = true;
        }
    }
}
