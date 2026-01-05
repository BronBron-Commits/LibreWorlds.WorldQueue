LibreWorlds.WorldQueue
Overview

LibreWorlds.WorldQueue is the thread-safe queuing layer in the LibreWorlds client pipeline.
It provides a clean boundary between world-intent production (from adapters) and world-state execution (by the runtime).

WorldQueue exists to buffer, order, and transport commands that represent authoritative world mutations, without executing them or knowing anything about how they will be applied.

Purpose

WorldQueue is responsible for:

Decoupling production from execution — commands can be created and queued independently of when they are executed.

Thread safety — multiple producers (e.g., network threads, adapters) can enqueue commands without risking race conditions.

Clear intent representation — world mutations are represented as plain data objects, with a stable contract.

Serving as an architectural boundary — this layer has zero knowledge of rendering, engines, or lifecycle.

What This Is

A world command buffer

A deterministic command transport layer

A set of pure command types (data + semantic intent)

A contract boundary between adapter and runtime

WorldQueue does not execute commands. Commands are applied later by the runtime.

What This Is NOT

Not an execution engine

Not a renderer

Not a protocol implementation

Not a UI

Not a simulator or mock

Commands in this layer do not perform side effects. They describe what should happen, not how.

Command Types

WorldQueue defines a set of concrete command types that represent world mutations:

AddObjectCommand

UpdateObjectTransformCommand

RemoveObjectCommand

Each command is a plain data holder with semantic meaning.

Core Interfaces
IWorldCommand

A command that can be executed later.
Commands do not execute themselves — instead, they are processed by the WorldRuntime.

IWorldCommandQueue

A thread-safe queue interface that allows producers to enqueue and consumers to dequeue commands.

WorldQueue includes a reference implementation of this queue.

High-Level Architecture
LibreWorlds SDK
        ↓
WorldAdapter
        ↓
WorldQueue
        ↓
WorldRuntime
        ↓
Concrete Engine (Godot / Native / Headless)


WorldAdapter produces commands

WorldQueue stores them

WorldRuntime executes them against a concrete engine

Design Principles

Separation of concerns — producers do not execute commands

Single responsibility — queue owns only buffering

Layered architecture — no engine or adapter leakage

Data-first semantics — commands are inert until executed

Getting Started
Build
dotnet clean
dotnet restore
dotnet build


This project targets .NET 10.0.

Typical Workflow

Adapter enqueues a world command:

queue.Enqueue(new AddObjectCommand(...));


Runtime dequeues and executes:

while (queue.TryDequeue(out var cmd))
    processor.Process(cmd);


Engine applies results (Godot / native / test engine).

Dependencies

WorldQueue is independent and engine-agnostic. It has no dependencies on:

Rendering libraries

Runtime or engine implementations

SDK or network protocols

It only depends on the .NET standard library.
