using UnityEngine;
using System.Collections;

public class createAmmo : MonoBehaviour {
	
	public GameObject ammo;

	
	void Start() {

		//Ok so I know how to instatiate object on start of scene but I did each individually not randomnly.
		// I also assigned my own positions as I couldnt remember to do it randomnly either.
		GameObject cubeSpawn = (GameObject)Instantiate(ammo, new Vector3(10,2,0), transform.rotation);
		GameObject cubeSpawn1 = (GameObject)Instantiate(ammo, new Vector3(20,2,30), transform.rotation);
		GameObject cubeSpawn2 = (GameObject)Instantiate(ammo, new Vector3(22,2,40), transform.rotation);
		GameObject cubeSpawn3 = (GameObject)Instantiate(ammo, new Vector3(41,2,32), transform.rotation);
		GameObject cubeSpawn4 = (GameObject)Instantiate(ammo, new Vector3(36,2,12), transform.rotation);
		GameObject cubeSpawn5 = (GameObject)Instantiate(ammo, new Vector3(17,2,12), transform.rotation);
		GameObject cubeSpawn6 = (GameObject)Instantiate(ammo, new Vector3(35,2,27), transform.rotation);
		GameObject cubeSpawn7 = (GameObject)Instantiate(ammo, new Vector3(20,2,49), transform.rotation);
		GameObject cubeSpawn8 = (GameObject)Instantiate(ammo, new Vector3(30,2,46), transform.rotation);
		GameObject cubeSpawn9 = (GameObject)Instantiate(ammo, new Vector3(13,2,22), transform.rotation);
	}



		


	
	void Update() {
	}
}