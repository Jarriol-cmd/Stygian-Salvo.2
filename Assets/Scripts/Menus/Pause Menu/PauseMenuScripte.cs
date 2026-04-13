using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PauseMenuScripte : MonoBehaviour
{

    InputAction escape;

    InputAction navigation;
    InputAction submittion;

    public UnityEngine.UI.Image myimnage;

    public GameObject button;
    public GameObject button2;
    public GameObject button3;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        escape = InputSystem.actions.FindAction("Escape");
        navigation = InputSystem.actions.FindAction("Navigate");
        submittion = InputSystem.actions.FindAction("Submit");
        myimnage.enabled = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (escape.triggered)
        {
            OpenPauseMenu();
            
        }

    }

    void OpenPauseMenu()
    {
        ItemMenuScripte.instance.inMenu = true;
        ItemMenuScripte.instance.playerCanMove = false;
        myimnage.enabled = true;
        
        button.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
    }
}
