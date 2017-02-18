# CandyBarMod

## About

This is an official example mod implementing [OmniAPI](https://github.com/helion3/OmniAPI). It adds a new "Candy Bar" item to the Helion3 game (Untitled Game).

This repo consists of the Visual Studio/MonoDevelop project files for two C# classes, the built DLL, exported Unity asset bundle containing a single sprite, and the original sprite for reference.

## Technical Summary

There are two C# files:

- `CandyBarMod.cs` - Our main mod file, responsible for registering the mod and communicating with the game.
- `CandyBarItem.cs` - An item class representing the new candy bar item.

Each file is commented extensively in-line to help explain how it works.

The sprite was exported to an asset bundle using a new Unity project. Those files aren't currently included here.

## Try It

This repo contains the final exported files in the `Mods` folder. You may copy the `CandyBarMod` folder to your games `Mods` directory and it will work!

