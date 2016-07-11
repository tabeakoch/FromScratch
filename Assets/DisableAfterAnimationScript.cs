using UnityEngine;
using System.Collections;

public class DisableAfterAnimationScript
: MonoBehaviour {
	public Animator EquipmentSlotAnimator; 

	private bool open = false;

	public void OnSignifierGrabClick (){
		
			EquipmentSlotAnimator.SetTrigger ("fadeout");
			StartCoroutine (DisableAfterAnimation());

			
	}

	IEnumerator DisableAfterAnimation () {
		yield return new WaitForSeconds (1.5f);
		this.gameObject.SetActive (false);
	}
}
 