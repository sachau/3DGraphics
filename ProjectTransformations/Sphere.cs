/**
Author: Sandy Chau
Date  : Feburary 16, 2016
Description: This class takes a GameObject and changes the location
             of the object to show on screen. It handles the sphere
*/
using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {
    public void CreateSphere(GameObject sphere)
    {
        sphere.transform.position = new Vector3(2, 0, 0);
    }
}

