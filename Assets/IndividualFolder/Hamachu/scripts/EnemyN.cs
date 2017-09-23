using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyN : MonoBehaviour //ノコノコ
{

    public Vector3 StartPos;    //始点
    public Vector3 EndPos;      //終点
    public float time;          //移動時間
    private Vector3 dPos;       //変化量
    private float elapsedTime;  //経過時間
    private bool flag = true;
    private bool holdflag;

    void Start()
    {
        transform.position = StartPos;
        dPos = (EndPos - StartPos) / time;
        elapsedTime = 0;
        Debug.Log(transform.childCount);

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

        if (transform.childCount == 0)
        {
            holdflag = flag;
            StartPos = transform.position;
            EndPos = transform.position;
            elapsedTime = time + 1;
        }
    }
}


