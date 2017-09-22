using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasePolice : MonoBehaviour {

	PlayerController playerScr1;
	PlayerController playerScr2;
    Dice diceScr;

	void Start()
	{

		GameObject player1 = GameObject.Find("Player1");
		GameObject player2 = GameObject.Find("Player2");
        GameObject dice = GameObject.Find("dice1");
		playerScr1 = player1.GetComponent<PlayerController>();
		playerScr2 = player2.GetComponent<PlayerController>();
        diceScr = dice.GetComponent<Dice>();

	}


	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.name == "Player1" && playerScr1.GetDeplacement()==0)
		{
            diceScr.SetPLayer1ToPLay(-1);
		}
		else if (other.gameObject.name == "Player2" && playerScr2.GetDeplacement() == 0)
		{
            diceScr.SetPLayer1ToPLay(2);
		}
	}
}