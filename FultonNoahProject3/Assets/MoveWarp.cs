using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWarp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Translate(Vector3.forward * -2 * Time.deltaTime);
        }
    }
}
