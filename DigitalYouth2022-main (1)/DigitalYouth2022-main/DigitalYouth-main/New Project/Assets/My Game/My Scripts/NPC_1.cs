using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
		Speech.AddDialogue("0", "Hello Human!", "1");
		Speech.AddDialogue("1", "We need your help!", "2");
		Speech.AddDialogue("2", "Monsters are attacking us!","3");
		Speech.AddDialogue("3", "But first go get your first powerup to get to the next level.");
		
	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other ){
		Speech.SetDialogue("0");
	}
}