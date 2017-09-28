using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public static UIManager Instance { get; private set; }

    public GameObject gameObjDisplayPhoto;
    public GameObject gameObjPlayVideo;
    void Awake()
    {
        Instance = this;
    }

    public void LoadPhotoToTexture(Texture2D texture)
    {
        gameObjDisplayPhoto.GetComponent<MeshRenderer>().materials[0].SetTexture("_MainTex", texture);
    }

    public void PlayVideo()
    {
        //((MovieTexture)gameObjCube.GetComponent<Renderer>().material.mainTexture).Play();
    }

}
