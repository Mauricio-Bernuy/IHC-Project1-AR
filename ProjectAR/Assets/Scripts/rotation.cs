using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Update is called once per frame
    public Vector3 rotator;
    public float speed;
    void Update()
    {
        transform.Rotate(rotator * speed * Time.deltaTime);
    }
}
