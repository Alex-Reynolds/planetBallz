using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


public class spawn_alians : MonoBehaviour
{
    int timer = 0;
    public GameObject type;
    public GameObject first;

    // Update is called once per frame
    void Update()
    {

        timer = timer + 1;
        if (timer > 240){
            timer = 0;
            GameObject meme = Instantiate(type, gameObject.transform.position, Quaternion.identity);
            alian new_alian = meme.GetComponent<alian>();
            new_alian.setNext(first);
           
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
