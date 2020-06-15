# WurstMod

WurstMod is a mod for H3VR currently focusing on making it easy to create and import custom maps. Custom maps are currently limited to the Take and Hold gamemode.

## Installation

Download the most recent release and unzip into your H3VR install folder. You can easily access this folder by right clicking H3VR in your steam library, going to Properties, the Local Files tab, Browse Local Files.

If your folder looks like the image below, you're good to go. Just run the game as you normally would and load into Take And Hold. There will be arrows on the map image panel, pressing those will switch between installed maps.

![Correct folder structure](https://i.imgur.com/pmIefmr.png)

## Getting More Maps

Maps consist of a folder with three files: *leveldata*, *info.txt*, and *thumb.png*. When you download a map someone has made, put its folder into H3VR/CustomLevels/TakeAndHold and it will be selectable next time you start the game.

## Making Maps

I plan to create a video walkthrough of level creation at some point. For now, here's a wall-of-text-style tutorial of the super basic requirements.

1. You need a **specific version of Unity, Unity 5.6.3**. You can find that [Here](https://unity3d.com/get-unity/download/archive)
1. Clone or Download this repository, it contains the WurstModWorkbench Unity project.
1. Open the WurstModWorkbench project using Unity 5.6.3. The included TAHDebug scene includes a fully working level. You can use this to reference specific details of level creation.
1. Create and open a new Scene in the Assets/Scenes folder. **Delete Main Camera.**
1. From the Prefabs folder, drag in the [TNHLEVEL] prefab. This the root GameObject of your scene, **all other GameObject must be children of this GameObject.**
1. Build your level geometry. **I recommend starting a few hundred units away from the origin, or you risk overlapping the original Take and Hold map's Navmesh. I have no idea what will happen if you do.** Make sure everything has a Collider, is set to the Environment layer, and has a "P Mat" script to set its physical properties. Also, hit the "Static" checkbox for all of your level geometry, or Navmesh/Occlusion data will not work later!
1. Add the ScoreboardArea prefab somewhere (preferably unreachable.) This is where the player will be teleported at the end of the round.
1. Start adding SupplyPoint and HoldPoint prefabs. These prefabs show ghosts to indicate position, feel free to edit the positions/counts of things like barriers, targets, spawn points, etc. If you are placing something and don't see a ghost, it's probably not set up correctly! NOTE: You must have at least 2 Hold Points and at least 3 Supply Points. Hold points must also have spawnpoints for at least 9 defenders. **There may be other minimums I've not tested.**
1. Generate Navmesh data by going to Window->Navigation. On the Bake tab, you can modify various parameters. Hit bake and it will show blue on all of the areas that can be navigated by AI. Make sure everything is connected, the AI gets unhappy when there's no route.
1. Generate Occlusion data by going to Window->Occlusion Culling. The defaults are fine, just hit Bake.
1. Run H3VR/Export TNH from the menu bar to export the level. If there are no errors, it will be placed in AssetBundles/\<scene name\> in your Unity project folder.
1. Install the level by copying its folder from WurstModWorkbench/AssetBundles to H3VR/CustomLevels/TakeAndHold.
1. Add a thumb.png (roughly 16:9 aspect should be fine) to the folder for a level image.

## Contributing

Just point the solution to a few references and the environment should be good to go. These are:
- 0Harmony.dll (from H3VR/BepInEx/core)
- BepInEx.dll (from H3VR/BepInEx/core)
- UnityEngine.dll (from H3VR/h3vr_Data/Managed)
- UnityEngine.UI.dll (from H3VR/h3vr_Data/Managed)
- Assembly-CSharp.dll (from H3VR/h3vr_Data/Managed)
- UnityEditor.dll (from Unity 5.6.3 installation, \Editor\Data\Managed)

There's bits and pieces of code that could definitely use some work. If anyone actually makes a pull request, I'll take a look. 
I will not be including any other custom levels in this repository, though. You'll have to host those yourself.