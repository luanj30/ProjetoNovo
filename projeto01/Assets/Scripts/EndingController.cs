using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EndingController : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.isPressed)
        {
            gamemanager.Instance.LoadMenu();
        }
        
    }
}
