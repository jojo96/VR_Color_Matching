# VR_Color_Matching
A simple VR experiment to do color matching

# Setup
Using Unity 2022.1.22f1
Oculus Quest 2 VR HMD

The VR setup was done following this tutorial: [How to Make a VR Game in Unity - PART 1](https://youtu.be/HhtTtvBF5bI?list=PLpEoiloH-4eP-OKItF8XNJ8y8e1asOJud&t=8)

Simple steps:

1) Edit --> Project Settings --> Install XR Plugin Management
2) Select OpenXR in the Desktop and Android tabs in the XR Plug-in Management window (OpenXR should be checked after doing this)
3) Go to the XR Plug-in Management section on the side tab and click OpenXR. In the Interaction Profiles tab, add Oculus Touch Controller Profile (for both PC and Android)
4) Now, go to Windows --> Package Manager --> Add package by name --> com.unity.xr.interaction.toolkit

# Files
The whole project can be downloaded from here: [Project files](https://kuleuven-my.sharepoint.com/:u:/g/personal/ujjayanta_bhaumik_kuleuven_be/EROJXV9BVI1DrV7l6kMW7xQB8RSkAq8PUcJp-JoPLHVtjg?e=ceossr)

I have included the assets file in this repository.

# Experimental Idea

![image](https://github.com/jojo96/VR_Color_Matching/assets/18205576/45a7e216-7913-4c42-83bf-c494df4c440c)

This is just a setup to check the integration of Oculus Quest 2 in Unity. The idea is very simple. The user needs to changed the color of the left cube to match the right. Color can be changed using the "R" or "E" key.
