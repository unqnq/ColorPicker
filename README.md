
# 🎨 Unity Color Picker and Block Spawner

This Unity project implements an advanced **Color Picker** tool, allowing users to select a color using both HSV and RGB controls, as well as a hex input. Selected colors can then be applied to dynamically spawned 3D cubes in the scene.

<div align="center">
  <img src="https://github.com/user-attachments/assets/f93ae661-7a68-4dfc-a0b0-3f679da4f7fa" width="400" />
</div>

---

## 🧰 Features

-  **HSV Controls**: Interactive sliders for hue, saturation, and value.
-  **RGB Sync**: Automatically synchronized RGB sliders and input fields.
-  **Hex Input**: Enter a hex color value to instantly update the picker.
-  **Live Preview**: Real-time color updates displayed in an output panel and applied to cubes.
-  **Block Spawning**: Click to place colored cubes; right-click to remove them.
-  **ScriptableObject Integration**: Stores current color state across components using `ColorData`.

---

## 🖼️ UI Overview

- **ColorPickerControll.cs** – Main logic for color selection and synchronization.
- **SVImageControll.cs** – Handles dragging and clicking on the saturation-value square.
- **CreateDestroyBox.cs** – Enables spawning and deleting colored cubes with mouse input.
- **ColorData.cs** – ScriptableObject for storing and sharing the selected color.

---

## 📦 How to Use

1. Clone the repository and open it in Unity.
2. In the scene, find the **Color Picker UI**.
3. Adjust the color using:
   - Hue slider
   - Saturation-Value square
   - RGB sliders and inputs
   - Hex code input
4. Left-click in the scene to **spawn cubes** using the selected color.
5. Right-click on existing cubes to **delete them**.

---

## 🧩 Dependencies

This project uses Unity’s built-in components and **does not require external packages**.

---

## 🎯 Customization Tips

- 🔄 Change `boxScale` in the `CreateDestroyBox` script to spawn bigger blocks.
- 🎨 Modify `ColorData` to persist color state between sessions or scenes.

---

## 📸 Gif

<div align="center">
  <img src="https://github.com/user-attachments/assets/42be1601-cad6-4188-86bf-74f1377d29fc" width="800" />
</div>
