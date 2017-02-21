using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupmushroom : collectable {
	public static int mushroomvalue = 1000;
	public int itemID = 1;

	override protected void OnCollect(GameObject target){

		var equipBehavior = target.GetComponent<equip> ();
		if (equipBehavior != null) {
			equipBehavior.currentItem = itemID;
			scoremanager.score += mushroomvalue;

		}
			
	}
}
