using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipMap : MonoBehaviour
{
    bool mapUp = true;
    Transform t;
    // Start is called before the first frame update
    void Start()
    {
        t = transform;
        transform.position += Vector3.up * 1000f;
        mapUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && mapUp)
        {
            transform.position += Vector3.up * 1000f;
            mapUp = false;
        }
        else if (Input.GetKeyDown(KeyCode.M) && !mapUp) {
            transform.position -= Vector3.up * 1000f;
            mapUp = true;
        }
    }
}
