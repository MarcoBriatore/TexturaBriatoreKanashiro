using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBehaviourScript : MonoBehaviour
{

    float rotationSpeed = 0.01f;
    float rotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation += rotationSpeed;
        
        transform.localRotation = new Quaternion(rotation * Time.deltaTime, 0, 0, 1);
    }
}
