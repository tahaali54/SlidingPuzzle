using UnityEngine;
using System.Collections;

public class tileScript : MonoBehaviour {
	//public Transform slot,slot2;
	//float xtemp,ytemp;
	//Vector3 temp;

	//void Update()
	//{
	//	Debug.Log (slot.transform.position);
	//}

	void OnMouseUp()
	{
		Clicked_Obj.Instance.setTile(this.gameObject);
		MeshRenderer[] r = GetComponentsInChildren<MeshRenderer> ();
		for (int i = 0; i < r.Length; i++)
		{
			// ... set their material color to the color specific to this tank.
			r[i].material.color = Color.yellow;
		}

	}

	void Update()
	{
		if (Clicked_Obj.Instance.getTile () != this.gameObject) {
			MeshRenderer[] r = GetComponentsInChildren<MeshRenderer> ();
			for (int i = 0; i < r.Length; i++)
			{
				// ... set their material color to the color specific to this tank.
				r[i].material.color = Color.white;
			}
		}
	}
	/*
	void OnMouseUp(){
		if(Vector3.Distance(transform.position,slot.position)==1 ){
			
			Vector3 temp1;
			Vector3 temp2;

			temp1   = transform.position;
			temp1.x = slot.position.x;
			temp1.y = slot.position.y;

			temp2   = slot.position;
			temp2.x = transform.position.x;
			temp2.y = transform.position.y;

			transform.position = temp1;
			slot.position = temp2;
		}
		else if(Vector3.Distance(transform.position,slot2.position)==1){

			Vector3 temp1;
			Vector3 temp2;

			temp1   = transform.position;
			temp1.x = slot2.position.x;
			temp1.y = slot2.position.y;

			temp2   = slot2.position;
			temp2.x = transform.position.x;
			temp2.y = transform.position.y;

			transform.position = temp1;
			slot2.position = temp2;
		}
		}
		*/
	}	

