using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyScript : MonoBehaviour
{
    public Transform player;
    private float speed = 3.0f;
    private Vector2 target;

    void Start()
    {
        

    }

    void Update()
    {

        target = new Vector2(player.position.x, player.position.y);
        
        float step = speed * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, target, step);

        

    }



}
