/**
Author: Sandy Chau
Date  : Feburary 16, 2016
Description: This class takes handles all the transformation of the 
             GameObject that is passed in. It can translate, scale, rotate,
             and shear the GameObject. 
*/
using UnityEngine;
using System.Collections;

public class TouchManager : MonoBehaviour {
    /**
    *   Roates the shape in all three directions.
    */      
    public void RotateShape(GameObject shape)
    {
        shape.transform.Rotate(3F, 3F, 3F, Space.Self);   
    }

    /**
    *   Roates the shape along the x-axis.
    */
    public void RotateXShape(GameObject shape)
    {
        shape.transform.Rotate(3F, 0, 0, Space.Self);
    }
    /**
    *   Roates the shape along the y-axis.
    */
    public void RotateYShape(GameObject shape)
    {
        shape.transform.Rotate(0, 3F, 0, Space.Self);
    }
    /**
    *   Roates the shape along the z-axis.
    */
    public void RotateZShape(GameObject shape)
    {
        shape.transform.Rotate(0, 0, 3F, Space.Self);
    }
    /**
    *   Moves the shape along the z axis. Would move the shape "back".
    */
    public void MoveShapeBack(GameObject shape)
    {
        shape.transform.position = new Vector3(shape.transform.position.x,
            shape.transform.position.y, shape.transform.position.z + 0.5F);
    }
    /**
   *   Moves the shape along the z axis. Would move the shape "front".
   */
    public void MoveShapeFront(GameObject shape)
    {
        shape.transform.position = new Vector3(shape.transform.position.x,
            shape.transform.position.y, shape.transform.position.z - 0.5F);
    }
    /**
   *   Moves the shape along the y axis. Would move the shape up
   */
    public void MoveShapeUp(GameObject shape)
    {
        shape.transform.position = new Vector3(shape.transform.position.x, 
            shape.transform.position.y + 0.5F, shape.transform.position.z);
    }
    /**
    *   Moves the shape along the z axis. Would move the shape down
    */
    public void MoveShapeDown(GameObject shape)
    {
        shape.transform.position = new Vector3(shape.transform.position.x, 
            shape.transform.position.y - 0.5F, shape.transform.position.z);
    }
    /**
    *   Moves the shape along the x and to the left.
    */
    public void MoveShapeLeft(GameObject shape)
    {
        shape.transform.position = new Vector3(shape.transform.position.x - 0.5F,
            shape.transform.position.y, shape.transform.position.z);
    }
    /**
    *   Moves the shape along the x and to the right.
    */
    public void MoveShapeRight(GameObject shape)
    {
        shape.transform.position = new Vector3(shape.transform.position.x + 0.5F,
            shape.transform.position.y, shape.transform.position.z);
    }
    /**
    *   Scales the shape to increase the width.
    */
    public void WidthShapeIncrease(GameObject shape)
    {
        shape.transform.localScale += new Vector3(0.1F,0,0);
    }
    /**
    *   Scales the shape to decrease the width.
    */
    public void WidthShapeDecrease(GameObject shape)
    {
        shape.transform.localScale += new Vector3(-0.1F, 0, 0);
    }
    /**
    *   Scales the shape to increase the height.
    */
    public void HeightShapeIncrease(GameObject shape)
    {
        shape.transform.localScale += new Vector3(0, 0.1F, 0);
    }
    /**
    *   Scales the shape to decrease the height.
    */
    public void HeightShapeDecrease(GameObject shape)
    {
        shape.transform.localScale += new Vector3(0, -0.1F, 0);
    }
    /**
    *   Scales the shape to increase the depth.
    */
    public void DepthShapeIncrease(GameObject shape)
    {
        shape.transform.localScale += new Vector3(0, 0, 0.1F);
    }
    /**
    *   Scales the shape to decrease the depth.
    */
    public void DepthShapeDecrease(GameObject shape)
    {
        shape.transform.localScale += new Vector3(0, 0, -0.1F);
    }
    /**
    *   Shears the object by first roatating the child and then scaling
    *   the parent object. It then creates a new parent and puts the child
    *   in the second parent. Then it roates the child and scales the new parent.
    */
    public void ShearShape(GameObject shape)
    {      
        //First rotate and scale to shear in one direction
        shape.transform.position = new Vector3(0, 0, 0);
        shape.transform.Rotate(0, 0, shape.transform.rotation.z + 45);
        GameObject newParent = new GameObject();
        shape.transform.parent = newParent.transform;
        newParent.transform.localScale += new Vector3(1F, 0, 0);
        newParent.transform.Rotate(0, 0, shape.transform.rotation.z + 45);
        newParent.transform.Rotate(0, shape.transform.rotation.y + 50, 0);

        //Second rotate and scale in another direction
        GameObject secondParent = new GameObject();
        newParent.transform.parent = secondParent.transform;
        secondParent.transform.localScale += new Vector3(0, 1F, 0);
    }
    /**
   *   Turns on the gravity for each GameObject
   */
    public void TurnOnGravity(GameObject shape)
    {
       Collider other = shape.GetComponent<Collider>();
        other.attachedRigidbody.useGravity = true;
    }
    /**
   *   Turns on the gravity for each GameObject
   */
    public void TurnOffGravity(GameObject shape)
    {
        Collider other = shape.GetComponent<Collider>();
        other.attachedRigidbody.useGravity = false;
    }
}
