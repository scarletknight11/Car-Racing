using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour {

    public float speed;
    public float turnSpeed;
    public Text speedUI;

    void Start()
    {
        speed = 0;
        speedUI.text = "Speed: " + speed;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed += 1;
            speedUI.text = "Speed: " + speed;
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if (speed >= 100)
            {
                speed = 100;
                speedUI.text = "Speed: " + speed;
            }
        }  

        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed -= 1;
            speedUI.text = "Speed: " + speed;
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            if (speed <= 0)
            {
                speed = 0;
                speedUI.text = "Speed: " + speed;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }
}