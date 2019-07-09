using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        offset = GetComponent<Transform>().position - target.position;
    }

    public Transform target;
    private Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = target.position + offset;
    }
}
