using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour{

    public GameObject obj;
    private GameObject clone;
    public bool destroyed;

    void Start(){
        
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Return) && destroyed)
            clone = Instantiate(obj, transform.position, Quaternion.identity) as GameObject;
    }

}
