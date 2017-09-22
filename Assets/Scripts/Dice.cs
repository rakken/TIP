using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{

    public int face;
    public Texture2D[] Faces;
    public GameObject dice1;
    private int PLayer1ToPLay = 1;
    PlayerController playerScr1;
    PlayerController playerScr2;
    public GameObject Joueur1;
    public GameObject Joueur2;

    void Start()
    {

        GameObject player1 = GameObject.Find("Player1");
        GameObject player2 = GameObject.Find("Player2");
        playerScr1 = player1.GetComponent<PlayerController>();
        playerScr2 = player2.GetComponent<PlayerController>();

    }

    void OnMouseDown()
    {
        if (PLayer1ToPLay >=1 && playerScr1.GetDeplacement() == 0 && playerScr2.GetDeplacement() == 0)
        {
            face = Random.Range(1, 6);

            GetComponent<Renderer>().material.mainTexture = Faces[face];
            playerScr1.SetDeplasement(face);
            PLayer1ToPLay -=1;
        }
        else if (playerScr1.GetDeplacement() == 0 && playerScr2.GetDeplacement() == 0)
        {
            face = Random.Range(1, 6);

            GetComponent<Renderer>().material.mainTexture = Faces[face];
            playerScr2.SetDeplasement(face);
            PLayer1ToPLay += 1;

        }
    }

	public void SetPLayer1ToPLay(int PLayer1ToPLay)
	{
		this.PLayer1ToPLay = PLayer1ToPLay;
	}


    // Update is called once per frame
    void Update()
    {
        if (playerScr1.GetDeplacement() != 0 || playerScr2.GetDeplacement() != 0)
        {
            Joueur2.SetActive(false);
            Joueur1.SetActive(false);
        }
        else if (PLayer1ToPLay > 0 && playerScr1.GetDeplacement() == 0 && playerScr2.GetDeplacement() == 0)
        {
            Joueur2.SetActive(false);
            Joueur1.SetActive(true);
        }
        else if (PLayer1ToPLay == 0 && playerScr1.GetDeplacement() == 0 && playerScr2.GetDeplacement() == 0)
        {
            Joueur1.SetActive(false);
            Joueur2.SetActive(true);
        }
    }
}
