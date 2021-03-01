using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
	public static int CurrentStage {
		get {return PlayerPrefs.GetInt("CurrentStage", 1);}
		set {
				PlayerPrefs.SetInt("CurrentStage", value);
		}
	}
}
