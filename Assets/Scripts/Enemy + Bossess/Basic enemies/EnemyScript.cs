using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform target; 
    public float within_range;
    public float speed;

    public void Update()
    {
        
        float dist = Vector3.Distance(target.position, transform.position);
        
        if (dist <= within_range)
        {
            
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        }
        
    }
}
