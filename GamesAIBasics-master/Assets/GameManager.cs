using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//changed your tags to bot and bot2 instead of leader and teaser.
        GameObject bot = GameObject.FindGameObjectWithTag("bot");
	
        GameObject bot2 = GameObject.FindGameObjectWithTag("bot2");

        bot.GetComponent<StateMachine>().SwitchState(new IdleState(bot, bot2));
	
        bot2.GetComponent<StateMachine>().SwitchState(new TeaseState(bot2, bot));


       bot.renderer.material.color = Color.blue;
       bot2.renderer.material.color = Color.red;

        
	}
	// Update is called once per frame
	void Update () {
	
	}
}
