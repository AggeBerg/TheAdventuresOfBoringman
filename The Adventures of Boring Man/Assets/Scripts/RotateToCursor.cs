using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCursor : MonoBehaviour
{
 public Vector3 mouse_pos;
 public Transform target; //Assign to the object you want to rotate
 public Vector3 object_pos;
 public float angle;
 
 void Update () {
         //rotation
         Vector3 mousePos = Input.mousePosition;
         mousePos.z = 5.23f;
 
         Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
         mousePos.x = mousePos.x - objectPos.x;
         mousePos.y = mousePos.y - objectPos.y;
 
         float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg + 3;
         transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
     }
 }
