using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
	Camera camera;
	Animator animation;
	// Start is called before the first frame update
	void Start()
	{
		camera = Camera.main;
		animation = GetComponent<Animator>();
		animation.SetBool("HighlightAnimation", false);
	}

	// Update is called once per frame
	void Update()
	{
		AnimationHighlight();
		if (Input.GetMouseButtonDown(0))
		{
			animation.SetTrigger("Clicked");
		}
	}
	
	 	void AnimationHighlight()
		{
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				animation.SetBool("HighlightAnimation", true);
			}
			else
			{
				animation.SetBool("HighlightAnimation", false);
			}
			Debug.DrawRay(ray.origin, ray.direction * 10f);

		} 
}
