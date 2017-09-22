using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseDirection : MonoBehaviour {

    public int directionHorizontal;
    public int directionVertical;

	PlayerController playerScr1;
	PlayerController playerScr2;

	void Start()
	{

		GameObject player1 = GameObject.Find("Player1");
		GameObject player2 = GameObject.Find("Player2");
		playerScr1 = player1.GetComponent<PlayerController>();
		playerScr2 = player2.GetComponent<PlayerController>();

	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player1") {
            playerScr1.SetVertical(directionVertical);
            playerScr1.SetHorizontal(directionHorizontal);
        }
		else if (other.gameObject.name == "Player2") {
            playerScr2.SetVertical(directionVertical);
            playerScr2.SetHorizontal(directionHorizontal);
        }
	}
}
