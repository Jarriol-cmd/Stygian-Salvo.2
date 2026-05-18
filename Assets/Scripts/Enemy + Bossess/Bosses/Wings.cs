using UnityEngine;

public class Wings : MonoBehaviour
{
    public Transform player;
    public float speed = 3.0f;
    private Vector2 target;
    public static EnemyScript instance;
    Rigidbody2D rb;

    public float currHealth;
    public float maxHealth;
    public float enHealth;

    int dealingDamage;

    public double attackTimer = 2;
    public double regAtkTimer;

    public float dTimer;

    public float enemyStrengthCounter;



    void Start()
    {
        dTimer = 1;

        if (gameObject.name == "The Wings(Clone)")
        {
            enHealth = 40;
            dealingDamage = 2;
            regAtkTimer = 2;
        }


        rb = GetComponent<Rigidbody2D>();

        if (GameObject.FindWithTag("Player") != null)
        {
            player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        }

        else if (GameObject.FindWithTag("Player") == null)
        {
            player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        }


        enemyStrengthCounter = 5;

        maxHealth = enHealth + ScalingScript.instance.healthPoints;
        currHealth = maxHealth;
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

        if (currHealth <= 0)
        {
            SphereProjectile.instance.chooseEnemy = true;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("PlayerProj") && ItemMenuScripte.instance.inMenu == false && ItemMenuScripte.instance.playerCanMove == true)
        {
            if (collision.name == "Sphere projectile(Clone)")
            {
                currHealth -= ((Time.deltaTime) * (PlayerScript.instance.oldProjCount));
            }

            if (collision.name == "Cinders(Clone)")
            {
                currHealth -= (Time.deltaTime) * (PlayerScript.instance.oldFlamnum);
            }

            if (currHealth <= 0)
            {
                
                    dTimer -= Time.deltaTime;

                    dealingDamage = 0;
                    if (dTimer <= 0)
                    {
                        AudioScript.instance.PlaySFX("Wing Death");

                        BosskillerScript.instance.isDead += 1;

                        ItemMenuScripte.instance.playerCanMove = false;
                        ItemMenuScripte.instance.inMenu = true;
                        Destroy(gameObject);
                    }
                


            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && ItemMenuScripte.instance.inMenu == false && ItemMenuScripte.instance.playerCanMove == true)
        {
            attackTimer -= Time.deltaTime;

            if (attackTimer <= 0)
            {

                AudioScript.instance.PlaySFX("Bite");

                PlayerScript.instance.currenthealth -= dealingDamage;
                

                attackTimer = regAtkTimer;
            }

        }
    }

}