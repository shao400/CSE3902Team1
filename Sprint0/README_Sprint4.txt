CSE3902 SU2020
The Legend of Zelda --Sprint4

Author: Chuwen Sun, Gengyi Qin, Ouyang Lufei, Zhizhou He, Zinan Zhang, Zilin Shao
Date: 7/20/2020


Overview of Sprint4: 
-----------------------------------
1. HUD/Inventory and maps
2. First level of the game
3. Projectile classes and collisions
4. Sounds added
5. Warnings fixes, redundant code deleted and adjusted.

Keys and gems are set to a large number for testing purpose.

Program Control: 
-----------------------------------
W,A,S,D and arrow keys---Walk
Z---Stab
N---Shoot the sword  //may be a bit different from the original game.

( In Pause screen, Z & N for picking item to equip )  

LeftClick(Mouse)---Previous Room
RightClick(Mouse)---Next Room  //Left for test purposes
R---Restart game
Q/Esc---Quit game

Suppressed Warnings:
-----------------------------------
1. X and Y coordinate and some variables in Player1.cs: Link's position and current state need to be updated or accessed by other classes
2. Lists and Link objects in roomProperties: need to be accessed by other classes to update Link and rooms
3. Sprite objects in SpriteFactory: they need to be accessed by other classes to draw sprites
4. Room-related and GameState variables in Game1: they need to be accessed when switching the room
5. Content object in SpriteFactory: it is initialized and loaded in Game1 class so no need to handle the exception
6. Lists in Player1: these lists will be initiated by Game1 class
7. Reader object in Loader class: reader will be initiated in Game1 class
8. GameState-related variables in Game1.cs: need to be accessed by other classes
9. List/ Item counter in Inventory.cs: need to be updated or accessed by player classes
10. Some null-exception warning: they are instantiated elsewhere 


Known bugs / TO-DOs for Sprint4
-----------------------------------
1. When Link have collision with enemy on the top of the room, Link will be pushed to unexpected positions. 
2. Every room has its own health bar instead of having the only one.
3. Smaller doors are not covered by sprites so when Link walk through it he seems to be floating above the door
4. Some of the enemy/NPC/items are not implemented, or not added to the game, as the Level-1 don't contain them.
5. Several enemy sprite sheets need to be updated and reversed / Oldman is still an IEnemy class, which should be INPC
6. Utility classes are not finished yet and need future updates.
7. Player class need to be divided as it is too long
