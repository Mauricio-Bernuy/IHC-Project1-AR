using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RotateToCamera : MonoBehaviour
{
    private GameObject MainCamera;
    private float Speed = 2.0f;
 
    void Awake ()
    {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
 
    void Update ()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(MainCamera.transform.position - transform.position) * Quaternion.Euler(0, -90, 0), Speed*Time.deltaTime);
    }
}