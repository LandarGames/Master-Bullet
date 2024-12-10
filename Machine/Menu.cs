using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static bool menush = false;
    [SerializeField] private GameObject menu;
    [SerializeField] private string lonk;
    [SerializeField] private string lonk_next;
    public static bool Pauses;

    private void Awake()
    {
        menu.SetActive(false);
        Pauses = false;
    }

    public void In_menu()
    {
        menush = true;
        SceneManager.LoadScene("Lobby");
        Pauses = false;
        if (Weapon.num_bullet == 1)
        {
            Progress.Hbul -= 1;
        }
        else if (Weapon.num_bullet == 2)
        {
            Progress.Vbul -= 1;
        }
        Progress.MySave();
    }
    public void Pause()
    {
        menu.SetActive(true);
        Pauses = true;
    }

    public void Continue()
    {
        menu.SetActive(false);
        Pauses = false;
        Progress.MySave();
    }

    public void Replay()
    {
        Pauses = false;
        SceneManager.LoadScene(lonk);
        Menu.menush = false;
        Machine.time = 0;
        Generaishonhome.start = false;
        Music_shot.activaishen_mus = false;
        Machine.worked = false;
        Machine.Col_bullet = 3;
        Machine.timing_end = 0;
        Machine.cel = 0;
        Camera_work.timeng = 0;
        Machine.chance = true;
        if (Weapon.num_bullet == 1)
        {
            Progress.Hbul -= 1;
        }
        else if (Weapon.num_bullet == 2)
        {
            Progress.Vbul -= 1;
        }
        Progress.MySave();
        Spawn.spawn_toch.Clear();
    }

    public void Next()
    {
        Pauses = false;
        SceneManager.LoadScene(lonk_next);
        Menu.menush = false;
        Machine.time = 0;
        Generaishonhome.start = false;
        Music_shot.activaishen_mus = false;
        Machine.worked = false;
        Machine.Col_bullet = 3;
        Machine.timing_end = 0;
        Machine.cel = 0;
        Camera_work.timeng = 0;
        Machine.chance = true;
        if (Weapon.num_bullet == 1)
        {
            Progress.Hbul -= 1;
        }
        else if (Weapon.num_bullet == 2)
        {
            Progress.Vbul -= 1;
        }
        Progress.MySave();
        Spawn.spawn_toch.Clear();

    }
}
