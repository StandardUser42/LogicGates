using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class InputButton : MonoBehaviour
{
    private float zPosition;
    private Vector3 offset;
    public TextMeshProUGUI InputText;

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

    private void OnMouseUp()
    {
        if(gameObject.CompareTag("One"))
        {
            this.gameObject.tag="Untagged";
            InputText.text="0";
        }
        else
        {
            this.gameObject.tag="One";
            InputText.text="1";
        }
    }
}