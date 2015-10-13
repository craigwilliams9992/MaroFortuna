﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BullSelect : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        /*
        bool available = false;
        int i;
        for (i = 0; i < Data.currentChars.Count; i++)
        {
            if (Data.currentChars[i].charName == "Artemis the Wolf")
            {
                available = true;
                break;
            }
        }
        if (available && (Data.currentChars[i] != Data.currentCharDesc))
        {
            GameObject.Find ("Sitting Bull").GetComponent<SpriteRenderer> ().color = Color.white;
			Data.currentChars [i].isPicked = false;
		}
        */
	}
	
	void OnMouseDown(){

		bool available = false;


		if (Data.onCrewScene) {

			int i;
			for (i = 0; i < Data.currentChars.Count; i++) {
				if (Data.currentChars [i].charName == "Sitting Bull") {
					available = true;
					break;
				}
			}

			if(available){

				if (!Data.currentChars [i].isPicked) {	
					GameObject.Find ("Sitting Bull").GetComponent<SpriteRenderer> ().color = Color.green;
					Data.currentChars [i].setPicked ();
					Data.currentCharDesc = Data.currentChars[i];
				} 
				else if (Data.currentChars [i].isPicked) {
					GameObject.Find ("Sitting Bull").GetComponent<SpriteRenderer> ().color = Color.white;
					Data.currentChars [i].setPicked ();
				}

			}

		}

		else 
		{
			int i;
			for (i = 0; i < Data.currentChars.Count; i++) {
				if (Data.currentChars [i].charName == "Sitting Bull") {
					available = true;
					break;
				}
			}
			
			if (available) {
				if (!(Data.currentChars [i].isPicked) && (Data.currentCrewSize < Data.pickedMission.squadSize)) {

					GameObject.Find ("Sitting Bull").GetComponent<SpriteRenderer> ().color = Color.green;
					Data.activeMissionChars.Add (Data.currentChars [i]);
					Data.currentCrewSize += 1;
					Data.currentChars [i].setPicked ();
				} else if (Data.currentChars [i].isPicked) {
					GameObject.Find ("Sitting Bull").GetComponent<SpriteRenderer> ().color = Color.white;
					Data.activeMissionChars.Remove (Data.currentChars [i]);
					Data.currentCrewSize -= 1;
					Data.currentChars [i].setPicked ();
				}
			}
		}
	}
}
