using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterInfo : MonoBehaviour
{
    private GameManager manager;
    public int moneyCount = 0;
    public int health;
    public int numberOfHeart;
    public Image[] heart;
    public Sprite Heart;

    void Update()
    {
        for (int i = 0; i < heart.Length; i++)
         if( i < numberOfHeart){
            heart[i].enabled = true;
         } else {
            heart[i].enabled = false;
         }
         if (health <= 0)
         {
            Destroy (gameObject);
         }
    }
     public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        numberOfHeart -= damageAmount;
    }
     public void CollectItem(GameObject item)
    {
        if (item.CompareTag("pognon"))
        {
            moneyCount++; 
        }

        Destroy(item);
    }
}
