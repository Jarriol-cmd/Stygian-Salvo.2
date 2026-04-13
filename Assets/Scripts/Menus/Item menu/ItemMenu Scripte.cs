using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ItemMenuScripte : MonoBehaviour
{
    [SerializeField]

    public bool playerCanMove = true;
    public bool inMenu = false;
    public int numberDefeated = 0;
    public int numberNeeded = 10;

    public static ItemMenuScripte instance;

    InputAction navigation;
    InputAction submittion;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navigation = InputSystem.actions.FindAction("Navigate");
        submittion = InputSystem.actions.FindAction("Submit");

    }

    // Update is called once per frame
    void Update()
    {
       if (numberDefeated >= numberNeeded)
        {
            inMenu = true;
            playerCanMove = false;

            numberDefeated = 0;
            numberNeeded += 1;
            OpenItemMenu();
        }
    }


    void OpenItemMenu()
    { 


    }
}
