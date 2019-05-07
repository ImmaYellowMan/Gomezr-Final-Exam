using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Dropdown Size;
    public Toggle Instructions;
    public Dropdown Speed;
    public Dropdown GameMode;
    public static int size;
    public static int speed;
    
    // Update is called once per frame
    void Update()
    {

        switch (Size.value)
        {
            case 1:
                size = 1;
                break;
            case 2:
                size = 5;
                break;
            case 3:
                size = 10;
                break;

        }

        if (Instructions.isOn)
        {
            Debug.Log("Ive Read The Instructions"); 
        }

        switch (Speed.value)
        {
            case 1:
                speed = 1;
                break;
            case 2:
                speed = 5;
                break;
            case 3:
                speed = 10;
                break;

        }

        switch (GameMode.value)
        {
            case 1:
                GameManager.timer = 10f;
                break;
            case 2:
                GameManager.timer = 60f;
                break;
            

        }



    }
}