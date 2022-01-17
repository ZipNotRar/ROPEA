using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{ 
     public Transform Player;
     public AudioClip enemyGoAway;
     public AudioSource enemyGoAwaySource;
     int MoveSpeed = 2;
     int MaxDist = 10;
     int MinDist = 5;
     private float rotationSpeed = 5;
     private OVRPlayerController opc;
    void Start()
     {
     }
 
     void Update()
     {
         transform.LookAt(Player);
         if (OVRInput. GetDown(OVRInput.Button.One, OVRInput.Controller.LTouch))
         {
             enemyGoAwaySource.Play();
         }
 
         if (Vector3.Distance(transform.position, Player.position) >= MinDist)
         {
 
             transform.position += transform.forward * MoveSpeed * Time.deltaTime;
             transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Player.position - transform.position), rotationSpeed * Time.deltaTime);
 
             if ((Vector3.Distance(transform.position, Player.position) <= MaxDist) && (enemyGoAwaySource.isPlaying == true))
             {
                 transform.position += transform.forward * 100 * Time.deltaTime;
             }
 
         }
     }
 }
