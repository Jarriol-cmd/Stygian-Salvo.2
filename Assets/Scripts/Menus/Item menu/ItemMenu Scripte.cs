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

    public int number = 0;

    public static ItemMenuScripte instance;

    public UnityEngine.UI.Image myimnage;

    public GameObject button;
    public GameObject button2;
    public GameObject button3;

    InputAction navigation;
    InputAction submittion;
    InputAction escape;



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
        escape = InputSystem.actions.FindAction("Escape");

        navigation = InputSystem.actions.FindAction("Navigate");
        submittion = InputSystem.actions.FindAction("Submit");

        myimnage.enabled = false;

        button.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);

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

            HiddenStatsScript.instance.currentState = States.SelectedState;

          
        }

        if (submittion.triggered)
        {
            myimnage.enabled = false;

            button.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);

            

        }


        number = numberNeeded - numberDefeated;
    }


    void OpenItemMenu()
    {
        myimnage.enabled = true;

        button.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);

    }
}
