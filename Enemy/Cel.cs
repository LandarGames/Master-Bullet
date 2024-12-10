using UnityEngine;
using UnityEngine.UIElements;

public class Cel : MonoBehaviour
{
    [SerializeField] private float Zdorov;
    [SerializeField] private float Broneshelet;
    public static float HP;
    public static float HP_Bronishelet;
    private Rigidbody2D rb;
    [SerializeField] private bool asia;
    private float ran;
    private bool regen;

    void Awake()
    {
        HP = Zdorov;
        HP_Bronishelet = Broneshelet;
        rb = GetComponent<Rigidbody2D>();
        regen = true;
    }

    private void Start()
    {
        if (Machine.cel <= 0)
        {
            Machine.cel += 1;
        }
        Machine.time = 0;
    }
    void Update()
    {
        Camera_work.Cels = gameObject;
        if (HP <= 0 && asia == false)
        {
            HP = 0;
        }
        else if (HP <= 0 && asia == true )
        {
            ran = Random.Range(0f, 1f);
            if (regen == false)
            {
                HP = 0;
                asia = false;
            }
            if (ran > 0.35f && regen == true)
            {
                HP = 0;
                asia = false;
            }
            else if (ran <= 0.35f && regen == true)
            {
                HP += 30;
                regen = false;
            }
           
            
        }
        if (HP_Bronishelet <= 0)
        {
            HP_Bronishelet = 0;
        }
        if (HP <= Zdorov && asia == true && Machine.time >= 1)
        {
            HP += Time.deltaTime * 5 * Machine.time_freez;
        }
        if (Menu.Pauses == false)
        {
            if (Machine.timing_end != 0)
            {
                transform.Rotate(0, 0, 0.70f);
            }
            if (HP >= 1 && Machine.cel <= 0 && Machine.time <= 1)
            {
                Machine.cel += 1;
                Machine.time = 0;
            }
            if (HP <= 0 && Machine.timing_end == 0 && Machine.time >= 1)
            {
                rb.constraints = RigidbodyConstraints2D.None;
                rb.velocity = new Vector2(5, transform.position.y);
                Machine.timing_end = Machine.time + 1.5f;
                Machine.cel -= 1;
                Progress.Money += 1;
                Shop.hets -= 1;
            }
        }
        if (Menu.Pauses == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }



}
