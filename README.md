# RollABall

## How to install

1] clones the project
  ```sh
git clone https://github.com/yassirH9/Unity_RollABall
  ```
2] open unity hub

3] add project from disk

4] search the project directory and add

5] open project in unity hub

6] press play in unity editor

## Software used

- Unity
- Blender
- Visual Studio 2022

## Asset authoring

- Music
  - [NCS](https://www.youtube.com/@NoCopyrightSounds)
  - Music provided by NoCopyrightSounds.
  - Free Download / Stream: http://ncs.io/
- Textures
  - [Freepik](https://www.freepik.es/)

# 20% Extra

- Use of Blender to make all blends and textures
- Hammer rotation math formula to rotate from bottom part

        float xRotation = Mathf.Sin(Time.time * rotationSpeed) * 90;
        transform.localRotation = Quaternion.Euler(0, 0, xRotation);
