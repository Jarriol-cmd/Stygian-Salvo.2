using UnityEngine;

public class TimerScript : MonoBehaviour
{

    public double secondsPassed;

    public GameObject Scorpons;

    // Update is called once per frame
    void Update()
    {
        secondsPassed = Mathf.Round(Time.time);

        if (secondsPassed >= 30)
        {
            Scorpons.SetActive(true);
        }
    }
}
