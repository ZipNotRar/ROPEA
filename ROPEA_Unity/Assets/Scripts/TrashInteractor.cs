using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class TrashInteractor : MonoBehaviour
{
    public UnityEvent unityEvent;
    private void OnTriggerEnter(Collider other) {
        if (other.name == "Cube")
        {
            Debug.Log("detection");
        }
    }
}
