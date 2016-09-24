using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tower : MonoBehaviour {
    private int cost; // purchase cost
    private int damage; // per shot damage measure in health removed
    private int range; // attack range
    private int speed; // attack speed measured in shots per second
    private List<Upgrade> availableUpgrades; // all upgrades available to be added to this tower
    private List<Upgrade> activeUpgrades; // all upgrades currently active on this tower
    public Tower()
    {
        /*
         * TODO these numbers need to be tweaked to appropriate values
         * these are just placeholders
         */
        //basic tower
        cost = 100;
        range = 100;
        damage = 50;
        damage = 1;
        activeUpgrades = new List<Upgrade>();
        availableUpgrades = new List<Upgrade>();
    }

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    /* 
     * TODO: Move first upgrade from availabeUpgrades to activeUpgrades
     * if upgrade was successful, return true for potential debugging
     * if no upgrades left, return false
     */
    public bool UpgradeTower()
    {
        return false;
    }

    //BEGIN getters
    public int GetCost()
    {
        return cost;
    }

    public int GetDamage()
    {
        return damage;
    }

    public int GetRange()
    {
        return range;
    }

    public int GetSpeed()
    {
        return speed;
    }
    //END getters

    //maybe this should be its own file? but we can do that later
    private class Upgrade
    {
        private int damageUp; // damage added to tower once upgrade is active
        private int rangeUp; // range added to tower once upgrade is active
        private int speedUp; // attack speed added to tower once upgrade is active
        private int cost; // cost to add this upgrade to the tower
        private Upgrade(int rangeUp, int damageUp, int speedUp, int cost)
        {
            this.rangeUp = rangeUp;
            this.damageUp = damageUp;
            this.speedUp = speedUp;
            this.cost = cost;
        }

        private int GetDamageUpgrade()
        {
            return damageUp;
        }

        private int GetRangeUpgrade()
        {
            return rangeUp;
        }

        private int GetSpeedUpgrade()
        {
            return rangeUp;
        }
    }
}
