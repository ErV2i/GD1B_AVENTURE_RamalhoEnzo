using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTop : MonoBehaviour
{ 
    public GameObject target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        target.layer = 5;
    }
}
