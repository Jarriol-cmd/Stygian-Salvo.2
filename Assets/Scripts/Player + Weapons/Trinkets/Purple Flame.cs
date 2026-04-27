using UnityEngine;

public class PurpleFlame : MonoBehaviour
{
    public GameObject player;

    private float Lifetime = 4;

    private float oldLife = 4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lifetime = oldLife;

        player = GameObject.FindWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = player.gameObject.transform.position;


        if (PlayerScript.instance.everFlame != PlayerScript.instance.oldFlamnum)
        {
            oldLife += 1;
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + PlayerScript.instance.everFlame, gameObject.transform.localScale.y + PlayerScript.instance.everFlame, 1);
        }



        if (ItemMenuScripte.instance.playerCanMove == true && ItemMenuScripte.instance.inMenu == false)
        {
            Lifetime -= (Time.deltaTime);
            

            if (Lifetime <= 0)
            {
                Destroy(gameObject);
            }

        }
    }
}
