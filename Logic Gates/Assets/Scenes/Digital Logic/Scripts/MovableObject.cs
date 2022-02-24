using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Events;
using UnityEngine.Scripting;   
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class MovableObject : MonoBehaviour
{
    private float zPosition;
    private Vector3 offset;

    private void OnMouseDown()
    {
        zPosition = Camera.main.WorldToScreenPoint(transform.position).z;
        offset = transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + offset;
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = zPosition;

        return Camera.main.ScreenToWorldPoint(mousePosition);
    }
}