using UnityEngine.UI;
using UnityEngine;

public class Lesson : MonoBehaviour
{
    [SerializeField] private int num_dialog;
    [SerializeField] private string strs;
    private Text text;
    private int dialog;
    [SerializeField] private int end_diialog;
    [SerializeField] private GameObject ob;

    private void Awake()
    {
        text = GetComponent<Text>();
        dialog = 0;
    }
    private void Update()
    {
        Menu.Pauses = true;
        if (Input.GetMouseButtonDown(0))
        {
            dialog++;
        }    
        if (num_dialog == dialog)
        {
            text.text = strs.ToString();
        }
        if (end_diialog == dialog)
        {
            Menu.Pauses = false;
            ob.gameObject.SetActive(false);
        }    
    }
}
