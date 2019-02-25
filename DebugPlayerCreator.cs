using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPlayerCreator : MonoBehaviour {

	public PlayerList list;

	void Awake(){

		list.players.Clear();
		
		Player p1 = new Player();
		p1.color = new Color(0.9f,0.8f,0.1f);

		Player p2 = new Player();
		p2.color = new Color(0.1f,0.9f,0.1f);

		Player p3 = new Player();
		p3.color = new Color(0.1f,0.1f,0.9f);

		list.players.Add(p1);
		list.players.Add(p2);
		list.players.Add(p3);

	}

}
