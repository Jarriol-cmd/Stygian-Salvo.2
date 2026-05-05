using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    public UnityEngine.UI.Image deathScreen;

    public GameObject again;
    public GameObject menu;

    public GameObject youDied;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        deathScreen.enabled = false;

        again.SetActive(false);
        menu.SetActive(false);

        youDied.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScript.instance.currenthealth <= 0)
        {
            deathScreen.enabled = true;
            again.SetActive(true);
            menu.SetActive(true);
            youDied.SetActive(true);

        }


    }


    public void Descend()
    {
        SceneManager.LoadSceneAsync("Survival");
    }


    public void MoveOn()
    {
        SceneManager.LoadSceneAsync("Menu");
    }

}
