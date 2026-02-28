<img width="665" height="513" alt="image" src="https://github.com/user-attachments/assets/0bf0a381-d039-45a4-aab8-68fbc2ef1c64" />

 # 3D Platformer – Go Robot!
 ##  About
A 3D platformer where a robot jumps across obstacles, collects coins, defeats enemy robots, and reaches the diamond to complete the level.


##  Features
- Smooth player movement and jumping mechanics  
- Collectible coin system  
- Enemy robots with basic Hit action  
- Level goal system (reach the diamond)  
- Clean 3D environment  


###  Built With: Unity, C#  

---
###  How to Play
Move: Use WASD or Arrow Keys to navigate the platforms.
Jump: Use Spacebar to leap over obstacles or avoid falling.
Attack: Press Left Click to shoot at enemy robots.
Collect: Gather coins scattered throughout the map.
Win: Reach the Diamond at the end of the level to finish!

---
## Project Structure
Assets/

├── 3DModels/      # Robot, environment, and animation assets

├── Materials/     # Shaders and textures

├── Scenes/        # Unity scene files for levels and UI layouts

├── Scripts/       # Core game logic in C#

└── UI/            # UI elements, panels.
### Key Scripts
- `PlayerMovement.cs` – Handles player input, gravity, and jumping physics
- `Shooting.cs` – Manages firing rate and projectile spawning
- `Bullet.cs` – Controls projectile trajectory and enemy collisions
- `Enemy.cs` – Enemy AI and hit-reaction logic
- `GameRespawn.cs` – Resets the level if the player falls or Kkilled by enemy
---
### Notes
This project emphasizes core platformer mechanics and gameplay systems. It was developed as part of the Game Development Bootcamp in Unity.


##  Author
**Kadi**
