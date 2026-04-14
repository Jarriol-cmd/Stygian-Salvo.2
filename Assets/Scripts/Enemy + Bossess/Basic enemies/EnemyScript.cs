using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyScript : MonoBehaviour
{
    public Transform player;
    public float speed = 3.0f;
    private Vector2 target;
    public float healthPoints = 4;
    public static EnemyScript instance;
    Rigidbody2D rb;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (GameObject.FindWithTag("Player") != null)
        {
            player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        }

        else if (GameObject.FindWithTag("Player") == null)
        {
            player = GameObject.Find("Player").GetComponent<Transform>();
        }

    }

    void Update()
    {
        if (ItemMenuScripte.instance.playerCanMove == true && ItemMenuScripte.instance.inMenu == false)
        {
            target = new Vector2(player.position.x, player.position.y);

            float step = speed * Time.deltaTime;

            // move sprite towards the target location
            transform.position = Vector2.MoveTowards(transform.position, target, step);
        }

        if (ItemMenuScripte.instance.playerCanMove == false)
        {
            rb.linearVelocity = Vector3.zero;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("PlayerProj") && ItemMenuScripte.instance.inMenu == false)
        {
            healthPoints -= (2 * Time.deltaTime) * (PlayerScript.instance.oldProjCount);
            if (healthPoints <= 0)
            {
                collision.gameObject.GetComponent<SphereProjectile>().chooseEnemy = true;
                PlayerScript.instance.currenthealth += 1;
                ItemMenuScripte.instance.numberDefeated += 1;
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && ItemMenuScripte.instance.inMenu == false)
        {
            PlayerScript.instance.currenthealth -= 1;
        }
    }

}
