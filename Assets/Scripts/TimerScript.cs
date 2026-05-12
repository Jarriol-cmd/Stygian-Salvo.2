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
            secondsPassed += (Time.deltaTime);

            if (secondsPassed > 45 && secondsPassed < 46)
            {
                scorpons.SetActive(true);
                AudioScript.instance.PlaySFX("Scorpon Spawn");
            }

            if (secondsPassed > 90 && secondsPassed < 91)
            {
                hoardes.SetActive(true);
                AudioScript.instance.PlaySFX("Hoarde Spawn");
            }


            if (secondsPassed > 300 && secondsPassed < 301)
            {
                boss.SetActive(true);
                AudioScript.instance.PlaySFX("Bird Spawn");
            }
        }
    }
}
