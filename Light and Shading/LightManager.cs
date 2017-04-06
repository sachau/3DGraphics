/**
Author: Sandy Chau
Date  : March 1, 2016
Description: This class takes handles the lighting in the program.
*/
using UnityEngine;
using System.Collections;

public class LightManager : MonoBehaviour {

    public Light LightSource;

    /*
        Sets the lighting on or off by changing intensity level
    */
	public void LightToggle(bool tog)
    {
        if(tog == false)
        { 
            LightSource.intensity = 0;
        }
        else if (tog == true)
        {
            LightSource.intensity = 3;
        }
    }

    /*
        Gets the location of the shape so that the point light can
        be set in the middle of the sphere 
    */
    public void PointLocation(GameObject shape)
    {
        float x = shape.transform.position.x;
        float y = shape.transform.position.y;
        float z = shape.transform.position.z;
        LightSource.transform.position = new Vector3(x,y,z);

    }

    /*
        Gets the location of the shape so that the spotlight can
        be set on top of the sphere
    */
    public void location(GameObject shape)
    {
        float x = shape.transform.position.x;
        float y = shape.transform.position.y + 2;
        float z = shape.transform.position.z;
        LightSource.transform.position = new Vector3(x, y, z);

    }



}
