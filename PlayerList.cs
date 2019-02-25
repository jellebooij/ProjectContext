using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerList", menuName = "DrinkingWild/PlayerList", order = 0)]
public class PlayerList : ScriptableObject {
	public List<Player> players = new List<Player>();
	
}
