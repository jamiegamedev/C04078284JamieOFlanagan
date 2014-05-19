using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//vhanged your tags to bot and ammo instead of leader and teaser.
        GameObject bot = GameObject.FindGameObjectWithTag("bot");
		GameObject bot1 = GameObject.FindGameObjectWithTag("bot");
		GameObject bot2 = GameObject.FindGameObjectWithTag("bot");
		GameObject bot3 = GameObject.FindGameObjectWithTag("bot");
		GameObject bot4 = GameObject.FindGameObjectWithTag("bot");
        GameObject ammo = GameObject.FindGameObjectWithTag("ammo");

        bot.GetComponent<StateMachine>().SwitchState(new IdleState(bot, ammo));
	
        ammo.GetComponent<StateMachine>().SwitchState(new TeaseState(ammo, bot));


       bot.renderer.material.color = Color.red;
       ammo.renderer.material.color = Color.blue;

        
	}
	// Update is called once per frame
	void Update () {
	
	}
}
