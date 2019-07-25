using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FieldSelection : MonoBehaviour
{
Ray ray;
RaycastHit hit;
    [SerializeField] GameObject Fieldpoint;

    [SerializeField] Vector3 PointCoordinates;
    [SerializeField]public Vector3 Pointindex;
    
    [SerializeField] int[,] Grid = new int[3,3];

    [SerializeField] GameObject Xprefab;
    [SerializeField] GameObject Oprefab;
    [SerializeField] bool Usemouse;
    
    bool turn = true;
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Grid[i,j] = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        
         PointCoordinates.x =(Pointindex.x-1)*3;
        PointCoordinates.y = (Pointindex.y-1)*3;
        Fieldpoint.transform.position = PointCoordinates;
    }
    
    public void Movepoint(Vector3 dir)
    { int tempx=(int)Pointindex.x;
        int tempy=(int)Pointindex.y;
        



        tempx += (int)dir.x;
        tempy += (int)dir.y;

        if (tempx>2)
        {
            tempx = 0;
        }
         if (tempx<0)
        {
            tempx = 2;
        }
         if (tempy>2)
        {
            tempy = 0;
        }
         if (tempy<0)
        {
            tempy = 2;
        }
        Pointindex = new Vector3(tempx,tempy,0);



    }    

   public void Click()
    {
        
        
//            Debug.Log(PointCoordinates);
            if (Grid[(int)Pointindex.x,(int)Pointindex.y] ==0)
            {
                if (turn)
            {
                Instantiate(Xprefab,PointCoordinates,Quaternion.identity);
                Grid[(int)Pointindex.x,(int)Pointindex.y] = 1;
                turn = !turn;
                WinCheck((int)Pointindex.x,(int)Pointindex.y,1);
            }
            else
            {
                Instantiate(Oprefab,PointCoordinates,Quaternion.identity);
                Grid[(int)Pointindex.x,(int)Pointindex.y] = 2;
                turn = !turn;
                WinCheck((int)Pointindex.x,(int)Pointindex.y,2);
            }
            }
              
              
        
    }

    void WinCheck(int x, int y,int sign)
    { int sum = 0;
            
            if ((x+y)%2==0 )
            {
                Debug.Log("11");
                for (int i = 0; i < 3; i++)
                {
                    if (Grid[i,i] == sign)
                    {
                     sum++;
                    }
                }
                Debug.Log("/"+sum);
                if (sum >= 3 )
               {
                   SceneManager.LoadScene("SampleScene",LoadSceneMode.Single);
               }

               sum =0;
                for (int i = 0; i < 3; i++)
                {
                    if (Grid[2-i,i] == sign)
                    {
                     sum++;
                    }
                }
                Debug.Log("/"+sum);

                
            }
            

            if (sum >= 3 )
               {
                   SceneManager.LoadScene("SampleScene",LoadSceneMode.Single);
               }

               sum =0;
            
            for (int i = 0; i < 3; i++)
            {
                if (Grid[x,i] == sign)
                {
                    sum++;
                }
            
               
            }

            if (sum>= 3 )
               {
                   SceneManager.LoadScene("SampleScene",LoadSceneMode.Single);
               }

               sum =0;
            for (int i = 0; i < 3; i++)
            {
                if (Grid[i,y] == sign)
                {
                    sum++;
                }

               
            }
            if (sum >= 3 )
               {
                   SceneManager.LoadScene("SampleScene",LoadSceneMode.Single);
               }

               sum =0;

            
    }
}
