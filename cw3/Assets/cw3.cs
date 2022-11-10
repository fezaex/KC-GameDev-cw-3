using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    // hero stuff
    string heroName = "sam";
    int heroPower = 70;
    
    // villian stuff
    string villainName = "dablo";
    int villianPower = 70;



    // Start is called before the first frame update
    void Start()
    {
        if (villianPower < heroPower)
        {
            print("hero is stronger");
        }
        else if (villianPower > heroPower)
        {
            print("villian is stronger");
        }
        else
        {
            print("both are equal");
        }


        
    }
    




    void setspeed(float speed)
    {
        float Speed = 25.5f;
        float playerSpeed = 0f;
        print(playerSpeed);
        playerSpeed = speed;
        print(playerSpeed);
    }
}
