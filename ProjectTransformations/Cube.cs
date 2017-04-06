/**
Author: Sandy Chau
Date  : Feburary 16, 2016
Description: This class takes a GameObject and changes the location
             of the object to show on screen. It handles the cube
*/
using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
    public void CreateCube(GameObject cube)
    {
        cube.transform.position = new Vector3(0, 0, 0);
    }
}
