using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigationQuaternionKeys2b : MonoBehaviour
{

    bool monocam = false;

    public Camera firstL;
    public Camera firstR;
    public Camera thirdCam;
    public Camera walkCam;
    public Animator anim;

    private Vector3 spawnPos;
    private Quaternion spawnRot;
    private float upP = 0;
    private float rightP = 0;
    private float RP = 0;

    GameObject warpBall;
    // Start is called before the first frame update
    void Start()
    {
        firstL = GameObject.Find("leftCam").GetComponent<Camera>();
        firstR = GameObject.Find("rightCam").GetComponent<Camera>();
        thirdCam = GameObject.Find("monoCam").GetComponent<Camera>();
        walkCam = GameObject.Find("monoCam").GetComponent<Camera>();
        thirdCam.gameObject.SetActive(false);
        firstL.gameObject.SetActive(true);
        firstR.gameObject.SetActive(true);
        walkCam.gameObject.SetActive(false);
        anim = gameObject.GetComponent<Animator>();
        warpBall = GameObject.Find("WarpBall");
        spawnPos = transform.position;
        spawnRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.UpArrow)){
             transform.Translate(Vector3.forward * Time.deltaTime);
       

            }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-1*Vector3.forward * Time.deltaTime);


        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = warpBall.transform.position;


        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(-1 * Vector3.up * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.RightArrow)){
		 transform.Translate(Vector3.right * Time.deltaTime);

            }
       if(Input.GetKey(KeyCode.LeftArrow)){
		 transform.Translate(-1*Vector3.right * Time.deltaTime);

            }

float smooth = 5.0f;
       if(Input.GetKey(KeyCode.A)){

            //transform.Rotate(transform.up, -15.0f*Time.deltaTime);
            //  transform.rotation = Quaternion.AngleAxis(-15.0f*Time.deltaTime, transform.up);
            transform.Rotate(Vector3.up, -35.0f * Time.deltaTime);
           
           
      }
      if(Input.GetKey(KeyCode.D)){

            //   transform.Rotate(transform.up, 15.0f*Time.deltaTime);
            transform.Rotate(Vector3.up, 35.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.Rotate(Vector3.right, 35.0f * Time.deltaTime);

        }
        if(Input.GetKey(KeyCode.W)) {
            transform.Rotate(Vector3.right, -35.0f * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward, 35.0f * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.forward, -35.0f * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.C)) {
            toggleMono();
        }
        if (Input.GetKeyDown(KeyCode.L)) {
            transform.position = spawnPos;
            transform.rotation = spawnRot;
            thirdCam.gameObject.SetActive(false);
            firstL.gameObject.SetActive(false);
            firstR.gameObject.SetActive(false);
            walkCam.gameObject.SetActive(true);
            GetComponentInChildren<Animator>().SetTrigger("doWalk");
        }



    }

    void toggleMono() {
        monocam = !monocam;
        thirdCam.gameObject.SetActive(monocam);
        firstL.gameObject.SetActive(!monocam);
        firstR.gameObject.SetActive(!monocam);

    }

}
