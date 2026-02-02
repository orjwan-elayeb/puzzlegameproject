<div align="center">

# 📘 PuzzleGameProject  
### 🧩 Classic Sliding Puzzle Game – C# WinForms  

</div>

---

## ✨ Overview

**PuzzleGameProject** is a **Windows Forms application** built using **C# (.NET Framework)**.  
It recreates the classic **sliding image puzzle game**, where players must rearrange shuffled image tiles  
to restore the original image before the timer runs out ⏱️.

---

## 🎮 Features

- 🧩 **3×3 Sliding Puzzle Board**
- 🖼️ **Multiple Image Themes**
  - Cozy Cat 🐱  
  - Happy Cat 😸  
  - Beach Day 🏖️
- ⏱️ **Timer & Stopwatch System**
- 🏆 **Win / Lose Screens**
- 📖 **Intro & Info Screen**
- 🔄 **Shuffle & Restart Anytime**
- 🪟 **Borderless Forms with Drag Support**
- ✨ **Hover & Zoom Animations**

---

## 🗂️ Project Structure

```text
PuzzleGameProject/
│
├─ Forms/
│  ├─ FrmStart.cs
│  ├─ FrmChosePic.cs
│  ├─ FrmMain.cs
│  ├─ FrmWin.cs
│  ├─ FrmLose.cs
│  └─ FrmIntro.cs
│
├─ Resources/
│  ├─ CozyCat
│  ├─ HappyCat
│  ├─ BeachDay
│  
├─ Program.cs
└─ App.config
```
---

## ▶️ How to Play

1. Launch the application  
2. Click **Start**  
3. Choose a puzzle image  
4. Rearrange the tiles by clicking on them  
5. Solve the puzzle **before 10 minutes** ⏳  

### 🎯 Game Result

- ✔️ **Solved** → Win Screen 🏆  
- ❌ **Time Over** → Lose Screen 💔  

---

## ⚙️ Technical Highlights

- 🏷️ **PictureBox.Tag** used for tile position tracking  
- 🔁 **Valid-move-only swap logic**  
- 🔀 **LINQ-based shuffle algorithm**  
- ⏱️ **Stopwatch** for accurate time measurement  
- 🧱 **Separate Forms** for each game state  

---

## 🛠️ Requirements

- 💻 **Visual Studio 2022 or later**
- 🧩 **.NET Framework 4.7.2 or later**
- 🪟 **Windows Operating System**

---

## 🚀 Future Improvements

- 🔢 Difficulty levels (**4×4**, **5×5**)  
- 💾 Save scores and progress  
- 🖼️ Custom player images  
- 🔊 Sound effects and background music  

---

## 📄 License

This project is intended for **educational and portfolio purposes**.  
You are free to use, modify, and learn from it.

---

<div align="center">

✨ **Built with C# and WinForms** ✨  

</div>
