﻿using UnityEngine;
using System.Collections;

public class newaxe_to_tree : MonoBehaviour {
	
	public GameObject tree_area;
	public GameObject axe_head;
	public GameObject branch;
	
	void Update () {
		Vector3 lp = tree_area.transform.position;
		float dis = Vector3.Distance (transform.position, lp);
		
		if (dis < 2f ) {
			if (GameObject.Find ("Boy").GetComponent<player_state> ().his_position == 5){
				GameObject.Find("EventSystem").GetComponent<on_correcteffect>().on_eff();
				if(Input.GetKeyUp(KeyCode.Mouse0)){
					
					GameObject.Find ("Text_text").GetComponent<text_manager_residence> ().change_sentence (4);
					GameObject.Find ("item").GetComponent <manage_inven> ().pop_item(this.gameObject);
					GameObject.Find ("item").GetComponent <manage_inven> ().push_item(axe_head);
					GameObject.Find ("item").GetComponent <manage_inven> ().push_item(branch);
					GameObject.Find ("blank").GetComponent<inven> ().dragitem = false ;
				}
			}
		}
		
	}
}
