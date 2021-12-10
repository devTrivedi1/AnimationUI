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
		Camera camera = Camera.main;
		animation = GetComponent<Animator>();
		animation.SetBool("HighlightAnimation", true);
	}

	// Update is called once per frame
	void Update()
	{
        if(Input.GetMouseButtonDown(0))
        {
            animation.SetBool("Clicked", true);
        }
        else
        {
            animation.SetBool("Clicked", false);
        }
	}

	void AnimationHighlight()
	{

	
	}
}
