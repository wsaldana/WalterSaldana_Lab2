using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour{

    public float angularVelocity = 150;
    public Vector3 initPos;

    void Start(){
        initPos = transform.localPosition;
    }

    void Update(){
        transform.Rotate(new Vector3(0,0,Time.deltaTime) * angularVelocity);
        transform.localPosition = initPos + (new Vector3(0, Mathf.Sin(Time.time), 0)) * 0.5f;
    }
}
