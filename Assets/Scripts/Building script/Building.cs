using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public GameObject building;
    public bool build;

    public float NPCRange = 0.5f;
    public Transform NPCfinder;

    // Start is called before the first frame update
    void Start()
    {
        build = building;
    }

    // Update is called once per frame
    void Update()
    {
        build = false;

        if ( build == false )
        {
            /* if ( woodCounter > 3 )
             { 
                 --wood;
                 --wood;
                 --wood;
                 build == true;
             } if ( woodCouner < 3 )
             {    
                 build == false;
             }
             if ( woodCounter > 2 )
             {
                 --wood;
                 --wood;
                 build == true;
             } if ( woodCounter < 2 )
             {
                 build = false;
             }
             if ( woodCounter > 1 )
             {
                 --wood;
                 build == true;
             } if ( woodCounter < 1 )
             {
                  build = false;
             } 
            
            if ( stoneCounter > 3 )
             { 
                 --stone;
                 --stone;
                 --stone;
                 build == true;
             } if ( stoneCouner < 3 )
             {    
                 build == false;
             }
             if ( stoneCounter > 2 )
             {
                 --stone;
                 --stone;
                 build == true;
             } if ( stoneCounter < 2 )
             {
                 build = false;
             }
             if ( stoneCounter > 1 )
             {
                 --stone;
                 build == true;
             } if ( stoneCounter < 1 )
             {
                  build = false;
             } 
             
                if ( metalCounter > 3 )
             { 
                 --metal;
                 --metal;
                 --metal;
                 build == true;
             } if ( metalCouner < 3 )
             {    
                 build == false;
             }
             if ( metalCounter > 2 )
             {
                 --metal;
                 --metal;
                 build == true;
             } if ( metalCounter < 2 )
             {
                 build = false;
             }
             if ( metalCounter > 1 )
             {
                 --metal;
                 build == true;
             } if ( metalCounter < 1 )
             {
                  build = false;
             } 
             */
        }

        // void MainReturn()
        // {
        //     /*
        //      if ( woodCounter == 0 )
        //     {
        //      Patroller = true;
        //     }
        //     if ( stoneCounter == 0 )
        //     {
        //      Patroller = true;
        //     }
        //     if ( metalCounter == 0 )
        //     {
        //      Patroller = true;
        //     }

        //     if ( woodCounter >= 1 )
        //     {
        //      Patroller = false;
        //     }
        //      if ( stoneCounter >= 1 )
        //     {
        //      Patroller = false;
        //     }
        //      if ( metalCounter >= 1 )
        //     {
        //      Patroller = false;
        //     }
        //     */
        // }

    }
}
