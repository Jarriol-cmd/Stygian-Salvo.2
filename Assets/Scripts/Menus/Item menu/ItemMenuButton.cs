using System.Collections.Generic;
using UnityEngine;

public class ItemMenuButton : MonoBehaviour
{

    int flumePick;
    int heroPick;
    int orbPick;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        


        if (gameObject.name != "Flumefly Feather" && flumePick >= 10)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.name != "sherBorb Heart" && heroPick >= 5)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.name != "Blue Orb Button" && orbPick >= 5)
        {
            gameObject.SetActive(false);
        } 
    }

    public void Flume()
    {
        PlayerScript.instance.flumeflyFeatherNumber += 1;
        flumePick += 1;
    }

    public void sherBorb()
    {
        PlayerScript.instance.sherBorbHeartNumber += 1;
        heroPick += 1;
    }

    public void Blorb()
    {
        PlayerScript.instance.sphereProjNum += 1;
        orbPick += 1;
    }
}
