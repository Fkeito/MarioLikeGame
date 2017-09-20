using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Move(Input.GetAxisRaw("Horizontal"));
        //if (Input.GetKey(KeyCode.Space)) Jump();
        if (Input.GetKeyDown(KeyCode.DownArrow)) Squat();
        if (Input.GetKeyUp(KeyCode.DownArrow)) aSquat();
        //}
        //if (Input.GetKey(KeyCode.Z)) Fire;

    }
    void Move(float idou)
    {
        // if (idou == 0 || squat=true) return;
        transform.Translate(idou * 0.1f, 0.0F, 0.0F);
    }


    /* void Jump()
     {

     }
     */
    void Squat()
    {
        this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y / 2, this.transform.localScale.z);
    }
    void aSquat()
    {
        this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y * 2, this.transform.localScale.z);
    }
    /*  void Fire()
      {
          if(ファイア)
      }
  }*/
}
