using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour
{

    InputAction submit;
    public Button button;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        Button button = GetComponent<Button>();

        OnSelect();

        submit = InputSystem.actions.FindAction("Submit");
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLevel()
    {
        SceneManager.LoadSceneAsync("Survival");
    }

    public void RageQuit()
    {
        Application.Quit();
    }

    private void OnSelect()
    {
        button.Select();
    }


}
