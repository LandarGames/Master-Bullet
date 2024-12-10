using UnityEngine.UI;
using UnityEngine;

public class Num_bullet : MonoBehaviour
{
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }
    void Update()
    {
        _text.text = Machine.Col_bullet.ToString();
    }
}
