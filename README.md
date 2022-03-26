# Project ROPEA
This is an initiative by Hanze university in collaboration with two students to demonstrate how robotics can be used in ocean by 2050 to regenerate the ecosystem and prevent excessive trash being built up.
## The files presented here show the scripts that are responsible for the production of "ROPEA":-

* The [**VRRig script**](ROPEA_Unity/Assets/Scripts/VRRig.cs) creates an illusion that player is flying whereas the player is just pushed in the direction depending on the position and rotation of the VR headset. A lerp smoothens the movement whilst the vector3 derived from the headset's current position is normalized so that the lerp itself becomes more accurate.
* The [**fly script**](ROPEA_Unity/Assets/Scripts/fly.cs) was another attempt to make the player "fly" but instead of letting them move by keeping a button pressed they were using a jetpack to fly around.
* The [**AIController script**](ROPEA_Unity/Assets/Scripts/AIController.cs) directs the enemies in player's direction while using the "Slerp" technique to rotate quicker and with more accuracy. On pressing a specific button, the enemy will move away from the player that button triggers an underwater sound from player's position which repels the enemy.
* Finally, the [**PointerEvents script**](ROPEA_Unity/Assets/Scripts/PointerEvents.cs) is responsible for using an "IPointerClickHandler" which detects and executes events the player's _pointer_ is focusing on (trash for instance). This script creates an OnClick event through which the animations showing extracted molecules from the detected gameobject (trash) gets initiated.

### Additionally, there are 2 Videoclips which will give you a run-through of what to expect in the game and the internal sections of each script.
Run-Through             |  Code-Explaination
:-------------------------:|:-------------------------:
[![](http://img.youtube.com/vi/_fxo8h80w28/0.jpg)](http://www.youtube.com/watch?v=_fxo8h80w28 "Stardome - A 3D Dome Painting Experience!!") | [![](http://img.youtube.com/vi/7ikp7RgcbZM/0.jpg)](http://www.youtube.com/watch?v=7ikp7RgcbZM "StarDome - Code Explaination")
[![](http://img.youtube.com/vi/_fxo8h80w28/0.jpg)](http://www.youtube.com/watch?v=_fxo8h80w28 "Stardome - A 3D Dome Painting Experience!!") | [![](http://img.youtube.com/vi/7ikp7RgcbZM/0.jpg)](http://www.youtube.com/watch?v=7ikp7RgcbZM "StarDome - Code Explaination")
