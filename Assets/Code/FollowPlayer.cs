
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float RangeDetection;
    public GameObject player;
    public float speed;

    private float distance;

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();

        if (distance < RangeDetection)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
