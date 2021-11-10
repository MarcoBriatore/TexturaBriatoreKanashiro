using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBehaviourScript : MonoBehaviour
{

    [SerializeField]
    float rotationSpeed = 0.1f;
    float rotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation += rotationSpeed * Time.deltaTime;

        transform.Rotate(new Vector3(rotationSpeed, 0, 0), Space.Self);
    }
}
