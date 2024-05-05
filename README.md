# Strategy Pattern Example

This repository contains a simple C# implementation of the Strategy Pattern.

## Overview

The Strategy Pattern is a behavioral design pattern that enables selecting an algorithm at runtime from a family of algorithms. It defines a family of algorithms, encapsulates each one of them, and makes them interchangeable. By using the Strategy Pattern, the algorithm can vary independently from the client that uses it.

In this example, we demonstrate the Strategy Pattern by implementing a discount system for a customer based on their total sales amount. The discount strategies vary based on predefined thresholds of total sales amounts.

## Implementation

- `IDiscountStrategy`: Interface defining the strategy for applying discounts.
- `NoDiscountStrategy`, `LowDiscountStrategy`, `MediumDiscountStrategy`, `HighDiscountStrategy`: Concrete implementations of the discount strategies.
- `CustomerDiscountContext`: Context class that uses the selected discount strategy to apply discounts based on the total sales amount.
- `Program.cs`: Main program demonstrating how to use the Strategy Pattern to apply discounts.

## How to Use

1. Clone the repository:
