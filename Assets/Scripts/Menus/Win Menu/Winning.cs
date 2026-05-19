using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Winning : MonoBehaviour
{
    public UnityEngine.UI.Image winScreen;
    public GameObject button;

    public GameObject youWon;

    public GameObject eventSystem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winScreen.enabled = false;
        button.SetActive(false);
        youWon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(BosskillerScript.instance.isDead >= 1)
        {
            button.SetActive(true);

            if (winScreen.enabled == false)
            {
                eventSystem.GetComponent<EventSystem>().SetSelectedGameObject(button);
            }

            winScreen.enabled = true;
            
            youWon.SetActive(true);

            ItemMenuScripte.instance.inMenu = true;
            ItemMenuScripte.instance.playerCanMove = false;
            
        }


    }


    public void IWin()
    {
        SceneManager.LoadSceneAsync("Menu");
    }
}
