using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Transform playerTransform;
    Vector3 playerPosition;
    
    void Start()
    {
        playerPosition = playerTransform.position;
    }

    void Update()
    {
        transform.position = 
        Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime*speed);
    }
}
