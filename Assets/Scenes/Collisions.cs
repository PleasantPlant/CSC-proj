using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    bool hasPackage = false;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "package" && !hasPackage){
            Debug.Log("Picked up a package!");
            Destroy(other.gameObject);
            hasPackage = true;


        }
        else if (other.gameObject.tag == "customer" && hasPackage){
            Debug.Log("package delivered!");
            hasPackage = false;
        }
        
    }
}
