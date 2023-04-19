using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [Range(2, 10)] public float CameraDistance = 7;
    private Vector3 _offset;
    private GameObject _player;

    void Start()
    {
        _player = GameObject.Find("Player");
        _offset = (Vector3.back + Vector3.up);
    }

    void Update()
    {
        transform.position = _player.transform.position + _offset * CameraDistance;
    }
}
