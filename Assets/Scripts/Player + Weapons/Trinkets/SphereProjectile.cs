using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SphereProjectile : MonoBehaviour
{
    GameObject enemyGameObject;

    public Transform enemy;
    private float speed = 3.0f;
    private Vector2 target;
    private float Lifetime = 7;
    public bool chooseEnemy;
    //private float spawntime = 4;
    public static SphereProjectile instance;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      chooseEnemy = true;
        enemy = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemMenuScripte.instance.playerCanMove == true && ItemMenuScripte.instance.inMenu == false)
        { 
            Lifetime -= Time.deltaTime;
            if (enemy != null)
            {
                target = new Vector2(enemy.position.x, enemy.position.y);

                float step = speed * Time.deltaTime;

                // move sprite towards the target location
                transform.position = Vector2.MoveTowards(transform.position, target, step);
            }


            if (Lifetime <= 0)
            {
                Destroy(gameObject);
            }


            if (chooseEnemy == true)
            {

                chooseEnemy = false;

                if (GameObject.FindWithTag("Enemy") != null)
                {
                    enemy = GameObject.FindWithTag("Enemy").GetComponent<Transform>();
                }

                else if (GameObject.FindWithTag("Enemy") == null)
                {
                    enemyGameObject = GameObject.FindWithTag("Enemy"); 
                    GetComponent<Transform>();
                }
            }
        }
    }
}
