using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemMenuButton : MonoBehaviour
{

    public int flumePick;
    public int sherPick;
    public int orbPick;

    public GameObject button;
    public GameObject button2;
    public GameObject button3;


    public static ItemMenuButton instance;

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
        if (flumePick >= 10)
        {
            button.SetActive(false);
            HiddenStatsScript.instance.trinkets.Remove(HiddenStatsScript.instance.flumeFly);
            
        }

        if (sherPick >= 5)
        {
            button2.SetActive(false);
            HiddenStatsScript.instance.trinkets.Remove(HiddenStatsScript.instance.sherBorb);
            
        }

        if (orbPick >= 5)
        {

            button3.SetActive(false);
            HiddenStatsScript.instance.trinkets.Remove(HiddenStatsScript.instance.blueOrb);
            
        }


    }

    public void Flume()
    {
        PlayerScript.instance.flumeflyFeatherNumber += 1;
        flumePick += 1;

        ItemMenuScripte.instance.playerCanMove = true;
        ItemMenuScripte.instance.inMenu = false;

        HiddenStatsScript.instance.currentState = States.SelectingState;
    }

    public void sherBorb()
    {
        PlayerScript.instance.sherBorbHeartNumber += 1;
        sherPick += 1;

        ItemMenuScripte.instance.playerCanMove = true;
        ItemMenuScripte.instance.inMenu = false;

        HiddenStatsScript.instance.currentState = States.SelectingState;
    }

    public void Blorb()
    {
        PlayerScript.instance.sphereProjNum += 1;
        orbPick += 1;

        ItemMenuScripte.instance.playerCanMove = true;
        ItemMenuScripte.instance.inMenu = false;

        HiddenStatsScript.instance.currentState = States.SelectingState;
    }
}
