using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum States
{
    SelectingState,
    SelectedState
}


public class HiddenStatsScript : MonoBehaviour
{
    public GameObject feather;
    public GameObject orb;
    public GameObject blorb;



    public States currentState;

    public static HiddenStatsScript instance;

    int index;

    GameObject flumeFly;
    GameObject sherBorb;
    GameObject blueOrb;

    public int topOrBottom;

    public List<GameObject> trinkets;

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
        flumeFly = feather;
        sherBorb = orb;
        blueOrb = blorb;



        trinkets = new List<GameObject>();

        trinkets.Add(flumeFly); trinkets.Add(sherBorb); trinkets.Add(blueOrb);

        currentState = States.SelectingState;

    }

    // Update is called once per frame
    void Update()
    {
        StateLogic();
        
    }



    void StateLogic()
    {
        if (currentState == States.SelectingState)
        {
            index = UnityEngine.Random.Range(0, trinkets.Count);
            topOrBottom = UnityEngine.Random.Range(1, 3);
        }

        if (currentState == States.SelectedState) 
        {
            SetPositions();
        }

    }



    void SetPositions()
    {
        if (topOrBottom == 1 && trinkets[index] == flumeFly)
        {
            //feather.transform.position = new Vector3(1134, 142, 0);
        }

        else if (topOrBottom == 2 && trinkets[index] == flumeFly)
        {
            //feather.transform.position = new Vector3(0, 0, 0);
        }



        else
        {
            feather.SetActive(false);
        }

        if (topOrBottom == 1 && trinkets[index] == orb)
        {
            //sherBorb.transform.position = new Vector3(0, 0, 0);
        }

        else if (topOrBottom == 2 && trinkets[index] == orb)
        {
            //sherBorb.transform.position = new Vector3(0, 0, 0);
        }

        else
        {
            sherBorb.SetActive(false);
        }



        if (topOrBottom == 1 && trinkets[index] == blueOrb)
        {
            //blorb.transform.position = new Vector3(0, 0, 0);
        }

        else if (topOrBottom == 2 && trinkets[index] == blueOrb)
        {
            //blorb.transform.position = new Vector3(0, 0, 0);
        }

        else
        {
            blorb.SetActive(false);
        }
    }

}
