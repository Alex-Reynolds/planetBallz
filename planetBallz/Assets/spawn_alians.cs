using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


public class spawn_alians : MonoBehaviour
{
    int timer = 0;
    public GameObject type;
    public GameObject first;
    public GameObject ballCreature;
    public int launchTime;
    public int seed;
    bool hasRun = false;
    // Update is called once per frame
    void Update()
    {
        System.Random randTime = new Random(seed);
        
        if((launchTime > 500) && (hasRun == false))
        {
            hasRun = true;
            launchTime = 1000;
            launchTime = randTime.Next((launchTime - 400), (launchTime + 400));
            Debug.Log(launchTime);
        }

        timer = timer + 1;
        if (timer > launchTime){
            hasRun = false;
            timer = 0;
            GameObject meme = Instantiate(type, gameObject.transform.position, Quaternion.identity);
            alian new_alian = meme.GetComponent<alian>();
            new_alian.setNext(first);
            GameObject cowboy = Instantiate(ballCreature, gameObject.transform.position, Quaternion.identity);
            new_alian.setBallCreature(cowboy);
           
            if (type.name.Substring(0, 5) == "alian")
            {
                System.Random rand = new Random();
                double randValue = rand.NextDouble();

                if (randValue < 0.1)
                {
                    FindObjectOfType<AudioManager>().Play("PirateSpawn1");
                }
                else if (randValue < 0.2)
                {
                    FindObjectOfType<AudioManager>().Play("PirateSpawn2");
                }
                else if (randValue < 0.3)
                {
                    FindObjectOfType<AudioManager>().Play("PirateSpawn3");
                }
                else if (randValue < 0.4)
                {
                    FindObjectOfType<AudioManager>().Play("PirateSpawn4");
                }
            }
            else if (type.name.Substring(0,6) == "pireta")
            {
                System.Random rand = new Random();
                double randValue = rand.NextDouble();

                if (randValue < 0.1)
                {
                    FindObjectOfType<AudioManager>().Play("CowboySpawn1");
                }
                else if (randValue < 0.19)
                {
                    FindObjectOfType<AudioManager>().Play("CowboySpawn2");
                }
                else if (randValue < 0.28)
                {
                    FindObjectOfType<AudioManager>().Play("CowboySpawn3");
                }
                else if (randValue < 0.37)
                {
                    FindObjectOfType<AudioManager>().Play("CowboySpawn4");
                }
                else if (randValue < 0.38)
                {
                    FindObjectOfType<AudioManager>().Play("CowboySpawnRare1");
                }
                else if (randValue < 0.39)
                {
                    FindObjectOfType<AudioManager>().Play("CowboySpawnRare2");
                }
                else if (randValue < 0.40)
                {
                    FindObjectOfType<AudioManager>().Play("CowboySpawnRare3");
                }

            }
        }
        
    }
}
