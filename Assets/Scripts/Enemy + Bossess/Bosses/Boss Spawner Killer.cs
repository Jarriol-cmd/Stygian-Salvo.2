using Unity.VisualScripting;
using UnityEngine;

public class BossSpawnerKiller : MonoBehaviour
{
    public GameObject boss;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<SpawnerScript>().SpawnedEntity == boss && boss.activeInHierarchy)
        {
            Destroy(gameObject);
        }


    }
}
