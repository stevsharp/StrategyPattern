# Strategy Pattern Example

This repository contains a simple C# implementation of the Strategy Pattern.

## Overview

The Strategy Pattern is a behavioral design pattern that enables selecting an algorithm at runtime from a family of algorithms. It defines a family of algorithms, encapsulates each one of them, and makes them interchangeable. By using the Strategy Pattern, the algorithm can vary independently from the client that uses it.
A client can select an algorithm from a set of algorithms dynamically at runtime. This
pattern also provides a simple way to use the selected algorithm.
You know that an object can have states and behaviors. And some of these behaviors
may vary among the objects of a class. This pattern focuses on the changing behaviors
that can be associated with an object at a specific time.

In this example, we demonstrate the Strategy Pattern by implementing a discount system for a customer based on their total sales amount. The discount strategies vary based on predefined thresholds of total sales amounts.

## Implementation

- `IDiscountStrategy`: Interface defining the strategy for applying discounts.
- `NoDiscountStrategy`, `LowDiscountStrategy`, `MediumDiscountStrategy`, `HighDiscountStrategy`: Concrete implementations of the discount strategies.
- `CustomerDiscountContext`: Context class that uses the selected discount strategy to apply discounts based on the total sales amount.
- `Program.cs`: Main program demonstrating how to use the Strategy Pattern to apply discounts.

## How to Use

# 1. Clone the repository:

```bash
# git clone https://github.com/stevsharp/StrategyPattern.git

# 2 .Open the solution in your preferred C# IDE.
Run the program and observe the output, which demonstrates different discount strategies applied based on the total sales amount.
Contributing
Contributions are welcome! If you find any issues or have suggestions for improvements, feel free to open an issue or create a pull request.

# License
This project is licensed under the MIT License - see the LICENSE file for details.
