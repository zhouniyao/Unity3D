﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_8culbe : MonoBehaviour {

    public EasyJoystick MyJoystick;
    float MoveSpeed = 3f;
    float RotSpeed = 1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (MyJoystick.JoystickTouch.x > 0.5f)
        {//遥杆到右半部
            transform.Rotate(0, RotSpeed, 0);//赛艇向右旋转


        }
        if (MyJoystick.JoystickTouch.x < -0.5f)//遥杆到左半部
        {
            transform.Rotate(0, -RotSpeed, 0);//赛艇向左旋转

        }
        if (MyJoystick.JoystickTouch.y > 0.5f)//遥杆到上半部
        {

            transform.Rotate( -RotSpeed,0, 0);//赛艇向右旋转

        }
        if (MyJoystick.JoystickTouch.y < -0.5f)//遥杆到下半部
        {
            transform.Rotate( RotSpeed, 0,0);//赛艇向右旋转

        }
        if (MyJoystick.JoystickTouch.x == 0 && MyJoystick.JoystickTouch.y == 0)//遥杆未动
        {

        }
    }
}
