# Introduction

The code which is commented out is the initial problematic code. The problem should be solved in a better way and be executable.

## Problem

The code is tightly coupled. Adding or updating a ShapeType enum results in changes in the Canvas class. Next to that, if there are many ShapeTypes, the class Canvas gets very fat and complex.

The problem is, that the Shape class has only properties but has no methods. One of the principles of OOP is to encapsulate related data and behavior in one class. __Data should not be somewhere and behavior somewhere else__.

## Benefits of the solution
- The application is loosely coupled
- Related data and behavior is coupled in one unit instead of all over the place. DrawShape method of the Canvas class is not anymore defining different draw behaviors of different shapes.
- The Canvas class is simple and doesnt get bulky if more shapes are added.
- When a new shape is added, the Canvas class doesnt have to be updated.