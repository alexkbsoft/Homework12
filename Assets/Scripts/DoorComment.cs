using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorComment : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI comment;
    public void OnButtonPressed() {
        comment.color = Color.green;
        comment.text = "Добро пожаловать";
    }
}
