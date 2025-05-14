# Amaze  

## Overview  
Amaze is a single-player maze-based FPS where players navigate interconnected sub-mazes, retrieve a key and reach the main maze exit to complete the level. Players use mini-maps for guidance while surviving enemy encounters.  

## Gameplay Mechanics  

### Player Abilities  
- **Move in four directions**—forward, backward, left, and right.  
- **Shoot projectiles** to eliminate threats.  
- **Collect health and ammo pickups** for survival.  
- **Use mouse-look** for precision aiming.  

### Enemy Spawner  
- Generates a **fixed number of enemies** with a **timed delay** between spawns.  
- **Automatically stops spawning** after reaching the set enemy limit.  

## UI & HUD Components  

### UI Elements  
- **Ammo Count:** Displays magazine ammo and total reserves.  
- **Health Bar:** Shows player health percentage.  
- **Collectable Status:** Tracks the key required for level completion.  

### Mini-Map System  
- **Sub Maze (Top Left):** Displays player position without revealing the key's location, promoting exploration.  
- **Main Maze (Bottom Right):** Shows player position and marks the key’s location, aiding navigation.  

## Menus  
- **Game Over Screen:** Provides options to retry the level or quit.  
- **Main Menu:** Allows players to start the game or exit.  
- **How to Play Screen:** Displays essential gameplay information, including movement controls, shooting mechanics and objective details.

## Technical Information  

### Development Environment & Tools  
- **Visual Studio Community 2022:** Scripting.  
- **Visual Studio Code:** Documentation.  
- **Unity 2023.2.20f1:** Game engine.  
- **Unity Hub 3.11.1:** Tool for managing Unity projects, versions and dependencies.  
- **Git 2.45.1.windows.1:** Version control system for managing code changes and tracking project history.  
- **GitHub:** Remote repository platform for hosting code, tracking changes and enabling collaboration with contributors.  

### Platforms & Assets  
| **Platform**    | **Choice** | **Justification**                                                                               |
|-----------------|------------|-------------------------------------------------------------------------------------------------|
| **Development** | Unity      | Cross-platform support, beginner-friendly tools, strong asset ecosystem, optimized performance. |
| **Release**     | PC         | Wide market reach, scalable performance options, strong distribution channels.                  |

## Installation & Setup  

### System Requirements  
Refer to [Unity System Requirements](https://docs.unity3d.com/6000.0/Documentation/Manual/system-requirements.html) to meet the minimum and recommended specifications.  

### Project Setup Instructions  

#### 1. Clone Repository  
```bash
git clone https://github.com/Learner062022/Amaze.git
cd Amaze
```

#### 2. Install Dependencies
Ensure required dependencies are installed before running the project.

- **Unity Packages:**
  - Open **Unity Hub** and navigate to the cloned directory.
  - Install required Unity packages via **Package Manager**.

- **Scripting Dependencies:**
  - If Python scripts are included, run:
    ```bash
    pip install -r requirements.txt
    ```
- **Additional Frameworks:**
  - Verify that all required plugins, assets or SDKs are installed within Unity.
  - Ensure external libraries are properly linked in the project settings. 

## Running the Project  

### Development Mode  
To run the game in development mode:  
- Open the project in **Unity Hub**.  
- Click **Play** within the Unity Editor to start.  
- Monitor debug logs using `Debug.Log()` for tracking events.  
- Use the **Profiler** to monitor game performance.  

### Production Mode  
To build and run the project as an executable:  
- Open **File -> Build Settings** in Unity.  
- Select **PC, Mac & Linux Standalone**, then choose Windows as the target platform.  
- Click **Build and Run** to generate the final executable.  
- Package `Amaze.exe` along with necessary dependencies for distribution.  

## Version Control & CI/CD  

### Git Branching Model  
Refer to [Atlassian's Git Branching Model](https://www.atlassian.com/git/tutorials/comparing-workflows) for best practices on managing branches effectively.  

### Commit Message Format  
Follow the [Conventional Commit Guidelines](https://www.conventionalcommits.org/en/v1.0.0/) to maintain a structured commit history.  

### CI/CD Pipeline Integration  
For best practices on continuous integration and deployment, refer to [CI/CD Guidelines](https://www.redhat.com/en/topics/devops/what-is-ci-cd).  

## Testing & Quality Assurance  

### Overview  
This project follows **Test-Driven Development (TDD)** principles to maintain stability and functionality. Testing is conducted in **Unity Play Mode** using the **Microsoft Unit Test Framework**, ensuring key gameplay mechanics work as expected.

### Approach
- **Playtesting & Peer Reviews:** Players test the prototype and provide structured feedback, highlighting functionality, gameplay experience and UI clarity.
- **Bug Tracking:** Issues are logged, prioritized and addressed systematically, with fixes recorded for transparency.
- **GUI Focus Testing:** A dedicated session evaluates UI stability, ensuring clear navigation and intuitive design.
- **Documentation & Improvements:** Findings are recorded in structured reports, guiding iterative refinements.

### Further Resources  
For detailed test cases, bug resolutions and peer review insights, refer to:  
- [TestingProcessReport.md](./TestingProcessReport.md)  