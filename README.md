

# ❌ Tic-Tac-Toe Engine | C# WinForms ⭕

An interactive Tic-Tac-Toe game built with a robust architecture that emphasizes game logic separation, custom graphics rendering, and a seamless user experience.

---

## 📸 Preview

<p align="center">

  <img src="https://github.com/user-attachments/assets/902b7cf8-90c2-4e6c-85ca-1716fd831bd1" width="400" alt="Game Interface"/> 
  <img src="https://github.com/user-attachments/assets/95112089-d712-4197-88a4-2346e29b2dac" width="400" alt="Development Environment"/>

</p>

---

## 🛠 Technical Highlights

This project goes beyond a basic "X-O" script by implementing core software engineering principles:

*   **Custom GDI+ Rendering**: Utilizes the `System.Drawing` library and `Paint` events to manually render the game grid, ensuring a sharp and customizable UI.
*   **Coordinate Mapping**: Implements a mapping system that translates UI element `Tag` properties into 2D array coordinates ($row = index / 3$, $col = index \% 3$) for efficient state management.
*   **Decoupled Logic**: The win-check algorithm is isolated into a dedicated `winner()` method that evaluates rows, columns, and diagonals immediately after each valid move.
*   **Dynamic State Management**: Features real-time turn tracking, win-cell highlighting using the `params` keyword for code reusability, and draw-detection logic.
*   **Cross-Form Data Passing**: Leverages custom constructors to transfer player data from the entry screen to the main game engine.

---

## 🚀 Key Features

1.  **Strict Turn Validation**: Prevents overwriting occupied cells and disables input once a game state (Win/Draw) is reached.
2.  **Resource Management**: Efficiently handles external assets (X and O icons) via local project resources.
3.  **Real-Time Feedback**: Updates player turns and game status dynamically through UI labels.
4.  **Reset Mechanism**: Completely re-initializes the 2D array and UI components without requiring a full application restart.

---

## 📂 Project Structure

*   **`Form1.cs`**: The entry point responsible for user input and game initialization.
*   **`gameFrm.cs`**: The core engine containing the game loop, rendering logic, and win-condition calculations.

---

## 🏗️ Logic Implementation

The game state is tracked using a 2D integer array `int[3, 3]`:
*   `0`: Empty Cell
*   `1`: Player 1 (X)
*   `2`: Player 2 (O)
```csharp
// Example of how UI interaction maps to logic
int cellIndex = int.Parse(pb.Tag.ToString());
int row = cellIndex / 3;
int col = cellIndex % 3;
//
```
## 👤 About Me
**Dima** – IT Engineering Student at the University of Homs.  
Focused on high-performance software development, C#/.NET architecture, and UI/UX design.

---
