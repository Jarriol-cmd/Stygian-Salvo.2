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
    public GameObject shield;
    public GameObject honey;



    public States currentState;

    public static HiddenStatsScript instance;

    public int index;
    public int twindex;

    public GameObject flumeFly;
    public GameObject sherBorb;
    public GameObject blueOrb;
    public GameObject rustyShield;
    public GameObject sweetHoney;

    public int topOrBottom;
    public int twinOrBottom;

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
        rustyShield = shield;
        sweetHoney = honey;



        trinkets = new List<GameObject>();

        trinkets.Add(flumeFly); trinkets.Add(sherBorb); trinkets.Add(blueOrb); trinkets.Add(rustyShield); trinkets.Add(honey);

        currentState = States.SelectingState;

    }

    // Update is called once per frame
    void Update()
    {
        StateLogic();



        if (twindex == index)
        {
            twindex = UnityEngine.Random.Range(0, trinkets.Count);
        }

        if (twinOrBottom == topOrBottom)
        {
            twinOrBottom = UnityEngine.Random.Range(1, 3);
        }

        
    }



    void StateLogic()
    {
        if (currentState == States.SelectingState)
        {
            index = UnityEngine.Random.Range(0, trinkets.Count);
            twindex = UnityEngine.Random.Range(0, trinkets.Count);

            topOrBottom = UnityEngine.Random.Range(1, 3);
            twinOrBottom = UnityEngine.Random.Range(1, 3);

        }

        if (currentState == States.SelectedState) 
        {
            SetPositions();
        }

    }



    void SetPositions()
    {
        if (topOrBottom == 1 && trinkets[index] == flumeFly || twinOrBottom == 1 && trinkets[twindex] == flumeFly)
        {
            feather.GetComponent<RectTransform>().localPosition = new Vector3(0, 150f, 0);
        }

        else if (topOrBottom == 2 && trinkets[index] == flumeFly || twinOrBottom == 2 && trinkets[twindex] == flumeFly)
        {
            feather.GetComponent<RectTransform>().localPosition = new Vector3(0, -150f, 0);
        }

        else
        {
            feather.SetActive(false);
        }



        if (topOrBottom == 1 && trinkets[index] == orb || twinOrBottom == 1 && trinkets[twindex] == orb)
        {
            sherBorb.GetComponent<RectTransform>().localPosition = new Vector3(0, 150f, 0);
        }

        else if (topOrBottom == 2 && trinkets[index] == orb || twinOrBottom == 2 && trinkets[twindex] == orb)
        {
            sherBorb.GetComponent<RectTransform>().localPosition = new Vector3(0, -150f, 0);
        }

        else
        {
            sherBorb.SetActive(false);
        }



        if (topOrBottom == 1 && trinkets[index] == blueOrb || twinOrBottom == 1 && trinkets[twindex] == blueOrb)
        {
            blorb.GetComponent<RectTransform>().localPosition = new Vector3(0, 150f, 0);
        }

        else if (topOrBottom == 2 && trinkets[index] == blueOrb || twinOrBottom == 2 && trinkets[twindex] == blueOrb)
        {
            blorb.GetComponent<RectTransform>().localPosition = new Vector3(0, -150f, 0);
        }

        else
        {
            blorb.SetActive(false);
        }


        if (topOrBottom == 1 && trinkets[index] == rustyShield || twinOrBottom == 1 && trinkets[twindex] == rustyShield)
        {
            shield.GetComponent<RectTransform>().localPosition = new Vector3(0, 150f, 0);
        }

        else if (topOrBottom == 2 && trinkets[index] == rustyShield || twinOrBottom == 2 && trinkets[twindex] == rustyShield)
        {
            shield.GetComponent<RectTransform>().localPosition = new Vector3(0, -150f, 0);
        }

        else
        {
            shield.SetActive(false);
        }


        if (topOrBottom == 1 && trinkets[index] == sweetHoney || twinOrBottom == 1 && trinkets[twindex] == sweetHoney)
        {
            sweetHoney.GetComponent<RectTransform>().localPosition = new Vector3(0, 150f, 0);
        }

        else if (topOrBottom == 2 && trinkets[index] == sweetHoney || twinOrBottom == 2 && trinkets[twindex] == sweetHoney)
        {
            sweetHoney.GetComponent<RectTransform>().localPosition = new Vector3(0, -150f, 0);
        }

        else
        {
            sweetHoney.SetActive(false);
        }
    }

}
