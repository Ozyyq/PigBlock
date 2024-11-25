using UnityEngine;

public class Block : MonoBehaviour
{
    private void Update()
    {
        if( transform.position.y < -6f) { 
        Destroy(gameObject);
        }
    }
}
