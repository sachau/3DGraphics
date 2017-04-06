/**
Author: Sandy Chau
Date  : Feburary 16, 2016
Description: This class takes a GameObject and changes the location
             of the object to show on screen. It handles the cylinder
*/
using UnityEngine;
using System.Collections;

public class Cylinder : MonoBehaviour {
    public void CreateCylinder(GameObject cylinder)
    {
        cylinder.transform.position = new Vector3(4, 0, 0);
    }
}
