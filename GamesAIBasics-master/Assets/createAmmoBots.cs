using UnityEngine;
using System.Collections;

public class createAmmoBots : MonoBehaviour {
	

	public GameObject bot;
	public GameObject bot2;


	void Start() {

		//spawned one. could not figure out spawning 10 seperate objects.
	
//		GameObject ammoSpawn1 = (GameObject)Instantiate(ammo, new Vector3(20,2,30), transform.rotation);
//		GameObject ammoSpawn2 = (GameObject)Instantiate(ammo, new Vector3(22,2,40), transform.rotation);
//		GameObject ammoSpawn3 = (GameObject)Instantiate(ammo, new Vector3(41,2,32), transform.rotation);
//		GameObject ammoSpawn4 = (GameObject)Instantiate(ammo, new Vector3(36,2,12), transform.rotation);
//		GameObject ammoSpawn5 = (GameObject)Instantiate(ammo, new Vector3(17,2,12), transform.rotation);
//		GameObject ammoSpawn6 = (GameObject)Instantiate(ammo, new Vector3(35,2,27), transform.rotation);
//		GameObject ammoSpawn7 = (GameObject)Instantiate(ammo, new Vector3(20,2,49), transform.rotation);
//		GameObject ammoSpawn8 = (GameObject)Instantiate(ammo, new Vector3(30,2,46), transform.rotation);
//		GameObject ammoSpawn9 = (GameObject)Instantiate(ammo, new Vector3(13,2,22), transform.rotation);

		//Same with the Bots as the ammo crates (one bot for now)
		GameObject botSpawn5 = (GameObject)Instantiate(bot, new Vector3(13,0,-10), transform.rotation);

		GameObject botSpawn = (GameObject)Instantiate(bot2, new Vector3(25,2,0), transform.rotation);
//		GameObject botSpawn6 = (GameObject)Instantiate(bot, new Vector3(24,2,7), transform.rotation);
//		GameObject botSpawn7 = (GameObject)Instantiate(bot, new Vector3(40,2,19), transform.rotation);
//		GameObject botSpawn8 = (GameObject)Instantiate(bot, new Vector3(20,2,31), transform.rotation);
//		GameObject botSpawn9 = (GameObject)Instantiate(bot, new Vector3(52,2,47), transform.rotation);
	}



		


	
	void Update() {
	}
}