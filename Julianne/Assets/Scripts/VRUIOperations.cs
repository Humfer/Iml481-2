using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRUIOperations : MonoBehaviour
{
    public UnityEvent onEnter;
    public UnityEvent onExit;

    private void OnTriggerEnter(Collider other)
    {
        TrigExit.instance.currentCollider = GetComponent<VRUIOperations>();
        onEnter.Invoke();
    }
}
