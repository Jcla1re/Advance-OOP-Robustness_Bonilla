# Advance-OOP-Robustness_Bonilla
Prelim Activity 02: Advanced Object-Oriented Programming and Robustness

by: Jasmin Claire C. Bonilla


Project Overview

This project is a Fleet Management System developed for a C# Console Application. The goal of the application is to calculate the remaining travel range for different types of transit vehicles (Electric Buses and Gas-Powered Vans) while ensuring system robustness through strict data validation and exception handling.

The project demonstrates the transition from basic coding to Software Architecture by implementing the four pillars of Object-Oriented Programming (OOP).

Features

Dynamic Input: Users can interactively input vehicle IDs, model names, and energy levels.
Automated Range Calculation: Different mathematical logic for Battery (%) vs. Fuel (Liters).
Safety Alerts: Automated system exceptions if energy levels drop below a 5% safety threshold.
Input Protection: Prevents the entry of negative values or invalid characters.

OOP Architecture

This activity implements the following concepts:
Inheritance: A base class Vehicle handles shared properties like TravelID and UnitName, which are inherited by ElectricBus and GasPoweredVan.
Encapsulation: All fields are private. Data access is managed through Public Properties with set accessors that validate input.
Polymorphism: The CalculateRange() method is virtual in the parent class and override in the sub-classes, allowing the program to execute specific logic at runtime.
Robustness (Exception Handling): The application uses try-catch-finally blocks to intercept ArgumentException, FormatException, and general Exceptions.
