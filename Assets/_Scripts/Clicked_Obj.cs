using UnityEngine;
using System.Collections;

public class Clicked_Obj : MonoBehaviour {

	public static Clicked_Obj Instance;
	private GameObject clicked_tile;
	void Start () {
		Instance = this;
			Clicked_Obj.Instance.setTile(this.gameObject);

	}
	public void setTile(GameObject ClickOn_Tile)
	{
		clicked_tile = ClickOn_Tile;
	}
	public GameObject getTile()
	{
		return clicked_tile;
	}

}
