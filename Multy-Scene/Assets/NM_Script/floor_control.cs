using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class floor_control : MonoBehaviour {
	public static  float WIDTH = 500.0f;
	public static float HEIGHT = 500.0f;

	public GameObject[] terrain;
	public GameObject original_terrain;
	// Use this for initialization
	void Start () {
		//root = GameObject.Find("Show");
		Instantiate(original_terrain, new Vector3(0, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 camera_position = this.transform.position;//摄像机位置
		//Debug.Log("x:" + camera_position.x + ", y:" + camera_position.y + ", z:" + camera_position.z);
		//string curName = SceneManager.GetActiveScene().name;//获取当前场景的名称

		//int flag = (int)camera_position.x / WIDTH;
		if (camera_position.x > 250) {
			Instantiate(terrain[0], new Vector3(500, 0 , 0), Quaternion.identity);
		
		}


		/*
		if (camera_position.x > 250.0f) {
			Vector3 next_terrain_position = new Vector3(camera_position.x + 250, 0, 0);
			//找到物体
			//GameObject next_terrain = root.transform.Find("NewTerrain").gameObject;
			GameObject next_terrain = terrain[0];
			next_terrain.SetActive (true);
			Instantiate(next_terrain, next_terrain_position, Quaternion.identity);

			//SceneManager.LoadScene(name);
			//SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
		if (camera_position.z > 250.0f) {
			Vector3 next_terrain_position = new Vector3(0, 0, camera_position.x + 250);
			//找到物体
			//GameObject next_terrain = root.transform.Find("NewTerrain").gameObject;
			GameObject next_terrain = terrain[0];
			next_terrain.SetActive (true);
			Instantiate(next_terrain, next_terrain_position, Quaternion.identity);

		}
		
		*/

	}




}
