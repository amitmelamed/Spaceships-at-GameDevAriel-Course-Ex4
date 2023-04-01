<div dir='rtl' lang='he'>

#  פיתוח משחקי מחשב
## קורס באוניברסיטת אריאל, בית-הספר למחשוב, סמסטר ב ה'תשפ"ג
----

My assigment was to choose between few core procceses in the game and change them, and add new features to the existing game.<br />
I choosed to make a timer for the player's shooting abilities, so that he will not be able to shoot at non-stop pace.<br />
After this I added a new level to the game include a new Boss enemy with AI Beheviare.<br />
<br />
![image](https://user-images.githubusercontent.com/88790441/229295204-70443e5a-6816-4ae2-ad4d-426d1b71e37c.png)<br />
I added a new Serielizable Field called Time Between Shots, which will be the delay time you must wait before taking another shot.<br />
<br />
The algorithm i have used:<br />
1.Initialize Private boolean variable called canShoot and initilized to true at the begining of the script.<br />
2.When Shooting:<br />
2.1 Check if we can shoot (canShoot var)<br />
2.1.1 false ->return null<br />
2.2 true -> set can shoot to false<br />
2.3 set timer that at the end of it set canShoot to true (Using IEnumerator)<br />
2.4 shoot<br />
<br />
![image](https://user-images.githubusercontent.com/88790441/229295654-8802482e-7069-4408-9f87-6c00b89aeb3b.png)<br />
<br />
The Second part of the assigment i created a new level to the game, by creating a new scene called amitLevel.<br />
After completing level-1, we will not move to level-2 with is "YOU WINN" screen.<br />
We will move to new level with new boss enemy i created.<br />
The boss will spawn Enemies at us and will move very fast from side to side. <br />
after hitting the boss, we will move to level-2 and complete the game.<br />![image](https://user-images.githubusercontent.com/88790441/229295965-685aa938-b346-4341-9e30-3206e768e1e9.png)
<br /><br />
For creating the boss i used an Enemy Spawner and added him:<br />
Rigidbody2D<br />
Polygon Colider 2D<br />
Sprite Render with new enemy sprite<br />
<br />
Boss AI script i created which move the boss from side to side, and when dealing with hit by laser - move to next level .<br /><br />
Inputs for script are where the Boss will move, trigering tag (laser by default), and the next scene to move when get hit.<br />
The boss object will be also destroyed by hit.
<br />
![image](https://user-images.githubusercontent.com/88790441/229296439-6c82eaa4-52be-470e-966a-6d0096d7f09c.png)

<br />
After destroying the boss we will move to level-2 and finish the game.<br />
  ![image](https://user-images.githubusercontent.com/88790441/229296727-182d50ed-04f5-44e5-baa1-7a743a739525.png)



</div>
