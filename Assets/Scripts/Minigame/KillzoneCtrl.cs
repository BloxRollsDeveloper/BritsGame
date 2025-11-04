using UnityEngine;

public class KillzoneCtrl : MonoBehaviour
{ 
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
    }
}
