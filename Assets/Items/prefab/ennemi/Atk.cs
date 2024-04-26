using UnityEngine;

public class detruirGO : MonoBehaviour
{
    private void Enter2DCollider (Collider2D collision)

    {
        if(collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}