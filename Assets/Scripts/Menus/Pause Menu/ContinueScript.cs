using UnityEngine;

public class ContinueScript : MonoBehaviour
{

    public GameObject button;
    public GameObject button2;
    public GameObject button3;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ReturnToGameplay()
    {
        ItemMenuScripte.instance.playerCanMove = true;
        ItemMenuScripte.instance.inMenu = false;

        button.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
    }

}
