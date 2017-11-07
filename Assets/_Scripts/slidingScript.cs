using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class slidingScript : MonoBehaviour {

	public Transform emptySlot;


	void OnMouseUp(){
		//Debug.Log("I was clicked");
//		print(this.gameObject.name + " was clicked " + Mathf.FloorToInt(Vector3.Distance(transform.position,emptySlot.position)));

		//print(this.gameObject.name + " was clicked " + Vector3.Distance(transform.position,emptySlot.position));
		if(Mathf.RoundToInt(Vector3.Distance(transform.position,emptySlot.position)+0.1f)==1 && gameManagerScript.Instance.solved == false){

			SoundEffectsHelper.Instance.MakeTileSlideSound();

			Vector3 temp1;
			Vector3 temp2;
			
			temp1   = transform.position;
			temp1.x = emptySlot.position.x;
			temp1.y = emptySlot.position.y;
			
			temp2   = emptySlot.position;
			temp2.x = transform.position.x;
			temp2.y = transform.position.y;
			
			transform.position = temp1;
			emptySlot.position = temp2;
		}
}
//	public void OnPointerEnter(PointerEventData eventData)
//	{
//		print("I was clicked");
//		//target = Color.blue;
//	}
}
