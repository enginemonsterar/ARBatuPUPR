using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterAR.Utility;
public class GameController : Singleton<GameController> {

	[SerializeField] private GameObject infoPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTracking(int id){		
		infoPanel.SetActive(true);
	}

	public void OnLost(int id){		
		infoPanel.SetActive(false);
	}

}
