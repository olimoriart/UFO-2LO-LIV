using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacles : MonoBehaviour
{
	public Image heart1;
	public Image heart2;
	public Image heart3;

	private void OnCollisionEnter2D(Collision2D obj)
	{
		if (obj.gameObject.CompareTag("UFO")) && heart1.gameObject.activeSelf == true)
		{
			heart1.gameObject.SetActive(false);
		}
		else if (heart1.gameObject.activeSelf == false && heart2.gameObject.activeSelf == true)
		{
			heart2.gameObject.SetActive(false);
		}
		else if (heart1.gameObject.activeSelf == false && heart2.gameObject.activeSelf == false)
		{
			heart3.gameObject.SetActive(false);
		}
}
