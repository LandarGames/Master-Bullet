using System.Reflection;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start_mission : MonoBehaviour
{
    [SerializeField] private int _num;
    [SerializeField] private string _path;
    [SerializeField] private Text _text;
    [SerializeField] private Image _im;

    private bool _com = false;

    private void Update()
    {
        if (_com)
        {
            return;
        }
        foreach (int i in Progress.miision_usp)
        {
            if (i == _num)
            {
                _com = true;
                _text.color = new Color(0, 0, 0);
                _im.color = new Color(0, 0, 0);
            }
        }
    }
    public void Begin_mission()
    {
        SceneManager.LoadScene(_path);
        Music_shot.activaishen_mus = false;
        Menu.menush = false;
        Machine.time = 0;
        Machine.timing_end = 0;
        Machine.worked = false;
        Machine.Col_bullet = 3;
        Machine.timing_end = 0;
        Camera_work.timeng = 0;
        Machine.cel = 0;
        Machine.chance = true;
    }
}
