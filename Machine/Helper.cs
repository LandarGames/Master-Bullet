using UnityEngine;

public class Helper : MonoBehaviour
{
    private bool worked = true;
    [SerializeField] private Transform pric;
    [SerializeField] private GameObject bull;
    [SerializeField] private GameObject gun;
    private Rigidbody2D rb;
    private int col;
    private bool took = false;

    private void Awake()
    {
        took = false;
        col = 1;
        Machine.cel += 1;
        worked = true;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Machine.cel <= 1 && Cel.HP >= 0 && Machine.time <= 1)
        {
            Machine.cel += 1;
        }
        if (Machine.cel <= 1 && worked == true && Machine.time >= 1 && col >= 1)
        {
            Instantiate(bull, pric.position, gun.transform.rotation);
            col -= 1;
        }
        if (Menu.Pauses == false && worked == false && took == false)
        {
            Machine.cel -= 1;
            Progress.Exp += 10;
            Progress.Money += 10;
            took = true;
        }
        if (Menu.Pauses == true && worked == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        if (worked == false)
        {
            transform.Rotate(0, 0, 0.70f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Bullet_antibron")
        {
            worked = false;
            rb.constraints = RigidbodyConstraints2D.None;
            rb.velocity = new Vector2(5, transform.position.y);
            Shop.hets -= 1;
        }    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boom")
        {
            worked = false;
            rb.constraints = RigidbodyConstraints2D.None;
            rb.velocity = new Vector2(5, transform.position.y);
            Shop.hets -= 1;
        }     
    }
}

