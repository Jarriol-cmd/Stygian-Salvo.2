using UnityEngine;

public class TimerScript : MonoBehaviour
{

    public double secondsPassed;

    public GameObject Scorpons;
    public GameObject Hoardes;

    // Update is called once per frame
    void Update()
    {
        secondsPassed = Mathf.Round(Time.time);

        if (secondsPassed >= 45)
        {
            Scorpons.SetActive(true);
        }

        if (secondsPassed >= 90)
        {
            Hoardes.SetActive(true);
        }

    }
}
