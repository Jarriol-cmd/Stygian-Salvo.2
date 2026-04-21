using System.Threading;
using UnityEngine;

public class ScalingScript : MonoBehaviour
{
    float timer;

    public static ScalingScript instance;
    public float healthPoints = 0;
    public int damageDealt = 0;

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
        timer = 20f;

        
    }

    // Update is called once per frame
    void Update()
    {

        if (ItemMenuScripte.instance.inMenu == false || ItemMenuScripte.instance.playerCanMove == true)
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                healthPoints += 3;
                damageDealt += 2;
                timer = 20f;
            }
        }

    }
}
