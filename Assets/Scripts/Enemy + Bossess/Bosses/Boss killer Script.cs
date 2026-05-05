using UnityEngine;

public class BosskillerScript : MonoBehaviour
{

    public int isDead;

    public static BosskillerScript instance;

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
        isDead = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
