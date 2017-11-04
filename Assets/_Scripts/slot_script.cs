using UnityEngine;
using System.Collections;

public class slot_script : MonoBehaviour {
	private Transform tile;

	float xtemp,ytemp;
	Vector3 temp;


	void Update ()
	{
		if (Clicked_Obj.Instance.getTile().transform != null) {
			tile = Clicked_Obj.Instance.getTile().transform;
			if (Vector3.Distance(transform.position,tile.position)==1)
				this.GetComponent<SpriteRenderer>().enabled = true;
			else
				this.GetComponent<SpriteRenderer>().enabled = false;
		}
		else
			this.GetComponent<SpriteRenderer>().enabled = false;
	}
	void OnMouseUp(){

		tile = Clicked_Obj.Instance.getTile().transform;
		if(Vector3.Distance(transform.position,tile.position)==1 ){
			
			Vector3 temp1;
			Vector3 temp2;
			
			temp1   = transform.position;
			temp1.x = tile.position.x;
			temp1.y = tile.position.y;
			
			temp2   = tile.position;
			temp2.x = transform.position.x;
			temp2.y = transform.position.y;
			
			transform.position = temp1;
			tile.position = temp2;
		}

	}	
}
