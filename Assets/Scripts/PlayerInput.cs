using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [Range(0, 10)] public float Speed = 1;
    private Rigidbody _rb;
    private Vector3 _movement;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var h = Input.GetAxis(Constants.HorizontalAxis);
        var v = Input.GetAxis(Constants.VerticalAxis);

        _movement = new Vector3(h, 0, v);
    }

    void FixedUpdate()
    {
        _rb.AddForce(_movement.normalized * Speed);
    }

#if UNITY_EDITOR
    [ContextMenu("Reset values")]
    private void ResetValues()
    {
        Speed = 1;
    }
#endif
}
