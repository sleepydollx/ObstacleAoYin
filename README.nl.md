# ObstacleAoYin

*[Read this in English](README.md)*

Een eenvoudig 2D/3D-spel gebouwd in Unity waarin de speler vallende objecten (obstakels) moet ontwijken. Gemaakt als oefenproject om collision detection, het taggingsysteem en basis game mechanics in Unity te leren.

##  Functies

- **Obstakels laten vallen** — Objecten verschijnen en vallen automatisch na een ingestelde vertraging (`timeToWait`), met behulp van Rigidbody-physics.
- **Botsingsdetectie (Collision Detection)** — Detecteert botsingen tussen obstakels en de Player, en triggert vervolgens een visuele reactie (kleurverandering) wanneer een object geraakt wordt.
- **Tag-gebaseerde logica** — Gebruikt het tagsysteem van Unity (`Player`, `AoYin`) om te bepalen welke objecten een reactie nodig hebben.
- **Beweging & score** — Bevat een bewegingssysteem (`Mover.cs`) en een scoresysteem (`Scorer.cs`) om de voortgang van de speler bij te houden.

##  Projectstructuur

```
ObstacleAoYin/
├── Assets/
│   ├── Scripts/
│   │   ├── Dropper.cs      # Regelt vertraging & het laten vallen van obstakels (gravity, zichtbaarheid mesh)
│   │   ├── ObjectHit.cs    # Botsingsdetectie & kleurverandering bij een hit
│   │   ├── Mover.cs        # Bewegingslogica van object/Player
│   │   └── Scorer.cs       # Scoresysteem
│   ├── Materials/
│   └── Scenes/
│       └── SampleScene.unity
├── Packages/
├── ProjectSettings/
└── ObstacleAoYin.slnx
```

##  Vereisten

- [Unity Hub](https://unity.com/download) (nieuwste LTS-versie aanbevolen)
- Unity Editor (controleer `ProjectSettings/ProjectVersion.txt` na het clonen voor de exacte versie)

##  Hoe uit te voeren

1. Clone deze repository:
   ```bash
   git clone https://github.com/sleepydollx/ObstacleAoYin.git
   ```
2. Open Unity Hub, kies **Add project from disk**, en verwijs naar de gekloonde map.
3. Open `Assets/Scenes/SampleScene.unity`.
4. Druk op **Play** in de Unity Editor om het spel te proberen.

##  Ontwikkelnotities

- Zorg ervoor dat elk relevant GameObject (Player, obstakels) de juiste **tag** heeft ingesteld in de Inspector (`Player`, `AoYin`, enz.), aangezien de botsingslogica sterk afhankelijk is van deze tags.
- Als het project **URP/HDRP** gebruikt, moet de kleur van een material tijdens runtime worden aangepast met `SetColor("_BaseColor", ...)` in plaats van `material.color`, anders is de kleurverandering niet zichtbaar.

##  Status

Dit project is nog in ontwikkeling / een leerproject.

##  Licentie

Nog niet bepaald.
