using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        Transform parent = other.transform.parent;
        if (parent != null)
        {
           GameObject.Destroy(parent.gameObject);
        }



        // Transform current = other.transform.parent;
        // while(current != null){
        //    Transform parent = current.parent;
        //     Destroy(current.gameObject);
        //     current = parent;
        // }
        
    }
}
