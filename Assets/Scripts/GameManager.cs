using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

	private bool gameHasEnded = false;

	public Rotator rotator;
	public Spawner spawner;

	public Animator animator;
	public static Text text;
	public static int PinCount;
	
    public Rigidbody2D rb;
    

    public void EndGame()
	{
		if (gameHasEnded)
			return;

		rotator.enabled = false;
		spawner.enabled = false;

		animator.SetTrigger("EndGame");

		gameHasEnded = true;
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
    public void LevelComplete()
    {
        if (PinCount == 10)
        {
			
            SceneManager.LoadScene("End");
        }

    }


}