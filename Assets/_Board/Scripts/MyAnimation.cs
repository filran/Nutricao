using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class MyAnimation : MonoBehaviour {

//	private GameObject myobject;
	public float posx { get; private set;}
	public float posy { get; private set;}
	public float posz { get; private set;}
	private float n;

	public MyAnimation()
	{
		posx = (float)this.transform.position.x;
		posy = (float)this.transform.position.y;
		posz = (float)this.transform.position.z;

		n = 0.1f;
	}


	void Start()
	{
		Debug.Log ( "Atual:\t\t"+posx+"\t"+posy+"\t"+posz );
		posy += n;
		Debug.Log ( "Animacao:\t\t\t"+posy);
		this.transform.position.Set ( posx,posy,posz );
		Debug.Log ( this.transform.position.y );
//		Debug.Log ( "Nova posicao:\t"+posx+"\t"+posy+"\t"+posz );

//		this.transform.DOLocalMoveY (posy+n,0.5f);
//		this.transform.DORotate ( new Vector3(-90,0,0),0.3f );
//		this.transform.position.Set ( posx , posy , posz );
	}

//	IEnumerator Start()
//	{
//		yield return new WaitForSeconds(0);
//
//		Sequence s = DOTween.Sequence ();
//		s.Append (this.transform.DORotate(new Vector3(-90,0,0),0.3f));
//		s.Insert (0, this.transform.DOLocalMoveY(posy+n,0.5f) );
//		yield return new WaitForSeconds(1.3f);
//		s.Insert (0, this.transform.DORotate (new Vector3(0,0,0),0.3f));
//
//		this.transform.position.Set ( posx,posy+n,posz );
//	}

	void Update()
	{


	}

}