using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool isGround = true;
    bool isSquat = false;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Move1(Input.GetAxisRaw("Horizontal"));
        if (Input.GetKeyDown(KeyCode.UpArrow)&&isGround) Jump();
        if (Input.GetKeyDown(KeyCode.DownArrow)) Squat();
        if (Input.GetKeyUp(KeyCode.DownArrow)) aSquat();
        //}
        //if (Input.GetKey(KeyCode.Z)) Fire;
       
    }

    void Move1(float idou)
    {
         if (isSquat) return;
        transform.Translate(idou * 0.3f, 0.0F, 0.0F);
    }
  

    void Jump()
     {
        this.GetComponent<Rigidbody>().AddForce(0, 200.0f, 0);
    }
     
    void Squat()
    {
        this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y / 2, this.transform.localScale.z);
        isSquat = true;
    }
    void aSquat()
    {
        this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y * 2, this.transform.localScale.z);
        isSquat = false;
    }
    /*  void Fire()
      {
          if(ファイア)
      }
  }*/
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGround = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGround = false;
        }
    }
}