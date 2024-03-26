using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EditPictureMode : MonoBehaviour
{
public FramedPhoto currentPicture;
void OnEnable()
{
UIController.ShowUI("EditPicture");
}
}
