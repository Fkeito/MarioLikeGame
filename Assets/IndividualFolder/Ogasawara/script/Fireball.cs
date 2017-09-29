using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour
{

    // bullet prefab
    public GameObject fireball;

    // 弾丸発射点
    public Transform muzzle;

    // 弾丸の速度
    public float speed = 1000;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // z キーが押された時
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // 弾丸の複製
            GameObject Fireball = GameObject.Instantiate(fireball) as GameObject;

            Vector3 force;
            force = this.gameObject.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            fireball.GetComponent<Rigidbody>().AddForce(force);
            // 弾丸の位置を調整
            fireball.transform.position = muzzle.position;
        }
    }
}
