using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Time.time > 3)
        {
            Debug.Log("Look up! :)");
        }
    }
}
