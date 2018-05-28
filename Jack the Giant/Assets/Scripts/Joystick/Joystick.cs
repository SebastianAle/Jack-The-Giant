using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
	private PlayerMoveJoystick playerMove;


	void Start()
	{
		playerMove = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMoveJoystick> ();
	}

	public void OnPointerDown(PointerEventData data)
	{
		if (gameObject.name == "Left") 
		{
			playerMove.SetMoveLeft (true);
			//Debug.Log("I'm pressing the Left button");
		} 
		else 
		{
			playerMove.SetMoveLeft (false);
			//Debug.Log("I'm pressing the Right button");
		}
	}

	public void OnPointerUp(PointerEventData data)
	{
		playerMove.StopMoving ();
		//Debug.Log("I'm Releasing the button");
	}














}