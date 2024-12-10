using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lignts_hoh : MonoBehaviour
{
    private Light lit;
    new List<Color> variable = new List<Color>() { new Color(243f / 255f, 93f / 255f, 109f / 255f), new Color(93f / 255f, 179f / 255f, 243f / 255f), new Color(158f / 255f, 93f / 255f, 243f / 255f), new Color(93f / 255f, 243f / 255f, 155f / 255f),new Color(243f / 255f, 224f / 255f, 93f / 255f) };
    private int dam;
    private void Awake()
    {
        dam = Random.Range(0, 4);
        lit = GetComponent<Light>();
        for (int i = 0; i <= 4; i++)
        {
            if (i == dam)
            {
                dam = i;
                break;
            }              
        }
    }

    private void Update()
    {
        lit.color = variable[dam];
    }
}
