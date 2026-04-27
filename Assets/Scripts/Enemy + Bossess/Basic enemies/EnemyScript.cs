using System;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyScript : MonoBehaviour
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

    public float enemyStrengthCounter;

    

    void Start()
    {

        if(gameObject.name == "Ghoul(Clone)")
        {
            enHealth = 3 + ScalingScript.instance.healthPoints;
            dealingDamage = 2 + ScalingScript.instance.damageDealt;
            regAtkTimer = 2;
        }

        if(gameObject.name == "Scorpon(Clone)")
        {
            enHealth = 1 + ScalingScript.instance.healthPoints;
            dealingDamage = ((1 + ScalingScript.instance.damageDealt) / 3);
            regAtkTimer = 0.5;
        }

        if (gameObject.name == "Hoarde(Clone)")
        {
            enHealth = 7 + ScalingScript.instance.healthPoints;
            dealingDamage = 7 + ScalingScript.instance.damageDealt;
            regAtkTimer = 5;
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

        //currHealth = ScalingScript.instance.healthPoints;
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
        if (collision.gameObject.tag == ("PlayerProj") && ItemMenuScripte.instance.inMenu == false && ItemMenuScripte.instance.playerCanMove == true)
        {
            if(collision.name == "Sphere projectile(Clone)")
            {
                currHealth -= ((2 * Time.deltaTime) * (PlayerScript.instance.oldProjCount));
            }

            if(collision.name == "Cinders(Clone)")
            {
                currHealth -= ((2 * Time.deltaTime) * (PlayerScript.instance.oldFlamnum));
            }

            if (currHealth <= 0)
            {
                SphereProjectile.instance.chooseEnemy = true;

                if (gameObject.name == "Ghoul(Clone)")
                {
                    ItemMenuScripte.instance.numberDefeated += 1;
                }

                if (gameObject.name == "Scorpon(Clone)")
                {
                    ItemMenuScripte.instance.numberDefeated += 1;
                }

                if (gameObject.name == "Hoarde(Clone)")
                {
                    ItemMenuScripte.instance.numberDefeated += 2;
                }

                Destroy(gameObject);
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
                PlayerScript.instance.currenthealth -= (dealingDamage - (PlayerScript.instance.defense * 3));
                attackTimer = regAtkTimer;
            }
            
        }
    }

}
