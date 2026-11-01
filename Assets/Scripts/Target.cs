using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("TARGET REACHED!");
        }
    }
}
