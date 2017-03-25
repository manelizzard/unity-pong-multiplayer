# Unity Pong Multiplayer
Classic pong game with network multiplayer.

# Usage

- Press __SPACE__ key to start the game. Only the __HOST__ can start the game.

- Press __UP ARROR__ and __DOWN ARROW__ to move the paddle upwards and downwards.

- Host player is always spawned on the right field, while client player on the left field.

# Implementation

### Paddle
The paddle contains a kinematic RigidBody2D with a Polygon2D collider. This polygon enables to build a *non-rectangular* collider in order to allow the user more flexibility while hitting the ball.

The paddle is moved at a certain velocity and clamped to avoid losing it outside the field.

### _Class hierarchy_
__PaddleController__ is the base class controlling the paddle movement and limitations. Child classes, like __PlayerController__, enable to specify the control keys (W/S or ARROWS).

### Ball
The ball contains a script used to detect collisions (with lose triggers), respawn and inform score manager.

### Colliders
Aroud the field there are four colliders:

- Two for the floor and ceiling, with a Physic2D material bouncing.
- Two for the left and right walls. These ones are the colliders controlling the scores.

# Multiplayer
__PongNetworkManager__ takes care of starting the game when two players are connected (only the host can start the game). The __ScoreManager__ class synchronizes its variables in order to be displayed in both clients, and two __prefabs__ (*Ball* and *Player*) are spawned. __Player__ prefab is *Local Player Authority* in order to allow user control.

### Starting the game
One client must start as __HOST__ using the UNet HUD provided, while the other one must connect as a __LAN Client__. The host __IP__ needs to be provided to the second client to be able to connect.

# Future work
- Create proper art (and resolution) for scores.
- Fix possible infite loops when ball bounces vertically against the walls.
- Implement a turn-based game start.
- Pack all assets in a SpriteSheet and create AssetsBundle in order to download season related assets. Implement particle systems and sound and include them in the AssetBundle.