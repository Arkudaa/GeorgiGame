using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {
	public EnemySpawner enemyspawner;
	public int enemiesToSpawn;
	private int waveCount=1;
	private int wavetoWin=6;
	public AudioSource music;
	public AudioClip waveMusic;
	public GameObject cutScene;

	// Use this for initialization
	protected void Start () 
	{
		EnemySpawner.activated = false;
		enemiesToSpawn = waveCount * 2;
		music.Play();
		cutScene.SetActive(false);
	}

	// Update is called once per frame
	protected void Update () 
	{
		if(waveCount > wavetoWin) 
		{
		  enemyspawner.gameObject.SetActive(false);
			cutScene.SetActive(true);
		  return;
			
		}


		if(enemyspawner.transform.childCount==0 && EnemySpawner.activated)
        {
			if (waveCount == 1)
			{
				music.clip = waveMusic;
				music.Play();
			}
			HUD.Message("Round:" + waveCount);
			spawnWave();
			waveCount++;
			enemiesToSpawn = Random.Range(waveCount * 1, waveCount * 2);
        }

		
	}


	public void spawnWave()
    {
		for (int i = 0; i < enemiesToSpawn; i++)
		{
			enemyspawner.Spawn();
		}
	}
}