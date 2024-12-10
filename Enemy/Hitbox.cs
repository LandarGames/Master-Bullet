using UnityEngine;

public class Hitbox : MonoBehaviour
{
    [SerializeField] private bool Heats;
    [SerializeField] private bool Body;
    private float ran;
    [SerializeField] private bool asia;
    private float krut = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (Random.Range(0f,1f) <= Progress.Dop_k && Machine.cel > 0)
        {
            krut = 1.5f;
            Text_krit.repeat = true;
        }
        else if (Random.Range(0f, 1f) > Progress.Dop_k)
        {
            krut = 1;
        }
        if (asia == false)
        {
            if (Cel.HP_Bronishelet >= 1)
            {
                ran = Random.Range(0.5f, 0.75f);
            }
            if (Cel.HP_Bronishelet <= 0)
            {
                ran = 0;
            }
            if (collision.gameObject.tag == "Bullet" && Body == true)
            {
                Cel.HP -= Bullet.Damage * (1-ran) * krut;
                Cel.HP_Bronishelet -= Bullet.Damage * ran * krut;
            }
            else if (collision.gameObject.tag == "Bullet" && Heats == true)
            {
                Cel.HP -= Cel.HP;
                Progress.Money += 1;
                Effect_hatsot.star_ef = true;
                Mus_het.heat = true;
                if (Machine.ustran == true)
                {
                    Im_take.sum += 1;
                }
            }
            if (collision.gameObject.tag == "Bullet_antibron" && Body == true)
            {
                Cel.HP -= Bullet.Damage * krut;
                Cel.HP_Bronishelet -= Bullet.Damage * krut;
            }
            else if (collision.gameObject.tag == "Bullet_antibron" && Heats == true)
            {
                Cel.HP -= Cel.HP;
                Progress.Money += 1;
                Effect_hatsot.star_ef = true;
                Mus_het.heat = true;
                if (Machine.ustran == true)
                {
                    Im_take.sum += 1;
                }
            }
        }
        if (asia == true && Machine.cel >= 1) 
        {
            ran = Random.Range(0f, 1f);
            if (ran < 0.002f * Bullet.Damage)
            {
                Miss.repeat = true;
            }
            if (collision.gameObject.tag == "Bullet" && Body == true && ran >= 0.002f * Bullet.Damage)
            {
                Cel.HP -= Bullet.Damage * 0.5f * krut;
            }
            else if (collision.gameObject.tag == "Bullet" && Heats == true && ran >= 0.002f * Bullet.Damage)
            {
                Cel.HP -= Bullet.Damage * 0.9f * krut;
                Progress.Money += 1;
                Effect_hatsot.star_ef = true;
                Mus_het.heat = true;
                if (Machine.ustran == true)
                {
                    Im_take.sum += 1;
                }
            }
            if (collision.gameObject.tag == "Bullet_antibron" && Body == true && ran >= 0.002f * Bullet.Damage)
            {
                Cel.HP -= Bullet.Damage * 0.5f * krut;
            }
            else if (collision.gameObject.tag == "Bullet_antibron" && Heats == true && ran >= 0.002f * Bullet.Damage)
            {
                Cel.HP -= Bullet.Damage * 0.9f * krut;
                Progress.Money += 1;
                Effect_hatsot.star_ef = true;
                Mus_het.heat = true;
                if (Machine.ustran == true)
                {
                    Im_take.sum += 1;
                }
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boom")
        {
            Cel.HP -= Cel.HP;
        }
    }
}
