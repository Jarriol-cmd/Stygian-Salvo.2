using System.Threading;
using UnityEngine;

public class ScalingScript : MonoBehaviour
{
    public static ScalingScript instance;

    public float minutes = 0;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        minutes = Time.time;

        if (minutes % 30 == 0 && ItemMenuScripte.instance.inMenu == false)
        {
            EnemyScript.instance.healthPoints += 3;
            EnemyScript.instance.speed += 2;
        }
    }
}
