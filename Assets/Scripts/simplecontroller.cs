using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplecontroller : MonoBehaviour {

    public WheelCollider[] Wheels;
    public float MotorPower;
    public float SteerPower;

    void FixedUpdate()
    {
        foreach (var wheel in Wheels)
        {
            wheel.motorTorque = Input.GetAxis("Vertical") * MotorPower;
        }

        for (int i = 0; i < Wheels.Length; i++)
        {
            if (i < 2)
            {
                Wheels[i].steerAngle = Input.GetAxis("Horizontal") * SteerPower;
            }
        }
    }

}
