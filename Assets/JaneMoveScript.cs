using UnityEngine;
using System.Collections;

public class JaneMoveScript : MonoBehaviour {
	public static bool  isMoving = false;
	//private float speed = 3.5F;
	private float speed = 16.5F;
	private int phase = 1;
	public AnimationClip walkAnimation;
	public AnimationClip idleAnimation;
	private Vector3 moveDirection = Vector3.zero;
	private Vector3 moveRotation=new Vector3(0.0f,0.053f,0.0f);
	public bool needRotation = true;
	void Update() {
		Animation _animation = GetComponent<Animation>();
		if (isMoving) {
			if (GameStages.stageId == 1) {
				moveToStage1();
			}
			if (GameStages.stageId == 2) {
				if (phase==1) {
					moveToStage2();
				}
				else if(phase==2) {
					moveToStage2_ph2();
				}
			}
		} else {
			_animation.CrossFade (idleAnimation.name);
		}
	}
	void moveToStage1() {

		Animation _animation = GetComponent<Animation>();
		_animation.CrossFade (walkAnimation.name);
		
		CharacterController controller = GetComponent<CharacterController>();
		if ((transform.position.x <= 120) && (transform.position.x >= 90)) {
			transform.Rotate(new Vector3(0.0f,0.05f,0.0f));
		}
		if ((transform.position.x <= 80) && (transform.position.x >= 77)) {
			transform.Rotate(new Vector3(0.0f,-0.25f,0.0f));
		}
		if (transform.position.x <= 77) {
			isMoving=false;
		}
		//moveDirection = moveDirection* moveRotation;
		Vector3 c = Vector3.forward;
		transform.Translate (c *speed* Time.deltaTime);
		//controller.Move(moveDirection * Time.deltaTime);	
	}
	void moveToStage2() {
		Animation _animation = GetComponent<Animation>();
		CharacterController controller = GetComponent<CharacterController>();
		if (needRotation) {
			Debug.Log(transform.rotation);
			Quaternion q=transform.rotation;
			q.y=-3.0f;
			transform.rotation=q;
			needRotation=false;
			Debug.Log(transform.rotation);
		} else {
			_animation.CrossFade (walkAnimation.name);
			Vector3 c = Vector3.forward;
			transform.Translate (c *speed* Time.deltaTime);
		}
		if((transform.position.x <= 70)&&(transform.position.z <= 196)) {
			phase=2;
			Debug.Log("DJIGURDA");
		}
	}
	void moveToStage2_ph2() {
		Animation _animation = GetComponent<Animation>();
		CharacterController controller = GetComponent<CharacterController>();
		_animation.CrossFade (walkAnimation.name);
		Vector3 c = Vector3.forward;
		transform.Translate (c *speed* Time.deltaTime);
		if (transform.position.z>192) {
			transform.Rotate(new Vector3(0.0f,-1.0f,0.0f));
		}
		if(transform.position.z<=175) {
			isMoving=false;
		}
	}
	void movetoStage3() {
	
	}

}
