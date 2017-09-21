using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

    // Use this for initialization
    private CharacterController controller;
    private Vector3 moveDirection;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        { //地面についているか判定
            if (Input.GetKey(KeyCode.UpArrow))
            {
                moveDirection.y = 2; //ジャンプするベクトルの代入
            }
        }

        moveDirection.y -= 10 * Time.deltaTime; //重力計算
        controller.Move(moveDirection * Time.deltaTime); //cubeを動かす処理
    }
}
