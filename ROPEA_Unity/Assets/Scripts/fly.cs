using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    public GameObject head;
    public GameObject leftHand;
    public float flyingSpeed;
    private bool isFlying = false;
    public OVRPlayerController playerController;
    // Update is called once per frame
    private void Start() {
        playerController.GetComponent<PlayerController>();
    }
    void Update()
    {
        CheckIfFlying();
        FlyIfFlying();
    }
    private void CheckIfFlying()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            isFlying = true;
            playerController.GravityModifier = 0;          
        }
        if (OVRInput.GetUp(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            isFlying = false;
            playerController.GravityModifier = .2f;       
        }
    }
    private void FlyIfFlying()
    {
        if (isFlying)
        {
            Vector3 flyDirection = leftHand.transform.position - head.transform.position;
            transform.position += flyDirection.normalized * flyingSpeed * Time.deltaTime;
        }
    }
}
