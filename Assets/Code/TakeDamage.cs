using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int damage;
    public CharacterInfo characterInfo;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
             collision.gameObject.GetComponent<CharacterInfo>().TakeDamage(damage);
        }
    }
}