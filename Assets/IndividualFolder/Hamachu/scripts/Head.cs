using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {   //Finishタグのオブジェクトは弱点
        if (this.tag == "Finish" && other.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Shell");
        }
    }
}
