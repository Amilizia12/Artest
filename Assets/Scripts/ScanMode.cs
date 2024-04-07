using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ScanMode : MonoBehaviour
{
    [SerializeField] ARFaceManager faceManager;

     void OnEnable()
    {
        UIController.ShowUI("Scan");
    }
  //this worls lol
    void Update()
    {
      if(faceManager.trackables.count > 0 ) {
            InteractionController.EnableMode("Main");
          }
    }
}
