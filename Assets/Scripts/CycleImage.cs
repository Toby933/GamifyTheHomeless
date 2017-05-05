using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CycleImage : MonoBehaviour {
    public Sprite[] sceneImages;
    private GameObject baseImage;
    private float timer = 0;
    private float timerTarget;
    public float timerSpeed;


	// Use this for initialization
	void Start () {
        baseImage = GameObject.Find("BaseImage");
        baseImage.GetComponent<Image>().sprite = sceneImages[Random.Range(0, sceneImages.Length)];
        timerTarget += timerSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > timerTarget)
        {
            baseImage.GetComponent<Image>().sprite = sceneImages[Random.Range(0, sceneImages.Length)];
            timerTarget += timerSpeed;
        }
    }
}
