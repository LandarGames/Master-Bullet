using System.Collections.Generic;
using UnityEngine;
using YG;

public class Lvl : MonoBehaviour
{
    public static float bar_exp;
    private int ran;

    private void Update()
    {
        bar_exp = Progress.Lvl * 50;
        if (Progress.Exp >= bar_exp)
        {
            Progress.MySave();
            Progress.Lvl += 1;
            ran = Random.Range(0, 4);
            switch(ran)
            {
                case 0:
                    Progress.Dop_k += 0.01f;
                    break;
                case 1:
                    Progress.Dop_b += 0.01f;
                    break;
                case 2:
                    Progress.Dop_n += 0.01f;
                    break;
                case 3:
                    Progress.Hbul += 3;
                    break;
                case 4:
                    Progress.Vbul += 3;
                    break;
            }
        }
    }
}
