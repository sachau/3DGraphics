Sandy Chau  
February 12, 2016  
CSS 451   
# Transparency, Shading, and Lighting 
## Design Description (UI/UX) and UI elements:
 ![design](https://cloud.githubusercontent.com/assets/9274886/25076119/f28d52a4-22d2-11e7-98ca-0fb4ac188124.png)
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
### Lights Toggles
The light toggles will turn on or off the lights. There are three different kinds: Directional, Point, and Spotlight
### Transparency Button
The transparency button will cause the shapes to become transparent with 3 options. 0.3, 0.6, and 1 alpha levels. 
### Window Screen 
The screen to show the shapes will be a set size unless the user wants to enter full screen mode. 
### Minimize Button
The minimize button will minimize the screen.
### Full Screen Button
The full screen button will make the window screen the size of the monitor.
### Exit Button
The exit button will cancel the program and close the screen. 
## Workflow Chart
![workflow](https://cloud.githubusercontent.com/assets/9274886/25076121/f5a46482-22d2-11e7-9b6b-5c7f99b588a6.png)

 
At startup, the program will create all the buttons and assign a certain even to each button. The event will occur when clicked on. The event will either be drawing a shape or perform a transformation on the shapes. There are also buttons for gravity and procedural transformation. One version of the program will allow for shapes to become transparent. Another version will allow for lighting and include shading. The user also has the option of minimizing, full screening, and exiting the screen. After each event, it will wait and listen to the next action except if the user clicks on the exit button. If the user clicks on the exit button, the program will end and close. 

## Results 
### Gouraud shading – Only on the Cube
#### Dark
 ![gouraud shading - dark](https://cloud.githubusercontent.com/assets/9274886/25076165/42295eca-22d3-11e7-96c5-22134ec70cdc.png)
#### Light
 ![gouraud shading - light](https://cloud.githubusercontent.com/assets/9274886/25076166/422b0216-22d3-11e7-9ba1-2057f46b1bc6.png)

### Phong Shading on all shapes 
#### Dark
 ![phong shading - dark](https://cloud.githubusercontent.com/assets/9274886/25076151/24c4abc8-22d3-11e7-91cb-c88ed8a7b409.png)
#### Light
![phong shading -light](https://cloud.githubusercontent.com/assets/9274886/25076150/24c48d82-22d3-11e7-9bcd-663ed80f10cd.png)
### Transparency
![transparent](https://cloud.githubusercontent.com/assets/9274886/25076156/34c5306a-22d3-11e7-8c88-579161d85040.png)

## Different types of light
### Directional light
![directional light](https://cloud.githubusercontent.com/assets/9274886/25076221/89d43b32-22d3-11e7-8027-840448b30251.png)
### Locations of lights
![location of lights](https://cloud.githubusercontent.com/assets/9274886/25076224/89d89efc-22d3-11e7-8646-113f6b6c77a5.png)
### Point light
![point light](https://cloud.githubusercontent.com/assets/9274886/25076223/89d7171c-22d3-11e7-9d14-dcd589e33b0e.png)
### Spotlight
![spotlight](https://cloud.githubusercontent.com/assets/9274886/25076222/89d4eff0-22d3-11e7-8884-8b8c39feaf64.png)

## Comparison between Gouraud and Phong 
In my program, cube uses gouraud shading (per-vertex lighting) while the sphere and cylinder uses phong shading (per-pixel lighting). With the gouraud shading, the reflection of the light is more spread out while in the Phong shading, the exact location of the light source can be located.  The colors on the phong shading is also more vibrant. In the gouraud shading, it seems to more blended and there is less of a difference in shade while in the phong shading there is a clear distinction between the dark and light parts. The two shadings are similar in that it shows a spot where it is brighter than most, the light source, but gouraud shading picks this point depending on a vertex while phong picks a pixel. This allows the phong shading to allow more obvious changes in shades and lighting 
