using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

    public float speed;

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

        this.transform.localPosition += new Vector3(dx, 0.0f, dz) * speed * Time.deltaTime;
    }
}
