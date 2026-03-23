using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.VersionControl.Asset;

public class PlayerScript : MonoBehaviour
{
    public int keyAction = 1;
    public int controlAction = 0;
    public int flumeflyFeatherNumber = 5;

    public float xvel, yvel;

    Rigidbody2D rb;

    InputAction movement;
    InputAction looking;
    InputAction interaction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movement = InputSystem.actions.FindAction("Move");
        interaction = InputSystem.actions.FindAction("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        xvel = rb.linearVelocity.x;
        yvel = rb.linearVelocity.y;

        if (controlAction != 0)
        {
        }

        if (keyAction != 0)
        {
            
        }

        if(interaction.triggered)
        {
            print("Yes");
        }

        
        if (flumeflyFeatherNumber < 15)
        {
            rb.linearVelocity = movement.ReadValue<Vector2>() * flumeflyFeatherNumber;
        }

        else if (flumeflyFeatherNumber == 15)
        {
            rb.linearVelocity = movement.ReadValue<Vector2>() * 20;
            print("You've sprouted Wings");
        } 
        

    }

}
