using UnityEngine;
using System.Collections;

public class SwitchController : MonoBehaviour {

    public Material movementMaterial;
    public Material accelerationMaterial;

    private MeshRenderer meshRenderer;
    private CubeController controller;
    private CubeControllerWithAcceleration controllerAcc;

    // Use this for initialization
    void Start()
    {
        controller = this.gameObject.GetComponent<CubeController>();
        controller.enabled = true;
        controllerAcc = this.gameObject.GetComponent<CubeControllerWithAcceleration>();
        controllerAcc.enabled = false;
        meshRenderer = this.gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material = movementMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) // Note that we use the "down" variant of GetKey so that this
                                         // only executes once at the start of the key press
        {
            // Swap the script
            controller.enabled = !controller.enabled;
            controllerAcc.enabled = !controllerAcc.enabled;

            // Change the material
            meshRenderer.material = controller.enabled ? movementMaterial : accelerationMaterial;
        }
    }
}
