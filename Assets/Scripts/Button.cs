using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {


    float ElapsedTime;
    float FinishTime;
    Vector3 StartPosition;
    Vector3 Target;

    private Vector3 startPos;
    private Vector3 endPos;
    private float distance = 50f;



    public Text activateText;
    bool insideColliderButton1 = false;
    bool insideColliderButton2 = false;
    bool insideColliderButton3 = false;
    bool insideColliderRefresh = false;
    bool insideColliderWallButton = false;

    Vector3 start;
    Vector3 mainCubePos;
    Vector3 mainCube1Pos;
    Vector3 mainCube2Pos;
    Vector3 mainCube3Pos;
    Vector3 mainCube4Pos;
    Vector3 mainCube5Pos;
    Vector3 mainCube6Pos;
    Vector3 mainCube7Pos;
    Vector3 mainWallPos;


    public GameObject cube;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5;
    public GameObject cube6;
    public GameObject cube7;
    public GameObject wallToMove;

    void Start()
    {
      

        activateText.text = "";

        cube = GameObject.Find("Cube");
        mainCubePos = cube.transform.localPosition;       


        cube1 = GameObject.Find("Cube (1)");
        mainCube1Pos = cube1.transform.localPosition;
       

        cube2 = GameObject.Find("Cube (2)");
        mainCube2Pos = cube2.transform.localPosition;
     

        cube3 = GameObject.Find("Cube (3)");
        mainCube3Pos = cube3.transform.localPosition;
       

        cube4 = GameObject.Find("Cube (4)");
        mainCube4Pos = cube4.transform.localPosition;
     

        cube5 = GameObject.Find("Cube (5)");
        mainCube5Pos = cube5.transform.localPosition;
       

        cube6 = GameObject.Find("Cube (6)");
        mainCube6Pos = cube6.transform.localPosition;
       

        cube7 = GameObject.Find("Cube (7)");
        mainCube7Pos = cube7.transform.localPosition;

        wallToMove = GameObject.Find("InsidePiece (10)");
        mainWallPos = wallToMove.transform.localPosition;

        Vector3 StartPosition = Vector3.zero;
        Target = Vector3.one * 50;
        ElapsedTime = 0;
        FinishTime = 60f;
    }





    void Update()
    {

        ElapsedTime += Time.deltaTime;


        if (insideColliderButton1 == true)
        {
            if (Input.GetButtonDown("Interact"))
            {
                CubeMoving();             
                Cube3Moving();
                Cube4Moving();
                Cube5Moving();
            }
        }

        else if (insideColliderButton2 == true)
        {
            if (Input.GetButtonDown("Interact"))
            {
                Cube1Moving();
                Cube2Moving();
                Cube3Moving();
                Cube4Moving();
            }
        }

        else if (insideColliderButton3 == true)
        {
            if (Input.GetButtonDown("Interact"))
            {
                CubeMoving();
                Cube5Moving();
                Cube6Moving();
                Cube7Moving();
            }
        }

        else if (insideColliderRefresh == true)
        {
            if (Input.GetButtonDown("Interact"))
            {
                cube.transform.localPosition = mainCubePos;
                cube1.transform.localPosition = mainCube1Pos;
                cube2.transform.localPosition = mainCube2Pos;
                cube3.transform.localPosition = mainCube3Pos;
                cube4.transform.localPosition = mainCube4Pos;
                cube5.transform.localPosition = mainCube5Pos;
                cube6.transform.localPosition = mainCube6Pos;
                cube7.transform.localPosition = mainCube7Pos;
            }
        }

        else if (insideColliderWallButton == true)
        {
            if (Input.GetButtonDown("Interact"))
            {
                wallToMove.transform.position = Vector3.Lerp(StartPosition, Target, ElapsedTime / FinishTime);
               // wallToMove.transform.localPosition = new Vector3(9.18f, -10f, 6.09f);
            }
                
            
        }
    }


    //ALL THE CUBE MOVING LOCATIONS


    void CubeMoving()
    {

        if (cube.transform.localPosition == mainCubePos)
        {
            cube.transform.localPosition = new Vector3(-1.5f, -2.1f, -0.85f);
        }

        else if (cube.transform.localPosition != mainCubePos)
        {
             cube.transform.localPosition = mainCubePos;
        }
    }

    void Cube1Moving()
    {
        if (cube1.transform.localPosition == mainCube1Pos)
        {
            cube1.transform.localPosition = new Vector3(-0.57f, -1.76f, -0.85f);
        }

        else if (cube1.transform.localPosition != mainCube1Pos)
        {
            cube1.transform.localPosition = mainCube1Pos;
        }
    }

    void Cube2Moving()
    {
        if (cube2.transform.localPosition == mainCube2Pos)
        {
            cube2.transform.localPosition = new Vector3(0.4f, -1.4f, -0.85f);
        }

        else if (cube2.transform.localPosition != mainCube2Pos)
        {
            cube2.transform.localPosition = mainCube2Pos;
        }
    }

    void Cube3Moving()
    {
        if (cube3.transform.localPosition == mainCube3Pos)
        {
            cube3.transform.localPosition = new Vector3(0.75f, -1.18f, 0.185f);
        }

        else if (cube3.transform.localPosition != mainCube3Pos)
        {
            cube3.transform.localPosition = mainCube3Pos;
        }
    }

    void Cube4Moving()
    {
        if (cube4.transform.localPosition == mainCube4Pos)
        {
            cube4.transform.localPosition = new Vector3(0.75f, -0.79f, 1.185f);
        }

        else if (cube4.transform.localPosition != mainCube4Pos)
        {
            cube4.transform.localPosition = mainCube4Pos;
        }
    }

    void Cube5Moving()
    {
        if (cube5.transform.localPosition == mainCube5Pos)
        {
            cube5.transform.localPosition = new Vector3(-0.25f, -0.67f, 1.185f);
        }

        else if (cube5.transform.localPosition != mainCube5Pos)
        {
            cube5.transform.localPosition = mainCube5Pos;
        }
    }

    void Cube6Moving()
    {
        if (cube6.transform.localPosition == mainCube6Pos)
        {
            cube6.transform.localPosition = new Vector3(-1.25f, -0.34f, 1.185f);
        }

        else if (cube6.transform.localPosition != mainCube6Pos)
        {
            cube6.transform.localPosition = mainCube6Pos;
        }
    }

    void Cube7Moving()
    {
        if (cube7.transform.localPosition == mainCube7Pos)
        {
            cube7.transform.localPosition = new Vector3(-1.3f, -0.04f, 0.2f);
        }

        else if (cube7.transform.localPosition != mainCube7Pos)
        {
            cube7.transform.localPosition = mainCube7Pos;
        }
    }






    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (this.gameObject.CompareTag("Button1"))
            {
                insideColliderButton1 = true;
                SetButtonText(); 
            }

            else if (this.gameObject.CompareTag("Button2"))
            {
                insideColliderButton2 = true;
                SetButtonText();
            }

            else if (this.gameObject.CompareTag("Button3"))
            {
                insideColliderButton3 = true;
                SetButtonText();
            }

            else if (this.gameObject.CompareTag("WallButton"))
            {
                insideColliderWallButton = true;
                SetButtonText();
            }



            else if (this.gameObject.CompareTag("Reset"))
            {
                insideColliderRefresh = true;
                SetResetText();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (this.gameObject.CompareTag("Button1"))
            {
                DeleteButtonText();
                insideColliderButton1 = false;
            }

            else if (this.gameObject.CompareTag("Button2"))
            {
                DeleteButtonText();
                insideColliderButton2 = false;
            }

            else if (this.gameObject.CompareTag("Button3"))
            {
                DeleteButtonText();
                insideColliderButton3 = false;
            }

            else if (this.gameObject.CompareTag("WallButton"))
            {
                insideColliderWallButton = false;
                DeleteButtonText();
            }



            else if (this.gameObject.CompareTag("Reset"))
            {
                DeleteButtonText();
                insideColliderRefresh = false;
            }
        }
    }






    void SetButtonText()
    {
        activateText.text = "Press E to Activate";
    }

    void DeleteButtonText()
    {
        activateText.text = "";
    }


    void SetResetText()
    {
        activateText.text = "Press E to Reset";
    }

    void DeleteResetText()
    {
        activateText.text = "";
    }
}
