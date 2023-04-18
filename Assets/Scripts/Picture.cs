using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Picture : MonoBehaviour
{
    public string imgUrl = "";
    public Button button;
    public string tier = "";

    [SerializeField] int index;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onImageSelected()
    {
        FindObjectOfType<GameController>().selectedImg = imgUrl;
        FindObjectOfType<GameController>().selectedImgIndex = index;
        //Debug.Log("Picture");
    }
}
