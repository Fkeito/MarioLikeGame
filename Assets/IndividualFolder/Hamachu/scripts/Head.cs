using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Shell");
            other.GetComponent<Rigidbody>().AddForce(0f, 8f, 0f,ForceMode.Impulse);
            Destroy(gameObject);
        }
    }
}
