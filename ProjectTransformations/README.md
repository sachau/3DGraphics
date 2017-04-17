Sandy Chau  
February 12, 2016  
CSS 451   

# Canonical and Procedural Modeling

## Design Description (UI/UX) and UI elements:
### Initial design
![ui](https://cloud.githubusercontent.com/assets/9274886/25075677/236d0478-22ce-11e7-9e0b-9b0259388600.png)

 
The user experience in this program would be that the program allows for the user to draw three 3D shapes by clicking on their respective buttons. There will be a panel that has all the buttons that allows the user to control the shape. There are buttons for each transformation (translate, rotate, scale, and shear). Each shape will have their own set of buttons that will perform the transformation. 
### Sphere Button
The Sphere button will draw a sphere at a location when pressed. 
### Cylinder Button 
The Cylinder button will draw a Cylinder at a location when pressed.
### Cube Button
The Cube button will draw a Cube at a location when pressed.
### Move Buttons
There are four buttons that will represent the four directions (up, down, left, right). They will be used to move the shapes along the x and y axis. 
### Forward and Backward Buttons
The forward and backwards buttons will move the shapes back and forth along the z axis.
### Scale Buttons
There are three sets of scale buttons for each of the dimensions (width, height, and depth). Each dimension will have an increase and decrease button.
### Rotation Buttons
The rotation buttons will rotate the shape along the x, y, and z axis. Another button will be the combination of all three.
### Shear Button
The shear button will shear the shape in two directions.
### Gravity On/Off Button
There are two buttons that turn the gravity on or off on the shapes.
### Procedural Modeling Button
The procedural transformation button will create an image with cubes.
### Window Screen 
The screen to show the shapes will be a set size unless the user wants to enter full screen mode. 
### Minimize Button
The minimize button will minimize the screen.
### Full Screen Button
The full screen button will make the window screen the size of the monitor.
### Exit Button
The exit button will cancel the program and close the screen. 




## Workflow Chart

![workflow](https://cloud.githubusercontent.com/assets/9274886/25075523/798e85aa-22cb-11e7-83c3-c496e88c6ea5.png)

 
At startup, the program will create all the buttons and assign a certain even to each button. The event will occur when clicked on. The event will either be drawing a shape or perform a transformation on the shapes. There are also buttons for gravity and procedural transformation. The user also has the option of minimizing, full screening, and exiting the screen. After each event, it will wait and listen to the next action except if the user clicks on the exit button. If the user clicks on the exit button, the program will end and close. 


## Results     
### Default - When program first loads

![default](https://cloud.githubusercontent.com/assets/9274886/25075609/1adbf69e-22cd-11e7-9a94-6f177c43fd33.png)

### When each shape is created
![result1](https://cloud.githubusercontent.com/assets/9274886/25075501/f5a25ad2-22ca-11e7-8a50-cfa490607920.png)

### Gravity turned off - Makes the shape float around the screen

![result_gravity](https://cloud.githubusercontent.com/assets/9274886/25075628/63a61e9a-22cd-11e7-920d-7128815c6dad.png)

### Gravity turned off and shapes are tranformed 
![result2](https://cloud.githubusercontent.com/assets/9274886/25075632/651d794e-22cd-11e7-8438-4aed8bf38371.png)


### Procedural Transformation 

![pt](https://cloud.githubusercontent.com/assets/9274886/25075633/745cc0c2-22cd-11e7-9a0c-846a41bc49fe.png)
