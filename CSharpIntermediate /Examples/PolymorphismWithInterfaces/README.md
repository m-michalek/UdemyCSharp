# Introduction

The code which is commented out is the initial problematic code. The problem should be solved in a better way and be executable.

## Problem

The code is tightly coupled. Adding or updating a new notification channel results in changes in the VideoEncoder class. 

The __Open Closed Principle__ is violated.

OCP: Software entities should be open for extension but closed for modification.

## Benefits of the solution
- The application is loosely coupled
- Better testable
- Better extendable

## Alternatives

This problem could also have been solved using __events and delegates__ which is part of the C# Advanced Course.