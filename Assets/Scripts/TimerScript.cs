using UnityEngine;

public class TimerScript : MonoBehaviour
{

    public double secondsPassed;

    public GameObject scorpons;
    public GameObject hoardes;
    public GameObject boss;

    // Update is called once per frame
    void Update()
    {
        secondsPassed = Mathf.Round(Time.time);

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
