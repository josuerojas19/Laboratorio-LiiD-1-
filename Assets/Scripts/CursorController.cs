using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CursorController : MonoBehaviour
{
    PlayerController pc;

    void Awake()
    {
        pc = gameObject.GetComponent<PlayerController>();
        HideCursor();       
    }

    public void HideCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        pc.enabled = true;
        
    }
    public void ShowCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pc.enabled = false;

    }
}
