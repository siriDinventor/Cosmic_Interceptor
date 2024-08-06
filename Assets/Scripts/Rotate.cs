using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Rotate : MonoBehaviour{
    public Transform target;
    public int speed;

    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, speed*Time.deltaTime);
    }
}