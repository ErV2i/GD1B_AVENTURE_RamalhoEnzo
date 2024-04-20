using UnityEngine;

public class Atk : MonoBehaviour
{
    public GameObject DetruirObjet;
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if(collision.CompareTag("Player"))
        {
            Destroy(DetruirObjet);
        }
    }

}