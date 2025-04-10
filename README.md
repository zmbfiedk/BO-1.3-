# Mechanics Plus Explanation

In this section, I'll explain the mechanics used in the project and where I got the inspiration for each.

## Movement
The movement system was inspired by a YouTube tutorial I found a while ago while working on the first game project of this school year. It's a basic system that works well for 2D games and handles movement inputs for the player.

## Shooting
For the shooting mechanics, my friend, who has made similar games in the past, helped me. He explained how to set up the shooting system, including how bullets should be instantiated and how to manage their movement.

## Enemies
The enemy system was designed from scratch by me, although I did use Google for some references and information on implementing certain elements. The code for the enemy AI and movement is entirely written by me.

## Enemy Check
For the enemy check system, I used ChatGPT to guide me on which Unity tools would be most effective. ChatGPT helped me understand how to set up the enemy detection and how to optimize the system.

## Boss
The boss system is essentially a reuse of the enemy code with an extra function added for special behavior. I simply expanded on the original enemy code to create a more complex boss fight mechanic.

## Code Links
You can find all the code for these mechanics in the following links:

- [Boss.cs](https://github.com/zmbfiedk/BO-1.3-/blob/main/Assets/Scripts/Boss.cs)
- [BossBullet.cs](https://github.com/zmbfiedk/BO-1.3-/blob/main/Assets/Scripts/Bossbullet.cs)
- [Bullet.cs](https://github.com/zmbfiedk/BO-1.3-/blob/main/Assets/Scripts/Bullet.cs)
- [EnemyFollow.cs](https://github.com/zmbfiedk/BO-1.3-/blob/main/Assets/Scripts/EnemyFollow.cs)
- [EnemyManager.cs](https://github.com/zmbfiedk/BO-1.3-/blob/main/Assets/Scripts/EnemyManager.cs)
- [Movement.cs](https://github.com/zmbfiedk/BO-1.3-/blob/main/Assets/Scripts/Movement.cs)
- [Enemy.cs](https://github.com/zmbfiedk/BO-1.3-/blob/main/Assets/Scripts/enemy.cs)

## GIFs
Here are the GIFs showcasing some of the mechanics:

- [Movement & Shooting GIF 1](Assets/Gifs/ezgif-1050bc84d09653.gif)
- [Movement & Shooting GIF 2](Assets/Gifs/ezgif-10b8570b8c750a.gif)
