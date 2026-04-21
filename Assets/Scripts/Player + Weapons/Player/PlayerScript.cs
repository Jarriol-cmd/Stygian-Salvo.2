using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;
using static UnityEditor.VersionControl.Asset;

public class PlayerScript : MonoBehaviour
{

    public int keyAction = 1;
    public int controlAction = 0;

    public int flumeflyFeatherNumber = 5;
    public int sherBorbHeartNumber = 1;
    public int sphereProjNum = 1;


    double oldspheretimer = 4;
    int oldSherBorbHeart = 1;
    public int oldProjCount = 1;

    public static PlayerScript instance;

    public float xvel, yvel;

    public double spheretimer = 4;
    public GameObject weaponType;

    Rigidbody2D rb;

    InputAction movement;
    InputAction looking;
    InputAction interaction;

    public int maxhealth = 10;
    public int currenthealth = 10;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movement = InputSystem.actions.FindAction("Move");
        interaction = InputSystem.actions.FindAction("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemMenuScripte.instance.playerCanMove == true && ItemMenuScripte.instance.inMenu == false)
        { 
           spheretimer -= (Time.deltaTime);
        }

        xvel = rb.linearVelocity.x;
        yvel = rb.linearVelocity.y;

        if (controlAction != 0)
        {
        }

        if (keyAction != 0)
        {
            
        }

        if(currenthealth > 0)
        {
            if (interaction.triggered)
            {
                ItemMenuScripte.instance.playerCanMove = true;
                ItemMenuScripte.instance.inMenu = false;
            }
        }


        if (ItemMenuScripte.instance.playerCanMove == true && ItemMenuScripte.instance.inMenu == false)
        {
            if (flumeflyFeatherNumber < 15)
            {
                rb.linearVelocity = movement.ReadValue<Vector2>() * flumeflyFeatherNumber;
            }

            else if (flumeflyFeatherNumber == 15)
            {
                rb.linearVelocity = movement.ReadValue<Vector2>() * 20;
            }

            if (flumeflyFeatherNumber > 15)
            {
                flumeflyFeatherNumber = 15;
            }



            if (spheretimer <= 0)
            {
                GameObject clone;
                clone = Instantiate(weaponType, transform.position, Quaternion.identity);
                spheretimer = oldspheretimer;
            }
        }

        if (ItemMenuScripte.instance.playerCanMove == false)
        {
            rb.linearVelocity = movement.ReadValue<Vector2>() * 0;
        }

        if (currenthealth > maxhealth)
        {
            currenthealth = maxhealth;
        }


        if (sherBorbHeartNumber != oldSherBorbHeart)
        {
            oldSherBorbHeart = sherBorbHeartNumber;
            maxhealth *= 2;
        }

        if (sphereProjNum != oldProjCount)
        {
            oldProjCount = sphereProjNum;
            oldspheretimer -= 0.4;
        }

        if (oldspheretimer <= 0)
        {
            oldspheretimer = 1;
        }


        if (currenthealth <= 0)
        {
            RunDeath();
        }
        
    }

    private void OnGUI()
    {

        string text =  ItemMenuScripte.instance.number + " enemies until your next item" + "\nCurrent HP: " + currenthealth + "/" + maxhealth;

        GUI.contentColor = Color.white;
        GUILayout.BeginArea(new Rect(10f, 10f, 1600f, 1600f));
        GUILayout.Label($"<size=24>{text}</size>");
        GUILayout.EndArea();
    }



    void RunDeath()
    {
        ItemMenuScripte.instance.playerCanMove = false;

        
    }


}


