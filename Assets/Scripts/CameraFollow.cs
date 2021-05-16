using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject hedef;
    public Vector3 mesafe;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, hedef.transform.position + mesafe, Time.deltaTime);

    }
}
