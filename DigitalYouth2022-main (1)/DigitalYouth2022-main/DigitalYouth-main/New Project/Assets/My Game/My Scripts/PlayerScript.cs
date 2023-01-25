using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public int coin;


	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start() {
		
	}
		
		
		
	

	// OnTriggerEnter is called when the Collider "collided" enters the trigger.
	protected void OnTriggerEnter(Collider collided) {

		// Check for collision with coins
		if (collided.gameObject.tag == "Coin") {  
			
			Destroy(collided.gameObject);
			coin++;
			HUD.UpdateCoinCount(coin);

		}

		if (collided.gameObject.name == "Powerup1")
			{ 
				Destroy(collided.gameObject);
				Abilities.doubleJumpEnabled = true;
				HUD.Message("You got powerup! Jump higher!");
			}

		if (collided.gameObject.name == "Powerup2")
		{
			Destroy(collided.gameObject);
			Abilities.spinAttackEnabled = true;
			HUD.Message("You got powerup! Do Spinattack!");
		}

		if (collided.gameObject.name == "Powerup3")
        {
			Destroy(collided.gameObject);
			Abilities.speedBoostEnabled = true;
			HUD.Message("You got secret powerup! I do not know what this does!");
        }
		
        
	
        
		
        

			
			
        
	}
}


