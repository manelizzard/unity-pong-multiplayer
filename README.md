# Unity Pong Multiplayer
Classic pong game with network multiplayer.

# Usage

Press __SPACE__ key to start the game.

### Player 1
Press __W__ and __S__ to move the paddle upwards and downwards.
 
### Player 2
Press __UP ARROR__ and __DOWN ARROW__ to move the paddle upwards and downwards.

# Implementation

## Paddle
The paddle contains a kinematic RigidBody2D with a Polygon2D collider. This polygon enables to build a *non-rectangular* collider in order to allow the user more flexibility while hitting the ball.

The paddle is moved at a certain velocity with keys *W* and *S* and clamped to avoid losing it outside the field.

### Class hierarchy
__PaddleController__ is the base class controlling the paddle movement and limitations. Child classes, like __PlayerOneController__ and __PlayerTwoController__, enable two players in the same controller by specifying the control keys (W/S or ARROWS).

## Ball
The ball contains a script used to start the game with *SPACE* key and a collision detection (with lose triggers) to respawn and start a new game.

## Colliders
Aroud the field there are four colliders:

- Two for the floor and ceiling, with a Physic2D material bouncing.
- Two for the left and right walls. These ones are the colliders controlling the scores.

# Future work
- Create proper art (and resolution) for scores.
- Fix possible infite loops when ball bounces vertically against the walls.