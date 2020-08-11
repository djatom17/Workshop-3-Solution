using UnityEngine;
using System.Collections;

public class TrackObject : MonoBehaviour {

    public GameObject objectToTrack;

    // Note that *late* update is used to ensure the most recent position
    // of the object being tracked is used. Otherwise the camera can lag
    // behind the tracked object by a frame.
    void LateUpdate () {
        Vector3 lookVec = objectToTrack.transform.position - this.transform.position;
        this.transform.rotation = Quaternion.LookRotation(lookVec, Vector3.up);

        // An alternative, even simpler solution (which essentially does the same
        // behind the scenes):
        //
        // this.transform.LookAt(objectToTrack.transform);
    }
}
