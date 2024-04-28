using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBox : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed;
    public GameObject keyPrefab;
    public GameObject moneyPrefab;
    public GameObject pvPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        GenerateProjectiles();
        GenerateItems();
    }

    private void GenerateProjectiles()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector2 spawnPosition = transform.position;

            Vector2 direction = Random.insideUnitCircle.normalized;

            GameObject projectile = Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);

            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

            rb.velocity = direction * projectileSpeed;
        }
    }

    private void GenerateItems()
{
    Vector3 spawnPosition = transform.position;
    Instantiate(keyPrefab, spawnPosition + (Vector3)(Random.insideUnitCircle * 2f), Quaternion.identity);
    Instantiate(moneyPrefab, spawnPosition + (Vector3)(Random.insideUnitCircle * 2f), Quaternion.identity);
    Instantiate(pvPrefab, spawnPosition + (Vector3)(Random.insideUnitCircle * 2f), Quaternion.identity);
}

}
