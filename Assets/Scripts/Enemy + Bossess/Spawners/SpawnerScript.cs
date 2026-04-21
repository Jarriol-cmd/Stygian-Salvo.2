using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public enum SpawnerState
    {
        None,
        Scorpon,
        Ghoul,
        Hoarde,
        Boss,
        Dread,
        Fake
    }

    SpawnerState SpawnedEnemy;
    public GameObject SpawnedEntity;
    public float timer = 6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnedEnemy = SpawnerState.None;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnerLogic();
    }

    void SpawnerLogic()
    {
        if (gameObject.name == "EnemySpawner - Ghoul")
        {
            SpawnedEnemy = SpawnerState.Ghoul;
            GhoulSpawner();
        }

        if (gameObject.name == "EnemySpawner - Scorpon")
        {
            SpawnedEnemy = SpawnerState.Scorpon;
            ScorponSpawner();
        }

        if (gameObject.name == "Hoarde Spawner")
        {
            SpawnedEnemy = SpawnerState.Hoarde;
            HoardeSpawner();
        }

        if (gameObject.name == "BossSpawner - Dread's Claws" || gameObject.name == "BossSpawner - Dread's Fangs" || gameObject.name == "BossSpawner - Dread's Wings" || gameObject.name == "BossSpawner - Dread's Hide")
        {
            SpawnedEnemy = SpawnerState.Boss;
            BossSpawner();
        }

        if (gameObject.name == "Dread Spawner")
        {
            SpawnedEnemy = SpawnerState.Dread;
            DreadSpawner();
        }

        if (gameObject.name == "EnemySpawner - Scorpon?" || gameObject.name == "EnemySpawner - Ghoul?")
        {
            SpawnedEnemy = SpawnerState.Fake;
            FakeSpawner();
        }
    }


    void GhoulSpawner()
    {
        if (ItemMenuScripte.instance.inMenu == false && ItemMenuScripte.instance.playerCanMove == true)
        { 
            timer -= (Time.deltaTime);
            if (timer <= 0)
            {
                GameObject clone;
                clone = Instantiate(SpawnedEntity, transform.position, Quaternion.identity);
                timer = Random.Range(3 , 9);
            }
        }
    }

    void ScorponSpawner()
    {
        if (ItemMenuScripte.instance.inMenu == false && ItemMenuScripte.instance.playerCanMove == true)
        {
            timer -= (Time.deltaTime);
            if (timer <= 0)
            {
                GameObject clone;
                clone = Instantiate(SpawnedEntity, transform.position, Quaternion.identity);
                timer = Random.Range(5, 13);
            }
        }
    }

    void HoardeSpawner()
    {
        if (ItemMenuScripte.instance.inMenu == false && ItemMenuScripte.instance.playerCanMove == true)
        {
            timer -= (Time.deltaTime);
            if (timer <= 0)
            {
                
            }
        }
    }

    void BossSpawner()
    {
        if (ItemMenuScripte.instance.inMenu == false && ItemMenuScripte.instance.playerCanMove == true)
        {
            timer -= (Time.deltaTime);
            if (timer <= 0)
            {
                
            }
        }
    }

    void DreadSpawner()
    {
        if (ItemMenuScripte.instance.inMenu == false && ItemMenuScripte.instance.playerCanMove == true)
        {
            timer -= (Time.deltaTime);
            if (timer <= 0)
            {
                
            }
        }
    }

    void FakeSpawner()
    {
        if (ItemMenuScripte.instance.inMenu == false && ItemMenuScripte.instance.playerCanMove == true)
        {
            timer -= (Time.deltaTime);
            if (timer <= 0)
            {
                
            }
        }
    }

}
