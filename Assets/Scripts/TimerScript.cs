using UnityEngine;

public class TimerScript : MonoBehaviour
{

    public double secondsPassed;

    public GameObject scorpons;
    public GameObject hoardes;
    public GameObject boss;


    private void Start()
    {
        secondsPassed = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if(ItemMenuScripte.instance.playerCanMove == true && ItemMenuScripte.instance.inMenu == false)
        {
            secondsPassed = (Time.deltaTime);

            if (secondsPassed >= 45)
            {
                scorpons.SetActive(true);
            }

            if (secondsPassed >= 90)
            {
                hoardes.SetActive(true);
            }


            if (secondsPassed >= 300)
            {
                boss.SetActive(true);
            }
        }
    }
}
