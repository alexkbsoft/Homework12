using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
    public UnityEvent PressedEvent;

    [SerializeField] private Animator _anim;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            _anim.SetTrigger("Press");
            PressedEvent?.Invoke();
        }
    }
}
