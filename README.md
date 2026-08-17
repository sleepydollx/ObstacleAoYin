# ObstacleMochi

*[Lees dit in het Nederlands](README.nl.md)*

A simple 2D/3D Unity-based game where the player has to dodge falling objects (obstacles). Built as a practice project to learn collision detection, tagging systems, and basic game mechanics in Unity.

##  Features

- **Obstacle Dropping** — Objects appear and fall automatically after a set delay (`timeToWait`), using Rigidbody physics.
- **Collision Detection** — Detects collisions between obstacles and the Player, then triggers a visual reaction (color change) when an object is hit.
- **Tag-based Logic** — Uses Unity's tag system (`Player`, `AoYin`) to distinguish which objects need a response.
- **Movement & Scoring** — Includes a movement system (`Mover.cs`) and a scoring system (`Scorer.cs`) to track player progress.

##  Project Structure

```
ObstacleAoYin/
├── Assets/
│   ├── Scripts/
│   │   ├── Dropper.cs      # Handles obstacle delay & drop (gravity, mesh visibility)
│   │   ├── ObjectHit.cs    # Collision detection & color change on hit
│   │   ├── Mover.cs        # Object/Player movement logic
│   │   └── Scorer.cs       # Score tracking system
│   ├── Materials/
│   └── Scenes/
│       └── SampleScene.unity
├── Packages/
├── ProjectSettings/
└── ObstacleAoYin.slnx
```

##  Requirements

- [Unity Hub](https://unity.com/download) (latest LTS version recommended)
- Unity Editor (check `ProjectSettings/ProjectVersion.txt` after cloning for the exact version)

##  How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/sleepydollx/ObstacleAoYin.git
   ```
2. Open Unity Hub, select **Add project from disk**, and point it to the cloned folder.
3. Open `Assets/Scenes/SampleScene.unity`.
4. Press **Play** in the Unity Editor to try the game.

##  Development Notes

- Make sure every relevant GameObject (Player, obstacles) has the correct **tag** set in the Inspector (`Player`, `AoYin`, etc.), since the collision logic depends heavily on these tags.
- If the project uses **URP/HDRP**, changing a material's color at runtime requires `SetColor("_BaseColor", ...)` instead of `material.color`, otherwise the color change won't be visible.

##  Status

This project is still a work in progress / learning project.

##  License

Not yet determined.
