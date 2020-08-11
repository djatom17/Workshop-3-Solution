using UnityEngine;
using System.Collections;

public class MoveForwardAndBackward : MonoBehaviour {

    public float thresholdDistance;
    public float speed;

    private int dir = 1; // Switches when cube reverses direction

    // Update is called once per frame
    void Update () {
        this.transform.localPosition += Vector3.forward * Time.deltaTime * speed * dir;
        if (this.transform.localPosition.z > thresholdDistance)
            dir = -1;
        else if (this.transform.localPosition.z < 0.0f)
            dir = 1;
    }
}
