# Unity Pong Multiplayer
Classic pong game with network multiplayer.

# Usage

Press __SPACE__ key to start the game and __W__,__S__ to move the paddle upwards and downwards.

# Implementation

## Paddle
The paddle contains a kinematic RigidBody2D with a Polygon2D collider. This polygon enables to build a *non-rectangular* collider in order to allow the user more flexibility while hitting the ball.

The paddle is moved at a certain velocity with keys *W* and *S* and clamped to avoid losing it outside the field.

## Ball
The ball contains a script used to start the game with *SPACE* key and a collision detection (with lose triggers) to respawn and start a new game.

## Colliders
Aroud the field there are four colliders:

- Two for the floor and ceiling, with a Physic2D material bouncing.
- Two for the left and right walls. These ones are the colliders controlling the scores (game lose in this early stage of the game).