using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLook : MonoBehaviour
{
    public GameObject target;

    // Update is called once per frame
    void OnMouseDown()
    {
        LookAt.target = target;
        
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 1000);
    }
}
