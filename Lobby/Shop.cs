using System.Runtime.InteropServices;
using UnityEngine;
using YG;

public class Shop : MonoBehaviour
{
    public static int hets = 10;
    private int ran;
    private float ran_tak;
    private int tak;
    private AudioSource AS;

    [SerializeField] private GameObject gun;
    [SerializeField] private GameObject skin;
    [SerializeField] private GameObject money1;
    [SerializeField] private GameObject money2;
    [SerializeField] private GameObject money3;
    [SerializeField] private GameObject money4;
    [SerializeField] private GameObject exp1;
    [SerializeField] private GameObject exp2;
    [SerializeField] private GameObject exp3;
    [SerializeField] private GameObject exp4;
    [SerializeField] private GameObject hbul1;
    [SerializeField] private GameObject hbul2;
    [SerializeField] private GameObject hbul3;
    [SerializeField] private GameObject vbul1;
    [SerializeField] private GameObject vbul2;
    [SerializeField] private GameObject vbul3;


    private void Awake()
    {
        gun.SetActive(false);
        skin.SetActive(false);
        money1.SetActive(false);
        money2.SetActive(false);
        money3.SetActive(false);
        money4.SetActive(false);
        exp1.SetActive(false);
        exp2.SetActive(false);
        exp3.SetActive(false);
        exp4.SetActive(false);
        hbul1.SetActive(false);
        hbul2.SetActive(false);
        hbul3.SetActive(false);
        vbul1.SetActive(false);
        vbul2.SetActive(false);
        vbul3.SetActive(false);


        AS = GetComponent<AudioSource>();
        ran = Random.Range(0, 3);
    }

    public void Close_iz()
    {
        gun.SetActive(false);
        skin.SetActive(false);
        money1.SetActive(false);
        money2.SetActive(false);
        money3.SetActive(false);
        money4.SetActive(false);
        exp1.SetActive(false);
        exp2.SetActive(false);
        exp3.SetActive(false);
        exp4.SetActive(false);
        hbul1.SetActive(false);
        hbul2.SetActive(false);
        hbul3.SetActive(false);
        vbul1.SetActive(false);
        vbul2.SetActive(false);
        vbul3.SetActive(false);
    }

    private void Rewarded(int id)
    {
        switch (id)
        {
            case 1:
                Progress.Money += 250;
                break;
            case 2:
                switch (ran)
                    {
                        case 0:
                            Progress.Exp += 350;
                            break;
                        case 1:
                            Progress.Money += 350;
                            break;
                        case 2:
                            Progress.Hbul += 18;
                            break;
                        case 3:
                            Progress.Vbul += 18;
                            break;
                    }
                ran = Random.Range(0, 3);
                break;
            case 3:
                if (ran_tak <= 0.1f)
                {
                    tak = Random.Range(0, 1);
                    if (tak == 0)
                    {
                        if (Progress.gun.Count >= 4)
                        {
                            Progress.Exp += 1000;
                            exp1.SetActive(true);
                        }
                        if (Progress.gun.Count < 4)
                        {
                            Progress.gun.Add(Progress.gun.Count);
                            gun.SetActive(true);
                        }
                    }
                    else if (tak == 1)
                    {
                        if (Progress.skin.Count >= 4)
                        {
                            Progress.Money += 1000;
                            money1.SetActive(true);
                        }
                        if (Progress.skin.Count < 4)
                        {
                            Progress.skin.Add(Progress.skin.Count);
                            skin.SetActive(true);
                        }
                    }
                }
                else if (ran_tak > 0.1f && ran_tak <= 0.3f)
                {
                    tak = Random.Range(0, 3);
                    if (tak == 0)
                    {
                        Progress.Exp += 750;
                        exp2.SetActive(true);
                    }
                    else if (tak == 1)
                    {
                        Progress.Money += 750;
                        money2.SetActive(true);
                    }
                    else if (tak == 2)
                    {
                        Progress.Hbul += 25;
                        hbul1.SetActive(true);
                    }
                    else if (tak == 3)
                    {
                        Progress.Vbul += 25;
                        vbul1.SetActive(true);
                    }
                }
                else if (ran_tak > 0.3f && ran_tak <= 0.6f)
                {
                    tak = Random.Range(0, 3);
                    if (tak == 0)
                    {
                        Progress.Exp += 500;
                        exp3.SetActive(true);
                    }
                    else if (tak == 1)
                    {
                        Progress.Money += 500;
                        money3.SetActive(true);
                    }
                    else if (tak == 2)
                    {
                        Progress.Hbul += 20;
                        hbul2.SetActive(true);
                    }
                    else if (tak == 3)
                    {
                        Progress.Vbul += 20;
                        vbul2.SetActive(true);
                    }
                }
                else if (ran_tak > 0.6f)
                {
                    tak = Random.Range(0, 3);
                    if (tak == 0)
                    {
                        Progress.Exp += 250;
                        exp4.SetActive(true);
                    }
                    else if (tak == 1)
                    {
                        Progress.Money += 250;
                        money4.SetActive(true);
                    }
                    else if (tak == 2)
                    {
                        Progress.Hbul += 15;
                        hbul3.SetActive(true);
                    }
                    else if (tak == 3)
                    {
                        Progress.Vbul += 15;
                        vbul3.SetActive(true);
                    }
                }
                break;
        }
        Progress.MySave();
        Music_all.audioSrc1.Play();
        AS.Play();
    }

    private void ExamplerOpenReward(int id)
    {
        Music_all.audioSrc1.Stop();
        YandexGame.RewVideoShow(id);
    }

    private void OnEnable()
    {
        YandexGame.RewardVideoEvent += Rewarded;
    }

    private void OnDisable()
    {
        YandexGame.RewardVideoEvent -= Rewarded;

    }
    public void Pack_shop()
    {
        if(Progress.Money >= 100)
        {
            Progress.Exp += 250;
            Progress.Hbul += 9;
            Progress.Vbul += 9;
            Progress.Money -= 100;
            Progress.MySave();
            AS.Play();
        }
    }

    public void Valut_taken()
    {
        ExamplerOpenReward(1);
    }

    public void Random_zadan()
    {
        ExamplerOpenReward(2);
        ran = Random.Range(0, 3);
    }

    public void Random_item()
    {
        ran_tak = Random.Range(0f, 1f);
        ExamplerOpenReward(3);

    }
}
