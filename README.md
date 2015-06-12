# MSP SpheroPilot: Sphero360
Control your Sphero 2.0 Robotic Ball with an Xbox 360 Gamepad and Windows.
![Banner] (https://github.com/Shane904/MSP_SpheroPilot--Sphero360/blob/master/githubbanner.jpg)

Info
-----
To run Sphero360, you will need to edit the line in /Sphero360/backend/sphero360backend.js that says:
```javascript
var orb = sphero("COM6");
```
Change COM6 to the port your Sphero is connected to.

Once you have edited and saved the file, turn on your Sphero and run the backend by typing this into your command prompt:
```
node sphero360backend.js
```
Now, run the Frontend by opening the "Sphero 360 Frontend.exe" located in "Sphero360/frontend/Sphero 360 Frontend/Sphero 360 Frontend/bin/Release". Once you open it, connect to the backend by clicking "Connect to Backend". You can now control your Sphero with your Xbox 360 Gamepad! The left trigger controls the speed, the left thumbstick controls turning, holding A boosts, and pressing B causes you to pull a 180.