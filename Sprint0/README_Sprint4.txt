CSE3902 SU2020
The Legend of Zelda --Sprint3

Author: Chuwen Sun, Gengyi Qin, Ouyang Lufei, Zhizhou He, Zinan Zhang, Zilin Shao
Date: 6/27/2020


Overview of Sprint4: 
-----------------------------------
1. HUD/Inventory and maps
2. First level of the game
3. Projectile classes and collisions
4. Sounds added
5. Warnings fixes, redundant code deleted and adjusted.

Program Control: 
-----------------------------------
W,A,S,D and arrow keys---Walk
Z---Stab
N---Shoot the sword  //may be a bit different from the original game.
1,2,3---Switch weapons

LeftClick(Mouse)---Previous Room
RightClick(Mouse)---Next Room  //Left for test purposes
R---Restart game
Q/Esc---Quit game

Suppressed Warnings:
-----------------------------------
1. X and Y coordinate in Player1.cs: Link's position need to be updated by other classes
2. Lists and Link objects in roomProperties: need to be accessed by other classes to update Link and rooms
3. Sprite objects in SpriteFactory: they need to be accessed by other classes to draw sprites
4. Room-related variables in Game1: they need to be accessed when switching the room
5. Content object in SpriteFactory: it is initialized and loaded in Game1 class so no need to handle the exception
6. Lists in Player1: these lists will be initiated by Game1 class
7. Reader object in Loader class: reader will be initiated in Game1 class


Known bugs for Sprint3
-----------------------------------
1. When Link have collision with enemy on the top of the room, Link will be pushed to unexpected positions. 
2. Every room has its own health bar instead of having the only one.

TO-DOs:
-----------------------------------
1. Several enemy sprite sheets need to be updated and reversed
2. Boss/Dragon fireballs need to be added, they are not in any sprite sheets that's currently available
