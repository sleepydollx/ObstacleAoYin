using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Vector3 playerPosition;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, 1f);
    }
}
