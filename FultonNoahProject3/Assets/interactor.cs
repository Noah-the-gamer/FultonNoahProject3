using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class interactor : MonoBehaviour
{
    private float _sensitivity;
    private Vector3 _mouseReference;
    private Vector3 _mouseOffset;
    private Vector3 _rotation;
    private bool _isRotating;
    private bool isCollided = false;

    // Start is called before the first frame update
    void Start()
    {
        _sensitivity = 0.4f;
        _rotation = Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {
        if (_isRotating)
        {
            // offset
            _mouseOffset = (Input.mousePosition - _mouseReference);

            // apply rotation
            _rotation.y = -(_mouseOffset.x) * _sensitivity;
            _rotation.x = -(_mouseOffset.y) * _sensitivity;
            // rotate
           // transform.Rotate(_rotation);
            transform.eulerAngles += _rotation;
            // store mouse
            _mouseReference = Input.mousePosition;
        }
    }
    void OnTriggerEnter(Collider other) {
        isCollided = true;
        Debug.Log(other);

    }
    void OnTriggerExit(Collider other)
    {
        isCollided = false;
    }
    void OnMouseDown()
    {
        if (isCollided)
        {
            Debug.Log("mouse is down");
            // rotating flag
            _isRotating = true;

            // store mouse
            _mouseReference = Input.mousePosition;
        }
    }

    void OnMouseUp()
    {
        // rotating flag
        _isRotating = false;
    }
}
