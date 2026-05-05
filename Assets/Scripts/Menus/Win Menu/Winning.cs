using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Winning : MonoBehaviour
{
    public UnityEngine.UI.Image winScreen;
    public GameObject button;

    public GameObject youWon;

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
            winScreen.enabled = true;
            button.SetActive(true);
            youWon.SetActive(true);
        }


    }


    public void IWin()
    {
        SceneManager.LoadSceneAsync("Menu");
    }
}
