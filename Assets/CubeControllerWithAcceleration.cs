﻿using UnityEngine;
using System.Collections;

public class CubeControllerWithAcceleration : MonoBehaviour {

    public float accelerationFactor;

    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        float dx = 0.0f, dz = 0.0f;
        if (Input.GetKey(KeyCode.RightArrow)){
            print("RightArrow");
            dx += 1.0f;
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            print("LeftArrow");
            dx -= 1.0f;
        }
        if (Input.GetKey(KeyCode.UpArrow)){
            print("UpArrow");
            dz += 1.0f;
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            print("DownArrow");
            dz -= 1.0f;
        }

        velocity += new Vector3(dx, 0.0f, dz) * accelerationFactor * Time.deltaTime;

        this.transform.localPosition += velocity * Time.deltaTime;
    }
}
