using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoKeyPlay : MonoBehaviour
{
	AudioSource audioSound;
	Camera camera;
	public float semitoneOffset = 0;
	// Start is called before the first frame update
	void Start()
	{
		camera = Camera.main;
		audioSound = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnMouseDown()
	{
		PlayAudio();
	}
	void PlayAudio()
	{
		audioSound.pitch = Mathf.Pow(2f, semitoneOffset / 12.0f);
		audioSound.Play();
	}

	/* 	void AudioPlay()
		{

			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				audioSound.pitch = Mathf.Pow(2f, semitoneOffset/12.0f);
				hit.collider.GetComponent<Renderer>().material.color = Color.red;
				audioSound.Play();
			}

		} */
}
