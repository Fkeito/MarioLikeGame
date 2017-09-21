using UnityEngine;
using System.Collections;

public class supermario : MonoBehaviour{

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "mushroom")
        {
            transform.localScale = new Vector3(2, 2, 2);
        }
    }

}