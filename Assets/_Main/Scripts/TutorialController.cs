using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialController : MonoBehaviour {

	private int pageIndex;
	[SerializeField] private GameObject box;
	[SerializeField] private GameObject pageIndicator;
	[SerializeField] private GameObject getStartedButtonObject;

	[Header("UI")]
	[SerializeField] private Sprite[] pageIndicatorSprites;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Next(){
		if(pageIndex < 2){
			box.transform.GetChild(pageIndex).gameObject.SetActive(false);
			pageIndicator.transform.GetChild(pageIndex).GetComponent<Image>().sprite = pageIndicatorSprites[0];
			pageIndex++;
			box.transform.GetChild(pageIndex).gameObject.SetActive(true);
			pageIndicator.transform.GetChild(pageIndex).GetComponent<Image>().sprite = pageIndicatorSprites[1];
		}

		if(pageIndex == 2){
			getStartedButtonObject.SetActive(true);
		}
	}

	public void Prev(){
		if(pageIndex > 0){
			box.transform.GetChild(pageIndex).gameObject.SetActive(false);
			pageIndicator.transform.GetChild(pageIndex).GetComponent<Image>().sprite = pageIndicatorSprites[0];
			pageIndex--;
			box.transform.GetChild(pageIndex).gameObject.SetActive(true);
			pageIndicator.transform.GetChild(pageIndex).GetComponent<Image>().sprite = pageIndicatorSprites[1];

			//Deactive getStartedButtonObject
			getStartedButtonObject.SetActive(false);
		}
	}
}
