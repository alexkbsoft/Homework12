using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorTrigger : MonoBehaviour
{
    public bool IsLocked = true;
    [SerializeField] private Animator _parentAnimator;
    [SerializeField] private GameObject _commentText;

    private bool _isInZone = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _isInZone && !IsLocked)
        {
            _parentAnimator.SetTrigger("Open");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !IsLocked)
        {
            _isInZone = true;
            _commentText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && !IsLocked)
        {
            _isInZone = false;
            _commentText.SetActive(false);
        }
    }

    public void OnButtonPressed() {
        IsLocked = false;
    }
}
