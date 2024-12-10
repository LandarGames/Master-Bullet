using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform tochka;
    public static new List<Transform> spawn_toch = new List<Transform>();

    private void Awake()
    {
        spawn_toch.Add(tochka);
    }


}
