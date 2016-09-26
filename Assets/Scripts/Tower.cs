using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tower : MonoBehaviour {
    private int cost; // purchase cost
    private int damage; // per shot damage measure in health removed
    private int range; // attack range
    private int speed; // attack speed measured in shots per second
    private AttackPattern pattern;
    private List<Upgrade> availableUpgrades; // all upgrades available to be added to this tower
    private List<Upgrade> activeUpgrades; // all upgrades currently active on this tower

    public enum AttackPattern {First, Last, Close, Strong};

    public Tower()
    {
        /*
         * TODO these numbers need to be tweaked to appropriate values
         * these are just placeholders
         * TODO come up with upgrade lists for towers
         */
        //basic tower
        cost = 100;
        range = 100;
        damage = 50;
        speed = 1;
        pattern = AttackPattern.First;
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
        switch (pattern)
        {
            case AttackPattern.First:
                //TODO attack code
                break;
            case AttackPattern.Last:
                //TODO attack code
                break;
            case AttackPattern.Close:
                //TODO attack code
                break;
            case AttackPattern.Strong:
                //TODO attack code
                break;
        }
	}

    public void UpgradeTower()
    {
        /* 
         * TODO: Move first upgrade from availabeUpgrades to activeUpgrades
         */
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

    //BEING setters
    public void setPattern(AttackPattern pattern)
    {
        this.pattern = pattern;
    }
    //END setters

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
