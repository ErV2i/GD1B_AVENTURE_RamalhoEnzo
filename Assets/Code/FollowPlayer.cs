using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float RangeDetection;
    public GameObject player;
    public float speed;

    void Start()
    {

    }

    private void Update()
    {
        if (player != null)
        {
            float distance = Vector2.Distance(transform.position, player.transform.position);

            if (distance < RangeDetection)
            {
                Vector3 direction = (player.transform.position - transform.position).normalized;
                transform.position += direction * speed * Time.deltaTime;

                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
        }
    }
}
