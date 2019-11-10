using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
	//キューブの移動速度
	private float speed = -12;
	//消滅チ
	private float deadLine = -10;

	//効果音を取得
	public AudioClip block;
	AudioSource audioSource;


	// Use this for initialization
	void Start () {
		//コンポーネントを取得
		audioSource = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		//キューブを移動させる
		transform.Translate(this.speed*Time.deltaTime,0,0);
		//画面外に出たら破棄する
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "CubeTag" || other.gameObject.tag =="GroundTag"){
			audioSource.PlayOneShot (block);
		}

}
}