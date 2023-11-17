using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
	// Start is called before the first frame update
		//typ mazwe ()
		//{
		//return 
		//}
		//int float string void
		public void LoadStartScene()
		{
			SceneManager.LoadScene(1);

		}
		public void Quit()
		{
			Application.Quit();

		}
		public void LoadNextScene()
		{
			int currentIndex = SceneManager.GetActiveScene().buildIndex;
			SceneManager.LoadScene(currentIndex+1);
		}
}