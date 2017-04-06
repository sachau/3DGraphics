/**
Author: Sandy Chau
Date  : Feburary 16, 2016
Description: This class takes a cube and turns it into a plane
             this makes it so that GameOjects do not fall out 
             of the screen
*/
using UnityEngine;
using System.Collections;

public class Plane : MonoBehaviour {
    public GameObject plane;
    void Start () {        
        plane.transform.position = new Vector3(2, -3, 0);
        plane.transform.localScale += new Vector3(10, 0, 0);        
    }	
}
