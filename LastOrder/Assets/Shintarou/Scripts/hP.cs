using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hP : MonoBehaviour
{
	public Slider HPStrip;
	public int HP = 10;

	void Start ()
	{  
		HPStrip.maxValue = HP;
		HPStrip.value = HPStrip.maxValue; 
	}

	public void HpDamage ()
	{  
		HP -= 1;
		HPStrip.value = HP;
		if (HP <= 0) {  
			GameOver ();
		}  
	}

	public void Healing ()
	{
		
	}

	void GameOver ()
	{
		
	}
}
