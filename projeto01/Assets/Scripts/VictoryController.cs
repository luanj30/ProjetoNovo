using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VictoryController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.isPressed)
        {
            Time.timeScale = 1f;
            gamemanager.Instance.StartGame();
        } 
    }
}
