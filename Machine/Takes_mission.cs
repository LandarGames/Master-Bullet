using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class Takes_mission : MonoBehaviour
{
    private bool day_me;
    [SerializeField] private int mission;

    private void Awake()
    {
    }
    void Update()
    {
        if (Machine.cel <= 0.3f && Machine.time >= 1 && day_me == false)
        {
            foreach(int i in Progress.miision_usp)
            {
                if (i == mission)
                {
                    day_me = true;
                }
            }
            if (day_me == false)
            {
                if (Random.Range(0f, 1f) <= Progress.Dop_n)
                {
                    Progress.miision_usp.Add(mission);
                    Progress.Money += 50 * 2;
                    Progress.Exp += 50 * 2;
                    day_me = true;
                }
                else if (Random.Range(0f, 1f) > Progress.Dop_n)
                {
                    Progress.miision_usp.Add(mission);
                    Progress.Money += 50;
                    Progress.Exp += 50;
                    day_me = true;
                }
            }
        }
    }
}
