using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lobby_machine : MonoBehaviour
{
    public static GameObject weapons_what;
    public static int index_what;
    public static int index_skins;
    [SerializeField] private AudioClip[] AS;
    private AudioSource PS;

    private void Awake()
    {
        PS = GetComponent<AudioSource>();
        PS.Stop();
}

    public void Lobby()
    {
        Vibor_lobby.point = "Lobby";
        PS.clip = AS[1];
        PS.Play();
    }

    public void Shop()
    {
        Vibor_lobby.point = "Shop";
        PS.clip = AS[1];
        PS.Play();
    }

    public void Weapons()
    {
        Vibor_lobby.point = "Weapon";
        PS.clip = AS[0];
        PS.Play();
    }

    public void Game()
    {
        Vibor_lobby.point = "Game";
        PS.clip = AS[0];
        PS.Play();
    }

    public void Mis()
    {
        Vibor_lobby.point = "Mission";
        PS.clip = AS[0];
        PS.Play();
    }

    public void Ustran()
    {
        Machine.cel = 0;
        Menu.menush = false;
        Machine.time = 0;
        Generaishonhome.start = false;
        Music_shot.activaishen_mus = false;
        Im_take.sum = 0;
        Im_take.mus_kill = 0;
        Machine.worked = false;
        Machine.Col_bullet = 3;
        Machine.timing_end = 0;
        Machine.chance = true;
        Spawn.spawn_toch.Clear();
        if (Weapon.num_bullet == 1)
        {
            Progress.Hbul -= 1;
        }
        else if (Weapon.num_bullet == 2)
        {
            Progress.Vbul -= 1;
        }
        SceneManager.LoadScene("Ustran_home");
    }

    public void buy()
    {
        if (Price.cena <= Progress.Money)
        {
            Otob.potr = false;
            Progress.gun.Add(index_what);
            Progress.Money -= Price.cena;
            PS.clip = AS[2];
            PS.Play();
            Progress.MySave();
        }
    }

    public void buy_skin()
    {
        if (Price.cena <= Progress.Money)
        {
            Otob.potr = false;
            Progress.skin.Add(index_skins);
            Progress.Money -= Price.cena;
            PS.clip = AS[2];
            PS.Play();
            Progress.MySave();
        }
    }
    public void Give()
    {
        Spavn_gun.gun = weapons_what;
        Progress.Guns = weapons_what;
        PS.clip = AS[3];
        PS.Play();
        Progress.MySave();
    }

    public void Give_skin()
    {
        Skin.Osn_index = index_skins;
        Progress.Skins = index_skins;
        PS.clip = AS[4];
        PS.Play();
        Progress.MySave();
    }

    public void Skinet()
    {
        Vibor_lobby.point = "Skin";
        PS.clip = AS[0];
        PS.Play();
    }

    public void Profil()
    {
        Vibor_lobby.point = "Profil";
        PS.clip = AS[0];
        PS.Play();
    }

}
