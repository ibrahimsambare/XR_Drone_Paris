# XR Drone – Paris (School Project)

## 🎥 Demo Video  
👉 Click here to watch the demo video  
https://youtu.be/h71vIgRb47g

## 📌 Project Overview

This project is a **mini immersive VR drone flight experience** developed in **Unity**, using **Cesium for Unity** to visualize a **real, georeferenced urban environment**.

The user controls a **virtual drone** and can fly freely over **Paris, France**, from a **first-person perspective**, using XR-based locomotion and custom vertical flight controls.

The main objective of this project is to explore:
- real-time **3D Tiles streaming**,
- **XR locomotion mechanics**,
- and **immersive navigation** in a large-scale real-world city.

This project was developed as part of the **Unmanned Flight XR course** and focuses on learning **Unity XR**, **Cesium integration**, and **drone-like movement behaviors**.


## 🛠️ Technologies Used

- **Unity**
- **Cesium for Unity**
- **Cesium ion**
- **XR Interaction Toolkit**
- **OpenXR**
- **C#**


## 🌍 Environment

- **City:** Paris, France  
- **Data:** Real-world 3D Tiles streamed dynamically using **Cesium ion**
- **Georeferencing:** Cesium World Terrain + Photorealistic 3D Tiles

## 🎮 Controls

### 🥽 VR Mode
- Left joystick: horizontal movement (forward, backward, strafe)
- Movement direction follows the headset orientation (camera forward)
- Right joystick (Y axis): vertical flight (ascend / descend)

### ⌨️ Keyboard Mode (Non-VR / Test Mode)
The keyboard can be used to test the drone movement without a VR headset.

- Z: Move forward
- S: Move backward
- Q: Move left
- D: Move right
- E: Ascend
- A: Descend

Mouse movement is used to control the camera orientation.


## 📁 Main Scripts

- **VerticalFlight.cs**  
  → Controls vertical drone movement using the right joystick

- **Keyboard.cs**  
  → Allows non-VR keyboard testing

- **DroneInertia.cs**  
  → Adds smooth movement, tilt, and drone-like inertia behavior


## ⚠️ Known Limitations

- Cesium tiles are streamed dynamically, causing **visible pop-in**
- Local tile caching was discovered late and is **not implemented**
- VR functionality is implemented but **not fully tested** due to limited access to VR hardware


## 🚀 Future Work

- Full VR hardware testing
- Local caching of Cesium tiles
- Improved streaming performance
- More realistic drone physics and inertia
- UI overlay (altitude, speed, minimap)


## 👥 Team

Developed as part of a **university assignment**.

- **Ibrahim Almountaka Sambare**


## 📄 License

Educational project created for **academic purposes only**.
