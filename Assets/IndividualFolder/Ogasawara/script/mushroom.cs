﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroom : MonoBehaviour {

    public Vector3 StartPos;    //始点
    public Vector3 EndPos;      //終点
    public float time;          //移動時間
    private Vector3 dPos;       //変化量
    private float elapsedTime;  //経過時間
    private bool flag = true;

    void Start()
    {
        transform.position = StartPos;
        dPos = (EndPos - StartPos) / time;
        elapsedTime = 0;
    }

    //左右に移動
    void Update()
    {

        transform.position += dPos * Time.deltaTime;
        elapsedTime += Time.deltaTime;

        if (elapsedTime > time)
        {

            if (flag)
            {
                dPos = (StartPos - EndPos) / time;
                transform.position = EndPos;
            }
            else
            {
                dPos = (EndPos - StartPos) / time;
                transform.position = StartPos;
            }

            flag = !flag;
            elapsedTime = 0;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
