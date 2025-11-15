# Physics & Stochastic Simulations in C#

This repository presents a collection of interactive physics and stochastic simulations implemented in C# (Windows Forms). Each simulation visualizes fundamental physical phenomena — combining mathematical modeling, numerical methods, and computer graphics.

[Main Class File](https://github.com/FatimaIjazOfficial/Computational-Physics_Simulations-2/blob/master/CPS/Form1.cs)

All projects have been designed for educational and demonstrative purposes, helping learners visualize equations, understand physical laws, and explore stochastic and numerical techniques.

---

## 🔬 Project List

### Potential Field Simulation

Models the steady-state potential distribution over a 2D grid using Laplace's equation. Useful for electrostatics, heat flow, and fluid velocity potential.

Discrete update equation:
V[i, j] = 1/4 * (V[i+1, j] + V[i-1, j] + V[i, j+1] + V[i, j-1])

Highlights:

* Boundary potentials are fixed; interior points iteratively updated
* Smooth harmonic field forms between boundaries
* Equilibrium achieved when changes become negligible

---

### Random Number Simulations

Generates pseudo-random integers and floating-point numbers to study distributions and randomness.

Conceptual formulas:
Integer in range [a, b): RandomNumber = a + NextInteger(0, b-a)
Floating-point in range [a, b): RandomNumber = a + NextDouble() * (b - a)

Highlights:

* Integers and floats generated in expected ranges
* Distribution checks for uniformity
* Visualization of random points on a grid
* Deterministic sequences using fixed seeds for reproducibility

---

### Random Walk Simulator (Stochastic)

Simulates 1D and 2D random walks for single or multiple walkers.

1D Random Walk:
x_i+1 = x_i + Δx_i
Δx_i = +1 with probability 1/2, -1 with probability 1/2

2D Random Walk:
x_i+1 = x_i + Δx_i
y_i+1 = y_i + Δy_i
Δx_i, Δy_i chosen randomly according to probabilities for up, down, left, right

For multiple walkers, calculates:
Mean Squared Displacement (MSD) ⟨x²⟩ or ⟨r²⟩
Root Mean Square (RMS) = sqrt(⟨x²⟩) or sqrt(⟨r²⟩)

Highlights:

* Single walker trajectories are jagged and unpredictable
* Ensemble averages show predictable diffusion patterns
* Real-time visualization of walker paths

---

### Self-Avoiding Walk Simulator (Constrained Stochastic Motion)

Simulates a self-avoiding random walk (SAW) on a grid where the walker cannot revisit a previously occupied cell. Models polymer chains, pathfinding, and constrained diffusion.

Position Update:
(x_i+1, y_i+1) = (x_i, y_i) + Δr_i
Δr_i = (+1, 0) or (-1, 0) or (0, +1) or (0, -1) if cell unvisited

Dead-end Handling:
If no valid moves, backtrack one step:
(x_i, y_i) ← (x_i-1, y_i-1)

Highlights:

* Paths are longer and stretched compared to normal random walks
* Backtracking prevents deadlocks
* Gradient visualization shows walk progression
* Demonstrates constrained stochastic motion and memory effects

---

## ⚙️ Numerical Techniques Used

* Iterative Grid Updates (for Laplace equation)
* Pseudo-Random Number Generation
* Random Walk & Self-Avoiding Walk Algorithms
* Mean Squared Displacement and Root Mean Square Calculations
* Dead-End Handling & Backtracking

---

## 🧮 Technologies

* **Language:** C#
* **Framework:** .NET (Windows Forms)
* **Graphics:** GDI+ (System.Drawing)
* **Environment:** Visual Studio

---

## 🧠 Educational Purpose

These simulations bridge mathematical equations, stochastic processes, and visual representation, enabling a deeper conceptual understanding of:

* Steady-state physical systems (electrostatics, heat flow)
* Randomness and pseudo-random number generation
* Diffusion and statistical behavior of stochastic processes
* Constrained motion and self-avoiding paths

---

## 🔗 Website Reference

Detailed write-ups and visual demonstrations: [Fatima Ijaz C# Projects](https://sites.google.com/view/fatima-ijaz/c-projects)

---

## 📜 Author

**Fatima Ijaz**
BS in Computational Physics — University of the Punjab
Focused on Computational Physics and Scientific Simulations
Certified: 100 Days of Code – The Complete Python Pro Bootcamp by Dr. Angela Yu
