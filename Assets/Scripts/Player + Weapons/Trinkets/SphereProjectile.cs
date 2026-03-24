using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SphereProjectile : MonoBehaviour
{
    public Transform enemy;
    private float speed = 3.0f;
    private Vector2 target;
    private float Lifetime = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (GameObject.FindWithTag("Enemy") != null)
        {
            enemy = GameObject.FindWithTag("Enemy").GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Lifetime -= Time.deltaTime;

        target = new Vector2(enemy.position.x, enemy.position.y);

        float step = speed * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, target, step);

        if (Lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
