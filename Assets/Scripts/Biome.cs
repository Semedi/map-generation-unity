using UnityEngine;
using System.Collections;
using System;

public class Biome : MonoBehaviour {

  
    public Tiles[] biomes;

    public Tiles get(string name)
    {
        for (int i = 0; i < biomes.Length; i++) {
            if (biomes[i].name == name)
                return biomes[i];
         }


        return null;
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
