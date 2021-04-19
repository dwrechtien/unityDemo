using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform birdTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var newPosition = new Vector3(birdTransform.position.x, y:5, z:-10);
        transform.position = newPosition;

    }
}
