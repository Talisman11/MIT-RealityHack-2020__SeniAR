using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class CameraWrapperTeleport : MonoBehaviour
{
    [SerializeField]
    private float teleportDistance = 3f;

    [SerializeField]
    private Transform cam;

    private void OnEnable()
    {
        InteractionManager.InteractionSourcePressed += InteractionManager_InteractionSourcePressed;
    }

    private void OnDisable()
    {
        InteractionManager.InteractionSourcePressed -= InteractionManager_InteractionSourcePressed;
    }

    private void InteractionManager_InteractionSourcePressed(InteractionSourcePressedEventArgs obj)
    {
        if (obj.state.source.handedness == InteractionSourceHandedness.Left)
        {
            this.transform.position = this.transform.position - cam.transform.forward * teleportDistance;
            if (this.transform.position.y < 0f)
            {
                this.transform.position = new Vector3(this.transform.position.x, 0f, this.transform.position.z);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
