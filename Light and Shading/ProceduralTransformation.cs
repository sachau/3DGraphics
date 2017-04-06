/**
Author: Sandy Chau
Date  : Feburary 16, 2016
Description: This class performs a procedural transformation when called. It creates a number of GameObject 
             with recursion and transformation. 
*/
using UnityEngine;
using System.Collections;

public class ProceduralTransformation : MonoBehaviour {

    public GameObject gameShape;
    private float x;
    private float y;
    private float z;

    /**
    *   Method to be called to invoke the procedural transformation. 
    */
	public void procedural(GameObject shape)
    {

        gameShape = shape;
        gameShape.transform.position = new Vector3(0, 0, 0);
        x = gameShape.transform.position.x;
        y = gameShape.transform.position.y;
        z = gameShape.transform.position.z;
        
        proceduralHelper(gameShape, 50);
    }

    /*
    *   Helper function that will do recursion to see how many GameObjects to make.
    */ 
    private int proceduralHelper(GameObject shape, int count)
    {
        
         if (count > 0)
         {            
            GameObject newShape = Instantiate(shape, new Vector3(x + .5F, y + .5F, z + .5F), shape.transform.rotation) as GameObject;
            x = newShape.transform.position.x;
            y = newShape.transform.position.y;
            z = newShape.transform.position.z;
            newShape.transform.Rotate(0, 0, 25F, Space.Self);

            return proceduralHelper(newShape, count -1);            
        }
        else
        {
            return 0; 
        }
    }
}
