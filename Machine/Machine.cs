using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Machine : MonoBehaviour
{
    public static float time;
    public static bool worked = false;
    public static float time_freez = 1;
    public static float Col_bullet = 3;
    public static bool lobby = false;
    public static int cel;
    public static bool ustran;
    [SerializeField] private bool us;
    public static float timing_end = 0;
    [SerializeField] private GameObject Close;
    [SerializeField] private GameObject Pausa;
    [SerializeField] private GameObject Win;
    [SerializeField] private GameObject Text_bullet;
    public static bool chance = true;
    private float ran;
    private bool take;

    private void Awake()
    {
        take = false;
        Text_bullet.SetActive(false);
        if (us == true)
        {
            ustran = true;
        }
        else if (us == false)
        {
            ustran = false;
        }
        chance = true;

    }
    void Update()
    {
        if (Progress.Hbul <= 0 && Weapon.num_bullet == 1)
        {
            Weapon.num_bullet = 0;
        }
        if (cel <= 0 && take == false && time >= 1)
        {
            Progress.Exp += 10;
            take = true;
        }
        else if (Progress.Vbul <= 0 && Weapon.num_bullet == 2)
        {
            Weapon.num_bullet = 0;
        }
        if (chance == true)
        {
            ran = Random.Range(0f, 1f);
            if (ran <= Progress.Dop_b)
            {
                Text_bullet.SetActive(true);
                Col_bullet = 4;              
                chance = false;
            }
            else if (ran > Progress.Dop_b)
            {
                chance = false;
            }    
        }
        if (Menu.Pauses == false)
        {
            if (Generaishonhome.start == true && ustran == true)
            {
                time += Time.deltaTime;
                if (worked == true && time_freez <= 0.5)
                {
                    time_freez += Time.deltaTime * 0.5f;
                }
                if (worked == false && time_freez <= 1)
                {
                    time_freez += Time.deltaTime * 2;
                }
            }
            if (ustran == false)
            {
                time += Time.deltaTime;
                if (worked == false && time_freez <= 1)
                {
                    time_freez += Time.deltaTime * 2;
                }
                if (worked == true && time_freez <= 0.5)
                {
                    time_freez += Time.deltaTime * 0.5f;
                }
            }
            if (cel <= 0 && time >= timing_end && ustran == true && timing_end != 0)
            {
                time = 0;
                worked = false;
                Col_bullet += 1;
                timing_end = 0;
                Ustran_rep();
            }
        }   
        if (Col_bullet <= 0 && cel <= 0 && chance == false)
        {
            Close.SetActive(false);
        }
        if (Col_bullet <= 0 && cel >= 1 && worked == false && chance == false || Player.life == false)
        {
            time_freez -= 0.25f * Time.deltaTime;
            Close.SetActive(true);
        }
        if (cel <= 0 && us == false && time >= 1)
        {
            Win.SetActive(true);
        }
    }

    public void Ustran_rep()
    {
        SceneManager.LoadScene("Ustran_home");
        Music_shot.activaishen_mus = false;
        Menu.menush = false;
        time = 0;
        timing_end = 0;
        worked = false;
        cel = 0;
        Im_take.mus_kill += 1;
        Generaishonhome.start = false;
        Progress.MySave();
        Spawn.spawn_toch.Clear();
    }
}
