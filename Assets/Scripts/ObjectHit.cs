using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.CompareTag("AoYin"))
            return;

        GetComponent<MeshRenderer>().material.color = Color.black;
    }
}