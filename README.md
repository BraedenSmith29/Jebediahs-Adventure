# Jebediah's Adventure
Take control of Jebediah in this fast-paced platformer-shooter. Fight off an onslaught of aliens in an attempt to survive as long as possible! I made this game the summer before High School as my final project in a Unity course. It's kind of ridiculous, but it was a fun project to work on.

<img src="https://user-images.githubusercontent.com/90221641/155039294-bb3dced0-f0ab-4fa0-aab9-ed1eab397a5c.png" alt="Jabediah's Adventure Screenshot" width= "40%"/>

## Installation
To install the game, simply click on the latest release and download the .zip file corresponding to your operating system. Once you've done that, just extract and run!

## How to Play
### Controls:
* The space key is your jetpack. Hold it to fly and press it for a short burst.
* The A and D keys will move you right and left, respectively.
* The gun is aimed with your mouse and fired by left-clicking.

### Rules:
1. The object of the game is to get as many points as possible before you die.
2. You start with 10 lives and will lose one each time you are hit by an alien spaceship.
3. When your lives reach 0, you will lose the game.
4. You will gain a point every time you shoot an alien.

## How It's Made
The game's organization is relatively complex, but this is the gist:
* The arena is made with default platforms in various rotations.
* The character sprite and sounds were found on the internet.
* The game is managed by the GameMaster object, which runs scripts that keep score and spawn enemies.
* The enemies spawn in random locations and charge straight for the character.
* The character is controlled by the PlayerMovement script and has a child object which spawns bullets in the proper orientation when they are fired.

### What I Learned
* How to use Unity to easily make complex games
* How to write games in and just generally use C#
* How to design levels to be fun and fair
* How to create and use UI elements to convey important game information

## Known Issues
* There are almost no comments. I could definitely use some comments. Apparently young me found them unnecessary.
* The collisions for the ground are pretty janky on some parts of the map.
* The game can be kind of unfair, with the aliens going through walls and such.

## Planned Features
As it stands, I consider this game complete. It was only meant to be a small project. However, I may continue its development if I am truly struck with the inspiration.
