using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCollisionBall : MonoBehaviour{

    private Rigidbody rb;
    private int count;
    public GameObject spawner;

    void Start() {
        spawner = GameObject.Find("respawn");
        spawner.GetComponent<Respawn>().destroyed = false;
        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    void Update() {
        if (Input.GetKey("enter")) {
            Debug.Log("simom");
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("coin")) {
            Destroy(collision.gameObject);
            count += 1;
        } else if (collision.gameObject.CompareTag("lava") && count<3) {
            spawner.GetComponent<Respawn>().destroyed = true;
            Destroy(gameObject);
        }
    }
}
