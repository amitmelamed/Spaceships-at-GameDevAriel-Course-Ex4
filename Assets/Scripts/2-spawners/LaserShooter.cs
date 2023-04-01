using UnityEngine;
using System.Collections;

/**
 * This component spawns the given laser-prefab whenever the player clicks a given key.
 * It also updates the "scoreText" field of the new laser.
 */
public class LaserShooter: ClickSpawner {
    [SerializeField] NumberField scoreField;
    [SerializeField] float timeBetweenShots = 0.5f;
    private bool canShoot = true;



    IEnumerator activateShooterTimer()
    {
        yield return new WaitForSeconds(timeBetweenShots);// Wait for one second

        canShoot = true;
        // All your Post-Delay Logic goes here:
        // Run functions
        // Set your Values
        // Or whatever else
    }
    protected override GameObject spawnObject() {
        if (!canShoot) 
        {
            return null;
        }
        //After Shooting, set canShoot to false and start the timer.
        //When the timer is done canShoot will be true and we will able to use spawnObject again.
        canShoot=false;
        StartCoroutine(activateShooterTimer());

        GameObject newObject = base.spawnObject();  // base = super

        // Modify the text field of the new object.
        ScoreAdder newObjectScoreAdder = newObject.GetComponent<ScoreAdder>();
        if (newObjectScoreAdder)
            newObjectScoreAdder.SetScoreField(scoreField);

        return newObject;
    }
}
